using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PLC＿RFID
{
    class RFIDWriteState
    {
        public const int WritePassword = 0;

        public const int WriteEPC = 1;

        public const int LockTags = 2;

        public const int Start = -1;

        public static int Operate;

    }
}
