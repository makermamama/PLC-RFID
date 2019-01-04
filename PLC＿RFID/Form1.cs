using NetFrame.Net.TCP.Sock.Asynchronous;
using RFID_RW.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PLC＿RFID
{
    public partial class RFIDAuto : Form
    {
        private SerialPort ComPort;
        private SerialPort PlcPort;
        private SerialPort MarkingPort;
        private SerialPort TagCheckPort;
        private Reader ReaderControllor;

        public int writeRead = 0;
        public int CheckRead = 1;

        private DataTable TagsTable = new DataTable();


        public delegate void delegateUpDataUI(String msg,String Status);

        delegateUpDataUI UpDataTableWrite;
        delegateUpDataUI UpDataTableCheck;

        public RFIDAuto()
        {
            InitializeComponent();
            initDevice();
        }

        private void initDevice()
        {
            txtIP.Text = "192.168.1.168";
            txtPort.Text = "6000";
            txtWriteSum.Text = "0";

            timerGetClient.Start();
            dataGridViewTags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ComPort = new SerialPort();
            PlcPort = new SerialPort();
            MarkingPort = new SerialPort();
            ReaderControllor = new Reader();
            ReaderControllor.cmd.MultiEPC_Event += ShowEPC;

            UpDataTableWrite = UpOneMsgWrite;
            UpDataTableCheck = UpOneMsgCheck;


            //初始化写入数据
            TagsTable = Access.GetTopfiveHundred().Tables[0];
            dataGridViewTags.DataSource = TagsTable;

            String sql3 = String.Format("FStatus = '{0}'", Access.Unwrite);
            if (TagsTable.Select(sql3).Length > 0)
            {
                DataRow Rows = TagsTable.Select(sql3)[0];
                txtWriteData.Text = Rows["Fdata"].ToString();
            }

        }

        private void btnComControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnComControl.BackColor == SystemColors.Control)
                {
                    ComPort.PortName = "";
                    ComPort.BaudRate = 9600;
                    ComPort.Open();
                    btnComControl.BackColor = Color.Green;
                }
                else if (btnComControl.BackColor == Color.Green)
                {
                    ComPort.Close();
                    btnComControl.BackColor = SystemColors.Control;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPLC_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnPLC.BackColor == SystemColors.Control)
                {
                    PlcPort.PortName = "";
                    PlcPort.BaudRate = 9600;
                    PlcPort.Open();
                    PlcPort.DataReceived += new SerialDataReceivedEventHandler(PlcPortRecive);
                    btnPLC.BackColor = Color.Green;
                }
                else if (btnComControl.BackColor == Color.Green)
                {
                    PlcPort.Close();
                    btnPLC.BackColor = SystemColors.Control;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnTagCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnTagCheck.BackColor == SystemColors.Control)
                {
                    TagCheckPort.PortName = "";
                    TagCheckPort.BaudRate = 9600;
                    TagCheckPort.Open();
                    PlcPort.DataReceived += new SerialDataReceivedEventHandler(TagCheckRecive);
                    btnTagCheck.BackColor = Color.Green;
                }
                else if (btnTagCheck.BackColor == Color.Green)
                {
                    PlcPort.Close();
                    btnTagCheck.BackColor = SystemColors.Control;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMarking_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnMarking.BackColor == SystemColors.Control)
                {
                    MarkingPort.PortName = "";
                    MarkingPort.BaudRate = 9600;
                    MarkingPort.Open();
                    btnMarking.BackColor = Color.Green;
                }
                else if (btnMarking.BackColor == Color.Green)
                {
                    MarkingPort.Close();
                    btnMarking.BackColor = SystemColors.Control;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRFID_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRFID.BackColor == SystemColors.Control)
                {
                    string dev_ip = txtIP.Text.ToString();
                    int port = int.Parse(txtPort.Text);
                    IPAddress ipaddress = IPAddress.Parse(dev_ip);
                    ReaderControllor.ServerStart(ipaddress, port);
                    btnRFID.BackColor = Color.Green;
                }
                else if (btnRFID.BackColor == Color.Green)
                {
                    ReaderControllor.ServerClose();
                    btnRFID.BackColor = SystemColors.Control;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private String PlcReciveData;
        private void PlcPortRecive(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] readBuffer = new byte[PlcPort.ReadBufferSize];
            PlcPort.Read(readBuffer, 0, readBuffer.Length);
            PlcReciveData += System.Text.Encoding.Default.GetString(readBuffer);
            if (PlcReciveData.Length == 2)
            {
                //写入-送料信号
                ReaderControllor.ReadTags(ReaderControllor.GetClientInfo()[writeRead], "", 0x00, "", 1, 2, 6);
                //检测-送料信号
                ReaderControllor.ReadTags(ReaderControllor.GetClientInfo()[CheckRead], "", 0x00, "", 1, 2, 6);

                AddReciveMsg();
                PlcReciveData = "";
            }
        }

        private String TagCheckReciveMsg;
        private void TagCheckRecive(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] readBuffer = new byte[PlcPort.ReadBufferSize];
            PlcPort.Read(readBuffer, 0, readBuffer.Length);
            TagCheckReciveMsg += System.Text.Encoding.Default.GetString(readBuffer);
            if (TagCheckReciveMsg.Substring(TagCheckReciveMsg.Length-2,2) == "\r\n")
            {
                ComReciveData[1] = TagCheckReciveMsg;
                TagCheckReciveMsg = "";
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 读取数据参数回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowEPC(object sender, Command.ShowEPCEventArgs e)
        {
            try
            {
                string[] result = e.CommandRespond.Split(',');
                byte type = Convert.ToByte(result[1], 16);
                switch (type)
                {
                    //读取标签
                    case Types.READ_TAGS_RESPOND:
                        if (result[2] == "1" && result[3] == "000000000000000000000000")
                        {
                            string resultEPC = ReaderControllor.WriteTags(ReaderControllor.GetClientInfo()[0], "", 0x00, "", 0, 0, 4, txtKillPassword.Text + txtEPCpassWord.Text);
                            RFIDWriteState.Operate = RFIDWriteState.WritePassword;
                        }
                        else if (result[2] == "1" && result[3] != "000000000000000000000000") {
                            //检测二维码标签是否与RFID标签相同
                            if (result[3] == ComReciveData[0])
                            {
                                //发送给PLC
                                Access.UpdataOneCheck(result[3], Access.Havewrite);
                                this.Invoke(UpDataTableWrite, new object[] { txtWriteData.Text, Access.Havewrite });
                                //发送写标成功信号,500毫秒的低电平，PLC电平触发任务
                                Sleep(500, 2);
                            }
                            else {
                                Access.UpdataOneCheck(txtWriteData.Text, Access.FailCheck);
                                this.Invoke(UpDataTableCheck, new object[] { result[3], Access.FailCheck });
                            }
                        }
                        //标签损坏
                        else if (result[2] != "1") {
                            Access.UpdataOneWirte(txtWriteData.Text, Access.WriteFail);
                            this.Invoke(UpDataTableWrite, new object[] { txtWriteData.Text, Access.WriteFail });
                        }
                        break;

                    //写标签
                    case Types.WRITE_TAGS_RESPOND:
                        if (result[2] == "1" && RFIDWriteState.Operate == RFIDWriteState.WritePassword)
                        {
                            AsyncSocketState WorkingReader = ReaderControllor.GetClientInfo()[0];
                            //判断数据长度是否为24位,若不是24位自动补够24位
                            String Writedata = txtWriteData.Text;
                            if (txtWriteData.Text.Length < 24)
                            {
                                Writedata = Writedata.PadRight(24, '0');
                            }
                            string resultRPC = ReaderControllor.WriteTags(ReaderControllor.GetClientInfo()[0], "", 0x00, "", 1, 2, 6, Writedata);
                            RFIDWriteState.Operate = RFIDWriteState.WriteEPC;
                        }
                        else if (result[2] == "1" && RFIDWriteState.Operate == RFIDWriteState.WriteEPC) {
                            string resultEPCLock = ReaderControllor.LockTags(ReaderControllor.GetClientInfo()[0], txtEPCpassWord.Text, 254, "", new byte[] { 3, 192, 160 });
                            RFIDWriteState.Operate = RFIDWriteState.LockTags;
                        }
                        break;

                    //锁标签
                    case Types.LOCK_TAGS_RESPOND:
                        //锁RFID标签成功
                        if (result[2] == "1" && RFIDWriteState.Operate == RFIDWriteState.LockTags)
                        {
                            //跟新数据状态
                            Access.UpdataOneWirte(txtWriteData.Text, Access.Havewrite);
                            this.Invoke(UpDataTableWrite,new object[] { txtWriteData.Text, Access.Havewrite });
                            //发送写标成功信号,500毫秒的低电平，PLC电平触发任务
                            Sleep(500,1);
                            //给激光喷码机发送数据
                            MarkingPort.Write(txtWriteData.Text);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }


        private void timerGetClient_Tick(object sender, EventArgs e)
        {
            timerGetClient.Enabled = false;
            List<NetFrame.Net.TCP.Sock.Asynchronous.AsyncSocketState> asynSockets = ReaderControllor.GetClientInfo();
            int i = 0;
            foreach (NetFrame.Net.TCP.Sock.Asynchronous.AsyncSocketState bean in asynSockets)
            {
                if (bean.ip_addr == "192.168.1.10") {
                    writeRead = i;
                    txtRFIDWriteIP.Text = bean.ip_addr;
                }

                if (bean.ip_addr == "192.168.1.11")
                {
                    CheckRead = i;
                    txtRFIDCheckIP.Text = bean.ip_addr;
                }
                i++;  
            }
            timerGetClient.Enabled = true;
        }


        /// <summary>
        /// 跟新数据的写入状态
        /// </summary>
        /// <param name="data"></param>
        /// <param name="staus"></param>
        private void UpOneMsgWrite(String data,String staus)
        {
            String sql = String.Format("Fdata = '{0}'", data);
            DataRow dr = TagsTable.Select(sql)[0];

            dr["FStatus"] = staus;

            String _sql = String.Format("FStatus = '{0}' or FStatus = '{1}' ", Access.Havewrite,Access.WriteFail);
            DataRow[] drs = TagsTable.Select(_sql);
            if (drs.Length == TagsTable.Rows.Count)
            {
                TagsTable = Access.GetTopfiveHundred().Tables[0];
                dataGridViewTags.DataSource = TagsTable;            
            }

            String sql3 = String.Format("FStatus = '{0}'", Access.Unwrite);
            DataRow Rows = TagsTable.Select(sql3)[0];

            txtWriteData.Text = Rows["Fdata"].ToString();
            txtWriteSum.Text = (Convert.ToInt32(txtWriteSum.Text) + 1).ToString();
            dataGridViewTags.Refresh();

            int row = this.dataGridViewTags.CurrentRow.Index + 1;
            if (row > this.dataGridViewTags.RowCount - 1)
                row = 0;
            dataGridViewTags.CurrentCell = this.dataGridViewTags[0, row];

            txtError.Text = "";
        }

        /// <summary>
        /// 跟新数据的检测状态
        /// </summary>
        /// <param name="data"></param>
        /// <param name="staus"></param>
        private void UpOneMsgCheck(String data, String staus)
        {
            String sql = String.Format("Fdata = '{0}'", data);
            DataRow dr = TagsTable.Select(sql)[0];
            dr["FCheck"] = staus;
            dataGridViewTags.Refresh();
        }


        private void Sleep(int msec,int Task)
        {
            Thread thr = new Thread(() =>
            {
                switch (Task)
                {
                    case 1:
                        ComPort.Write("IN(0111)");
                        Thread.Sleep(msec);//休眠时间
                        ComPort.Write("IN(1111)");
                        break;
                    case 2:
                        ComPort.Write("IN(1011)");
                        Thread.Sleep(msec);//休眠时间
                        ComPort.Write("IN(1111)");
                        break;
                }
            });
        }

        String[] ComReciveData = new string[2];
        private void AddReciveMsg()
        {
            ComReciveData[0] = ComReciveData[1];
            ComReciveData[1] = "";
        }

        /***测试代码**/
        String TestMsg = "";
        private void button1_Click(object sender, EventArgs e)
        {
            TestMsg = txtWriteData.Text;
            Access.UpdataOneWirte(txtWriteData.Text, Access.Havewrite);
            UpOneMsgWrite(txtWriteData.Text,Access.Havewrite);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Access.UpdataOneCheck(TestMsg, Access.HaveCheck);
            UpOneMsgCheck(TestMsg, Access.HaveCheck);
        }
        /***测试代码**/
    }
}
