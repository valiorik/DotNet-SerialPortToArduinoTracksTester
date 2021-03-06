﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortToArduinoTracksTester.BL
{
    public class NewDataEventArgs : EventArgs
    {
        public NewDataEventArgs(byte[] data)
        {
            Data = data;
        }

        public byte[] Data { get; private set; }
    }
}
