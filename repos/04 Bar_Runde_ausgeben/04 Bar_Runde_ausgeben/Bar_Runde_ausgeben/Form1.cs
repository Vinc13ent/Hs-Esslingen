using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Runde_ausgeben
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            Person anton = new Person(this) { Name = "Anton" };
            Person berta = new Person(this) { Name = "Berta" };
            Person eve = new Person(this) { Name = "Eve" };
            anton.Eintreten(bar);
            berta.Eintreten(bar);
            eve.Eintreten(bar);
            InitializeComponent();
        }

        private void B_anton_Click(object sender, EventArgs e)
        {
            bar.Rundevon("Anton");
        } 

        private void B_berta_Click(object sender, EventArgs e)
        {
            bar.Rundevon("Berta");
        }

        private void B_eve_Click(object sender, EventArgs e)
        {
            bar.Rundevon("Eve");
        }

        public void ausgebenText(string t)
        {
            textBox1.Text += t + Environment.NewLine;
        }

        Bar bar = new Bar();
    }
}
