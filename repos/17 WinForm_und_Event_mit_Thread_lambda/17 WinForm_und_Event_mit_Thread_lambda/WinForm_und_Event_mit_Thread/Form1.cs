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

namespace WinForm_und_Event_mit_Thread_lambda
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
            Thread eingabeThread = new Thread(() => _eingabe.schreibe_als_Thread(textBox1.Text));
            eingabeThread.Start();
        }

        private void schreibe_Text(String text)
        {
            textBox2.Invoke((MethodInvoker)(() => textBox2.Text = text));
        }

        private void addiere_Text(String text)
        {
            textBox3.Invoke((MethodInvoker)(() => textBox3.Text += text + "\r\n"));
            //MethodInvoker ist ein vordefinierte Delegat mit Den Rückgabewert void und leerer Parameterliste)
            //lambda Funktionen können auf Umgebungsvariable zugreifen und benötigen deshalb keine Parameter
        }

        private Eingabe _eingabe;

    }
}
