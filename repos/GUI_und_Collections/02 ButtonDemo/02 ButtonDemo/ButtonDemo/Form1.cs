using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonDemo
{
    public partial class ButtonDemo : Form
    {
        public ButtonDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Sender: " + sender.ToString() + "\r\n";
            textBox1.Text += "Button Click: " + e.ToString() + "\r\n";
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Sender: " + sender.ToString() + "\r\n";
            textBox1.Text += "Panel Click: " + e.Location.ToString() + "\r\n";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Sender: " + sender.ToString() + "\r\n";
            textBox1.Text += "Panel Click: " + e.Location.ToString() + "\r\n";
        }
    }
}
