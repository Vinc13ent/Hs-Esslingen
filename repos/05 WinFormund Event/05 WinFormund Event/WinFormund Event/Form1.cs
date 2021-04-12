using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormund_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _eingabe = new Eingabe();
            _eingabe.schreibe_event += schreibe_Text;
            _eingabe.schreibe_event += addiere_Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _eingabe.EingabeText = textBox1.Text;
            //textBox3.Text += Environment.NewLine + sender.ToString();
            //textBox3.Text += Environment.NewLine + e.ToString();
        }

        private void schreibe_Text(String text)
        {
            textBox2.Text = text;
        }

        private void addiere_Text(String text)
        {
            textBox3.Text += text +Environment.NewLine;
        }

        private Eingabe _eingabe;
    }
}
