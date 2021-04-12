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
using System.Diagnostics;

namespace Threads_kooperierend_Pi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_1Thread_Click(object sender, EventArgs e)
        {
            Stopwatch s = new Stopwatch();
            Rechnen rechnen1;
            s.Start();
            rechnen1 = new Rechnen(1, dasn, dasn);
            Thread einThread = new Thread(rechnen1.rechne);
            einThread.Start();
            einThread.Join();
            s.Stop();
            l_erg1.Text = "Summe: " + rechnen1.getSumme();
            l_zeit1.Text = "Zeit: " + (s.ElapsedMilliseconds / 1000.0);
        }

        private void b_4Threads_Click(object sender, EventArgs e)
        {
            Stopwatch s = new Stopwatch();
            int dieAnzahl = 4;
            b_4Threads.Text = dieAnzahl + " Threads";
            long derTeil = dasn / dieAnzahl;
            Rechnen[] dasRechnen = new Rechnen[dieAnzahl];
            Thread[] dieThreads = new Thread[dieAnzahl];
            s.Start();
            for (int i = 0; i < dieAnzahl; i++)
            {
                dasRechnen[i] = new Rechnen(i * derTeil + 1, (i + 1) * derTeil, dasn);
                dieThreads[i] = new Thread(dasRechnen[i].rechne);
            }
            for (int i = 0; i < dieAnzahl; i++)
            {
                dieThreads[i].Start();
            }
            for (int i = 0; i < dieAnzahl; i++)
            {
                dieThreads[i].Join();
            }
            s.Stop();
            double sum = 0.0;
            for (int i = 0; i < dieAnzahl; i++)
            {
                sum += dasRechnen[i].getSumme();
            }
            l_erg4.Text = "Summe: " + sum;
            l_zeit4.Text = "Zeit: " + (s.ElapsedMilliseconds / 1000.0);
        }

        private void b_8Threads_Click(object sender, EventArgs e)
        {
            Stopwatch s = new Stopwatch();
            int dieAnzahl = 8;
            b_8Threads.Text = dieAnzahl + " Threads";
            long derTeil = dasn / dieAnzahl;
            Rechnen[] dasRechnen = new Rechnen[dieAnzahl];
            Thread[] dieThreads = new Thread[dieAnzahl];
            s.Start();
            for (int i = 0; i < dieAnzahl; i++)
            {
                dasRechnen[i] = new Rechnen(i * derTeil + 1, (i + 1) * derTeil, dasn);
                dieThreads[i] = new Thread(dasRechnen[i].rechne);
            }
            for (int i = 0; i < dieAnzahl; i++)
            {
                dieThreads[i].Start();
            }
            for (int i = 0; i < dieAnzahl; i++)
            {
                dieThreads[i].Join();
            }
            s.Stop();
            double sum = 0.0;
            for (int i = 0; i < dieAnzahl; i++)
            {
                sum += dasRechnen[i].getSumme();
            }
            l_erg8.Text = "Summe: " + sum;
            l_zeit8.Text = "Zeit: " + (s.ElapsedMilliseconds / 1000.0);
        }
        private long dasn = 100000000;
    }
}
