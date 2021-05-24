using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labor_02_StackRechner
{
    public partial class Form1 : Form
    {
        private Rechner _rechner;
        public Form1()
        {
            _rechner = new Rechner();
            _rechner.StackChanged += fillUI;
            InitializeComponent();
        }

        private void fillUI(object sender)
        {
            if (_rechner.stackLength() == 0)
            {
                textBoxStack1.Text = "";
                textBoxStack2.Text = "";
                textBoxStack3.Text = "";
                textBoxStack4.Text = "";
            }
            if (_rechner.stackLength() == 1)
            {
                textBoxStack1.Text = _rechner._operanden.ElementAt(0).ToString();
                textBoxStack2.Text = "";
                textBoxStack3.Text = "";
                textBoxStack4.Text = "";

            }else if (_rechner.stackLength() == 2)
            {
                textBoxStack1.Text = _rechner._operanden.ElementAt(0).ToString();
                textBoxStack2.Text = _rechner._operanden.ElementAt(1).ToString();
                textBoxStack3.Text = "";
                textBoxStack4.Text = "";

            }else if (_rechner.stackLength() == 3)
            {
                textBoxStack1.Text = _rechner._operanden.ElementAt(0).ToString();
                textBoxStack2.Text = _rechner._operanden.ElementAt(1).ToString();
                textBoxStack3.Text = _rechner._operanden.ElementAt(2).ToString();
                textBoxStack4.Text = "";

            }else if (_rechner.stackLength() >= 4)
            {
                textBoxStack1.Text = _rechner._operanden.ElementAt(0).ToString();
                textBoxStack2.Text = _rechner._operanden.ElementAt(1).ToString();
                textBoxStack3.Text = _rechner._operanden.ElementAt(2).ToString();
                textBoxStack4.Text = _rechner._operanden.ElementAt(3).ToString();
            }
        }

        private void buttonTeilen_Click(object sender, EventArgs e)
        {
            _rechner.Geteilt();
            eingabeZahl.Focus();
        }

        private void buttonMultiplizieren_Click(object sender, EventArgs e)
        {
            _rechner.Mal();
            eingabeZahl.Focus();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _rechner.Minus();
            eingabeZahl.Focus();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _rechner.Plus();
            eingabeZahl.Focus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _rechner.Clear();
            eingabeZahl.Focus();
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            _rechner.Swap();
            eingabeZahl.Focus();
        }

        private void buttonDrop_Click(object sender, EventArgs e)
        {
            _rechner.Drop();
            eingabeZahl.Focus();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            byte zahl = byte.Parse(eingabeZahl.Text);
            _rechner.AddElement(zahl);
            eingabeZahl.Text = "";
            eingabeZahl.Focus();
        }

        private void textBoxStack4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxStack3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxStack1_TextChanged(object sender, EventArgs e)
        {
        }

        private void eingabeZahl_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


    }
}