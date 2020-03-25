using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Pi
{
    public partial class PiForm : Form
    {
        PiObject pi;

        public PiForm()
        {
            InitializeComponent();
            this.Text = "Digits of Pi";
            _digits.Maximum = decimal.MaxValue;
            _pi.ScrollBars = ScrollBars.Both;
            _pi.WordWrap = true;
            _digits.Text = "1";
        }

        private void _backgroundButton_Click(object sender, EventArgs e)
        {            
            if (this._backgroundButton.Text == "Cancel")
            {
                timer1.Stop();
                _backgroundButton.Text = "Calc";
                _digits.Enabled = true;
                backgroundWorker1.CancelAsync();
                return;
            }
            else

            {
                timer1.Start();
                

                pi = new PiObject
                {
                    calcValue = "",
                    digits = (int)_digits.Value,
                    
                };

                _digits.Enabled = false;
                
                _backgroundButton.Text = "Cancel";
                _pi.Text = string.Empty;
                

                backgroundWorker1.RunWorkerAsync(pi);

            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            PiObject piObj = e.Argument as PiObject;
            backgroundWorker1 = sender as BackgroundWorker;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.WorkerReportsProgress = true;

            StringBuilder pi = new StringBuilder("3", piObj.digits + 2);
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (piObj.digits > 0)
            {
                pi.Append(".");

                for (int i = 0; i < piObj.digits; i += 9)
                {
                    if (!this.backgroundWorker1.CancellationPending)
                    {
                        int nineDigits = NineDigitsofPi.StartingAt(i + 1);
                        int digitCount = Math.Min(piObj.digits - i, 9);
                        String ds = String.Format("{0:D9}", nineDigits);
                        pi.Append(ds.Substring(0, digitCount));
                        piObj.calcValue = pi.ToString();
                        
                    }
                    else
                    {
                        e.Cancel = true;
                    }

                }// the code that you want to measure comes here
                watch.Stop();
            }
            var elapsedMs = watch.ElapsedMilliseconds;

            piObj.elapsedMs = elapsedMs.ToString() + " ms";


        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            _pi.Text = (string)e.UserState;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this._backgroundButton.Text = "Calc";
            _digits.Enabled = true;
            
            if (e.Cancelled)
            {
                this._pi.Text = pi.calcValue + " <<cancelled>>";
            }

            
            
            


        }

        class PiObject
        {
            public String calcValue { get; set; }
            public int digits { get; set; }
            public String elapsedMs { get; set; }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _pi.Text = pi.calcValue;
            _performance.Text = pi.elapsedMs;
        }

        private void btnAPM_Click(object sender, EventArgs e)
        {
            // Joshua - working on APM button!
            _pi.Text = "pi results";
            _performance.Text = "0.1";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcPiAsync();
        }

        public async Task CalcPiAsync()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            Task<string> t = new Task<string>
            (
                () =>
                {
                    int digits = (int)this._digits.Value;
                    StringBuilder pi = new StringBuilder("3", digits + 2);
                    if (digits > 0)
                    {
                        pi.Append(".");
                        for (int i = 0; i < digits; i += 9)
                        {
                            int nineDigits = NineDigitsofPi.StartingAt(i + 1);
                            int digitCount = Math.Min(digits - i, 9);
                            string ds = string.Format("{0:D9}", nineDigits);
                            pi.Append(ds.Substring(0, digitCount));
                        }
                    }
                    return pi.ToString();
                }
            );

            t.Start();

            string result = await t;
            timer.Stop();
            _pi.Text = result;
            _performance.Text = timer.Elapsed.TotalSeconds.ToString();

        }

        public async Task CalcPiAsyncTPL()
        {
            Dictionary<int, string> piDictionary =
                new Dictionary<int, string>();

            int digits = (int)this._digits.Value;
            StringBuilder pi = new StringBuilder("3", digits + 2);

            Task<string> t = new Task<string>
            (
                () =>
                {

                    if (digits > 0)
                    {
                        pi.Append(".");
                        for (int i = 0; i < digits; i += 9)
                        {
                            int nineDigits = NineDigitsofPi.StartingAt(i + 1);
                            int digitCount = Math.Min(digits - i, 9);
                            string ds = string.Format("{0:D9}", nineDigits);
                            pi.Append(ds.Substring(0, digitCount));
                        }
                    }
                    return pi.ToString();

                }
            );

            t.Start();

            string result = await t;

            _pi.Text = result;

        }

    }

}
