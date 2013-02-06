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
        public ControllerForm()
        {
            InitializeComponent();
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


    }
}
