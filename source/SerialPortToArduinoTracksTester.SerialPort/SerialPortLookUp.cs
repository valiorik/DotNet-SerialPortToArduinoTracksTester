using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortToArduinoTracksTester.BL
{
    public class SerialPortLookUp
    {
        public string[] GetActiveSerialPortsNames()
        {
            return SerialPort.GetPortNames();
        }
    }
}
