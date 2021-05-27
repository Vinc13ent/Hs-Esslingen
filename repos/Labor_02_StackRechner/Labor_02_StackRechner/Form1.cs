using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labor_02_StackRechner
{
    interface IZahlenDecorator
    {
        bool AlsByte(string s, out byte a);
        string AlsString(byte b);
    }

    public class HexDecorator : IZahlenDecorator
    {
        public bool AlsByte(string s, out byte a)
        {
            try
            {
                int dezimal = Convert.ToInt32(s, 16);
                a = Convert.ToByte(dezimal);
                return true;
            }
            catch ( Exception )
            {
                a = 0;
                return false;
            }
        }

        public string AlsString(byte b)
        {
            string s = Convert.ToString(b, 16);
            return s;        
        }
    }

    public class BinDecorator : IZahlenDecorator
    {
        public bool AlsByte(string s, out byte a)
        {
            try
            {
                int dezimal = Convert.ToInt32(s, 2);
                a = Convert.ToByte(dezimal);
                return true;
            }
            catch ( Exception )
            {
                a = 0;
                return false;
            }
        }

        public string AlsString(byte b)
        {
            string s = Convert.ToString(b, 2);
            return s;        
        }
    }
    
    public class DezimalDecorator  : IZahlenDecorator
    {
        public bool AlsByte(string s, out byte a)
        { 
            try
            {
                int dezimal = Convert.ToInt32(s, 10);
                a = Convert.ToByte(dezimal);
                return true;
            }
            catch ( Exception )
            {
                a = 0;
                return false;
            }
        }

        public string AlsString(byte b)
        {
            string s = Convert.ToString(b, 10);
            return s;
        }
    }
    
    public partial class Form1 : Form 
    {
        private Rechner _rechner;
        private IZahlenDecorator _zahlenWandler;
        public Form1()
        {
            _rechner = new Rechner();
            _rechner.StackChanged += fillUI;
            _zahlenWandler = new DezimalDecorator();
            InitializeComponent();
        }

        private void fillUI(object sender)
        {
            if ( _rechner.stackLength() == 0)
            {
                textBoxStack1.Text = "";
                textBoxStack2.Text = "";
                textBoxStack3.Text = "";
                textBoxStack4.Text = "";
            }
            else if (_rechner.stackLength() == 1)
            {
                textBoxStack1.Text = _zahlenWandler.AlsString(_rechner._operanden.ElementAt(0));
                textBoxStack2.Text = "";
                textBoxStack3.Text = "";
                textBoxStack4.Text = "";
            }
            else if ( _rechner.stackLength() == 2)
            {
                textBoxStack1.Text = _zahlenWandler.AlsString(_rechner._operanden.ElementAt(0));
                textBoxStack2.Text = _zahlenWandler.AlsString(_rechner._operanden.ElementAt(1));
                textBoxStack3.Text = "";
                textBoxStack4.Text = "";
            }
            else if ( _rechner.stackLength() == 3 )
            {
                textBoxStack1.Text = _zahlenWandler.AlsString(_rechner._operanden.ElementAt(0));
                textBoxStack2.Text = _zahlenWandler.AlsString(_rechner._operanden.ElementAt(1));
                textBoxStack3.Text = _zahlenWandler.AlsString(_rechner._operanden.ElementAt(2));
                textBoxStack4.Text = "";
            }
            else
            {
                textBoxStack1.Text = _zahlenWandler.AlsString(_rechner._operanden.ElementAt(0));
                textBoxStack2.Text = _zahlenWandler.AlsString(_rechner._operanden.ElementAt(1));
                textBoxStack3.Text = _zahlenWandler.AlsString(_rechner._operanden.ElementAt(2));
                textBoxStack4.Text = _zahlenWandler.AlsString(_rechner._operanden.ElementAt(3));
            }

        }

        private void buttonTeilen_Click(object sender, EventArgs e)
        {
            buttonEnter_Click(sender, EventArgs.Empty);
            _rechner.Geteilt();
            eingabeZahl.Focus();
        }

        private void buttonMultiplizieren_Click(object sender, EventArgs e)
        {
            buttonEnter_Click(sender, EventArgs.Empty);
            _rechner.Mal();
            eingabeZahl.Focus();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            buttonEnter_Click(sender, EventArgs.Empty);
            _rechner.Minus();
            eingabeZahl.Focus();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            buttonEnter_Click(sender, EventArgs.Empty);
            _rechner.Plus();
            eingabeZahl.Focus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            buttonEnter_Click(sender, EventArgs.Empty);
            _rechner.Clear();
            eingabeZahl.Focus();
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            buttonEnter_Click(sender, EventArgs.Empty);
            _rechner.Swap();
            eingabeZahl.Focus();
        }

        private void buttonDrop_Click(object sender, EventArgs e)
        {
            buttonEnter_Click(sender, EventArgs.Empty);
            _rechner.Drop();
            eingabeZahl.Focus();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (_zahlenWandler.AlsByte(eingabeZahl.Text, out byte a))
            {
                _rechner.AddElement(a);
                eingabeZahl.Text = "";
                eingabeZahl.Focus();
            }
            else if ( _rechner._operanden.Count != 0 && _rechner.stackLength() != 0)
            {
                eingabeZahl.Focus();
            }
            else
            {
                MessageBox.Show("Eingabe war fehlerhaft enter");
            }
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


        private void radioDezimal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDezimal.Checked)
            {
                if (eingabeZahl.Text != "" || _rechner.stackLength() != 0)
                {
                    _zahlenWandler = new DezimalDecorator();
                    _rechner.OnStackChanged();
                    eingabeZahl.Focus();
                }
                else
                {
                    _zahlenWandler = new DezimalDecorator();
                    eingabeZahl.Focus();
                }
            }
        }

        private void radioDual_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDual.Checked)
            {
                if (eingabeZahl.Text != "" || _rechner.stackLength() != 0)
                {
                    _zahlenWandler = new BinDecorator();
                    _rechner.OnStackChanged();
                    eingabeZahl.Focus();
                }
                else
                {
                    _zahlenWandler = new BinDecorator();
                    eingabeZahl.Focus();
                }
            }
        }

        private void radioHex_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHex.Checked)
            {
                if (eingabeZahl.Text != "" || _rechner.stackLength() != 0)
                {
                    _zahlenWandler = new HexDecorator();
                    _rechner.OnStackChanged();
                    eingabeZahl.Focus();
                }
                else
                {
                    _zahlenWandler = new HexDecorator();
                    eingabeZahl.Focus();
                }
            }
        }
    }
}