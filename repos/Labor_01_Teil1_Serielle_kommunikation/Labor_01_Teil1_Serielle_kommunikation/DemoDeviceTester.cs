using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labor_01_Teil1_Serielle_kommunikation
{
    public partial class DemoDeviceTester : Form
    {

        public DemoDeviceTester()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripStatusLabel StatusLableConection = new System.Windows.Forms.ToolStripStatusLabel();
            ToolStripStatusLabel StatusLableDevice = new System.Windows.Forms.ToolStripStatusLabel();
            ToolStripStatusLabel StatusLableNR = new System.Windows.Forms.ToolStripStatusLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DemoDeviceTester_Load(object sender, EventArgs e)
        {

        }
    }
}
