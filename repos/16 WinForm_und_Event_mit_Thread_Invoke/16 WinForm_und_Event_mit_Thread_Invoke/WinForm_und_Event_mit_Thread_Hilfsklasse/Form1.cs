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

namespace WinForm_und_Event_mit_Thread_Invoke
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

        private delegate void SetTextBoxDelegate();
        private void addiere_Text(String text)
        {
            _text = text;
            SetTextBoxDelegate meineSetMethode = schreibe3;
            textBox3.Invoke(meineSetMethode);
        }
        private void schreibe3()
        {
            textBox3.Text += _text + "\r\n";
        }
 
        private void schreibe2()
        {
            textBox2.Text = _text;
        }
        private void schreibe_Text(String text)
        {
            _text = text;
            textBox2.Invoke((MethodInvoker)schreibe2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread eingabeThread = new Thread(() => _eingabe.schreibe_als_Thread(textBox1.Text));
            eingabeThread.Start();
        }

        private string _text;
        private Eingabe _eingabe;
   }
}
