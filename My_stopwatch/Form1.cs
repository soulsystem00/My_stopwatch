using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace My_stopwatch
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        Thread thread;

        void settxtbox()
        {
            while(true)
            {

                TimeSpan timeSpan = stopwatch.Elapsed;
                int sec, min, hour;
                sec = Convert.ToInt32(timeSpan.TotalSeconds) % 60;
                min = (Convert.ToInt32(timeSpan.TotalSeconds) / 60) % 60;
                hour = (Convert.ToInt32(timeSpan.TotalSeconds) / (60 * 60)) % 24 ;
                txt_sec.Text = sec.ToString();
                txt_min.Text = min.ToString();
                txt_hour.Text = hour.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
            txt_hour.Text = "0";
            txt_min.Text = "0";
            txt_sec.Text = "0";
            btn_end.Visible = false;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            thread = new Thread(settxtbox);
            thread.Start();
            btn_start.Visible = false;
            btn_end.Visible = true;
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            thread.Abort();
            btn_end.Visible = false;
            btn_start.Visible = true;
        }
    }
}
