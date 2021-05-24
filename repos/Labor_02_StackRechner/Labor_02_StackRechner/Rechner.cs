using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Labor_02_StackRechner
{
    public class Rechner
    {
        public Stack<byte> _operanden = new Stack<byte>();
        
        public delegate void StackChangedDelegate(Rechner src);
        public event StackChangedDelegate StackChanged;
        private void OnStackChanged()
        {
            if (StackChanged != null)
            {
                StackChanged(this);
            }
        }


        public void Plus()
        {
            try
            {
                var zahl1 = _operanden.Pop();
                var zahl2 = _operanden.Pop();
                var res = zahl1 + zahl2;
                _operanden.Push(Convert.ToByte(res));
                OnStackChanged();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            
        }

        public void Minus()
        {
            try
            {
                var zahl1 = _operanden.Pop();
                var zahl2 = _operanden.Pop();
                var res = zahl1 - zahl2;
                _operanden.Push(Convert.ToByte(res));
                OnStackChanged();
            }
            catch (Exception)
            {
                MessageBox.Show("Resultate/Werte können nicht negativ sein");
            }
            
        }

        public void Mal()
        {
            var zahl1 = _operanden.Pop();
            var zahl2 = _operanden.Pop();
            var res = zahl1 * zahl2;
            _operanden.Push(Convert.ToByte(res));
            OnStackChanged();
        }

        public void Geteilt()
        {
            var zahl1 = _operanden.Pop();
            var zahl2 = _operanden.Pop();
            var res = zahl2 / zahl1;
            _operanden.Push(Convert.ToByte(res));
            OnStackChanged();
        }

        public void AddElement(byte element)
        {
            try
            {
                _operanden.Push(element);
                OnStackChanged();
            }
            catch (Exception e)
            {
                Console.WriteLine("Falsche eingabe");
            }
            
        }

        public void Clear()
        {
            _operanden.Clear();
            OnStackChanged();
        }

        public void Swap()
        {
            if (stackLength() >= 2)
            {
                var zahl1 = _operanden.Pop();
                            var zahl2 = _operanden.Pop();
                            _operanden.Push(zahl1);
                            _operanden.Push(zahl2);
                            OnStackChanged();
            }
            else if (stackLength() == 1)
            {
                MessageBox.Show("Nichts womit ich swapen kann");
            }
            else
            {
                MessageBox.Show("Nichts zu swapen");
            }
            
        }

        public void Drop()
        {
            if (stackLength() > 0)
            {
                _operanden.Pop();
                OnStackChanged();
            }
            else
            {
                MessageBox.Show("Nichts zu dropen");
            }
        }

        public int stackLength()
        {
            return _operanden.Count;
            
        }
    }
}