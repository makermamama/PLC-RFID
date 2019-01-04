using RFID_RW.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLC＿RFID
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTagsLead_Click(object sender, EventArgs e)
        {
            try
            {
                btnTagsLead.Enabled = false;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;//该值确定是否可以选择多个文件
                dialog.Title = "请选择文件夹";
                dialog.Filter = "所有文件(*.txt)|*.txt";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    String fName = dialog.FileName;
                    System.IO.StreamReader sr = new System.IO.StreamReader(fName, Encoding.Default);
                    String line;
                    DataTable datas = new DataTable();
                    datas.Columns.Add("Fdata", typeof(string));
                    datas.Columns.Add("FStatus", typeof(string));
                    datas.Columns.Add("FCheck", typeof(string));
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != "")
                        {
                            DataRow row = datas.NewRow();
                            row["Fdata"] = line;
                            row["FStatus"] = Access.Unwrite;
                            row["FCheck"] = Access.UnCheck;
                            datas.Rows.Add(row);
                        }
                    }
                    Access.LeadRFIDTag(datas);
                    MessageBox.Show("导入成功");
                }
                btnTagsLead.Enabled = true;
            }
            catch (Exception ex)
            {
                btnTagsLead.Enabled = true;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
