using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPortToArduinoTracksTester.BL
{
    class SerialException : Exception
    {
        private string message;

        public SerialException(string message)
        {
            this.message = message;
        }
    }
}
