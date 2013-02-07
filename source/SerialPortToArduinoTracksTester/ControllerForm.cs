using SerialPortToArduinoTracksTester.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortToArduinoTracksTester
{
    public partial class ControllerForm : Form
    {
        private SerialPortMonitor monitor;

        public ControllerForm()
        {
            InitializeComponent();

            // warm up serial port singleton
            monitor = SerialPortMonitor.Instance();

            // configure serial port
            monitor.Configure(9600, 8, System.IO.Ports.StopBits.One, System.IO.Ports.Parity.None);

            // wire up monitor events
            monitor.OnUpdateStatus += new SerialPortMonitor.StatusUpdateHandler(MonitorEvent_UpdateStatus);
            monitor.OnNewData += new SerialPortMonitor.NewDataHandler(MonitorEvent_NewDataRecieved);
        }

        private void MonitorEvent_UpdateStatus(object sender, StatusEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<StatusEventArgs>(MonitorEvent_UpdateStatus), new object[] { sender, e });
                return;
            }

            AddNewItemToLog(string.Format("Status: {0}", e.Status));
        }

        private void MonitorEvent_NewDataRecieved(object sender, NewDataEventArgs e)
        {       
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<NewDataEventArgs>(MonitorEvent_NewDataRecieved), new object[] { sender, e });
                return;
            }
            
            var decodedMessage = Encoding.ASCII.GetString(e.Data);

            AddNewItemToLog(string.Format("Recieved: {0}", decodedMessage));            
        }

        private void AddNewItemToLog(string item)
        {
            var time = DateTime.Now;
            var timeStamp = string.Format("{0}.{1}:{2}",
                time.Minute,
                time.Second,
                time.Millisecond);

            var record = string.Format("{0} {1}", timeStamp, item);

            LogListBox.Items.Add(record);
            LogListBox.SelectedItem = record;
        }

        private void ControllerForm_Load(object sender, EventArgs e)
        {
            PopulateComPortsList();
        }

        private void comPortListRefreshButton_Click(object sender, EventArgs e)
        {
            PopulateComPortsList();
        }

        private void ComPortListConnectButton_Click(object sender, EventArgs e)
        {
            if (monitor.IsOpen())
            {
                monitor.Close();
            }
            else
            {
                monitor.Open(ComPortListComboBox.Text);
            }
        }

        private void PopulateComPortsList()
        {
            var lookUp = new SerialPortLookUp();
            var serialPorts = lookUp.GetActiveSerialPortsNames();

            ComPortListComboBox.Items.Clear();
            ComPortListComboBox.Items.AddRange(serialPorts);

            if (ComPortListComboBox.Items.Count > 0)
            {
                ComPortListComboBox.SelectedItem = ComPortListComboBox.Items[0];
            }
            else
            {
                ComPortListComboBox.Text = string.Empty;
            }

            ComPortListComboBox.Refresh();
        }

        private void GetTempButton_Click(object sender, EventArgs e)
        {
            monitor.SendCommand("GetTemp");
        }


    }
}
