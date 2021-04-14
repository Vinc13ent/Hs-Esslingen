using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Labor_01_Teil1_Serielle_kommunikation
{
    public partial class DemoDeviceTester : Form 
    {

        private DemoDevice _device;
        
        public DemoDeviceTester()
        {
            _device = new DemoDevice();
            _device.PropertyChanged += OnDevicePropertyChanged;
            InitializeComponent();
        }
        

        private void DemoDeviceTester_Load(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            _device.Increment();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            _device.Decrement();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _device.Reset();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(comUpDown.Value);
            _device.Connect(port);
            ConectionStateLabel.Text = _device.ConnectionState.ToString();
            DeviceLabel.Text = "Name: " + _device.DeviceName.ToString();
            SerialNumberLabel.Text = "S/N: " + _device.SerialNumber.ToString();
        }

        private void comUpDown_ValueChanged(object sender, EventArgs e)
        {
        }

        public void OnDevicePropertyChanged(object sender, string propertyName)
        {
            Console.WriteLine(propertyName);
            CounterTextBox.Text = propertyName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }
        
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
        }
        
        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
        }

        
    }
}
