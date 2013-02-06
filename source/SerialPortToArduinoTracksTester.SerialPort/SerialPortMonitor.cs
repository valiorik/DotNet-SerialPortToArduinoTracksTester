using System.Text;
using System.IO;
using System.IO.Ports;
using System;

namespace SerialPortToArduinoTracksTester.BL
{
    class SerialPortMonitor
    {
        private SerialPort serial;
        private string comPortName;
        private int baudRate;
        private int dataBits;
        private StopBits stopBits;
        private Parity parityControl;
        private ASCIIEncoding encoding;

        public static SerialPortMonitor Instance()
        {
            if (instance == null)
            {
                instance = new SerialPortMonitor();
            }
            return instance;
        }

        private static SerialPortMonitor instance = null;

        private SerialPortMonitor()
        {
            serial = new SerialPort();
            encoding = new ASCIIEncoding();
        }

        public void Configure(int baudRate, int dataBits, StopBits stopBits, Parity parityControl)
        {
            this.baudRate = baudRate;
            this.dataBits = dataBits;
            this.stopBits = stopBits;
            this.parityControl = parityControl;
        }
        
        public void Open(string port)
        {
            if (IsOpen())
            {
                throw new SerialException("Serial Port is Already open");
            }
            else
            {
                if (port == null)
                {
                    throw new SerialException("Serial Port not defined. Cannot open");
                }

                serial.PortName = port;

                try
                {
                    if (serial.IsOpen)
                    {
                        serial.Close();
                    }

                    serial.BaudRate = baudRate;
                    serial.DataBits = dataBits;
                    serial.Parity = parityControl;
                    serial.StopBits = stopBits;

                    serial.Open();
                }
                catch (UnauthorizedAccessException uaex)
                {
                    throw uaex;
                }

                comPortName = port;
            }
        }

        public void close()
        {
            if (serial.IsOpen)
            {
                serial.Close();
            }
        }

        public bool IsOpen()
        {
            return serial.IsOpen;
        }

        public bool HasData()
        {
            return serial.BytesToRead > 0;
        }

        public char ReadChar()
        {
            int data = serial.ReadByte();
            return (char)data;
        }

        public int ReadBytes(ref byte[] array)
        {
            int size = array.Length;
            char readChar;
            int counter = 0;
            for (counter = 0; counter < size; counter++)
            {
                if (TryToGetChar(out readChar))
                {
                    array[counter] = (byte)readChar;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }

        public string ReadStringUntil(char stopChar)
        {
            char readChar;
            string response = "";
            while (TryToGetChar(out readChar))
            {
                response = response + readChar;
                if (readChar == stopChar)
                {
                    break;
                }
            }
            return response;
        }

        private bool TryToGetChar(out char charValue)
        {
            charValue = (char)0x00;
            
            long timeout = 10;
            long tickLimit = System.Environment.TickCount + timeout;

            while (System.Environment.TickCount < tickLimit)
            {
                if (HasData())
                {
                    int data = serial.ReadByte();
                    charValue = (char)data;
                    return true;
                }
            }
            return false;
        }
        
        public void Send(string output)
        {
            byte[] bytes = encoding.GetBytes(output);
            serial.Write(bytes, 0, bytes.Length);
        }

        public void Send(char output)
        {
            char[] data = new char[1];
            data[0] = output;
            serial.Write(data, 0, 1);
        }


        public void Send(byte[] output)
        {
            serial.Write(output, 0, output.Length);
        }

        public void ClearBuffer()
        {
            if (serial.IsOpen)
            {
                serial.DiscardInBuffer();
                serial.DiscardOutBuffer();
            }
        }
    }
}