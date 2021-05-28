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
using System.Media;

namespace Barbie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var ProgressReport = new ProgressReport();
            return Task.Run(() => {
                for (int i = 0; i < totalProcess; i++)
                {
                    ProgressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(ProgressReport);
                    Thread.Sleep(10);

                }
            });
        }
        private async void btnStart_Click(object sender, EventArgs e)
        {try
           {
            List<string> list = new List<string>();
            for(int i=0; i < 1000; i++)
            {
                list.Add(i.ToString());
            }
            lblStatus.Text = "Working...";
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                lblStatus.Text = string.Format("Processing...{0}%", report.PercentComplete);
                progressBar.Value = report.PercentComplete;
                progressBar.Update();
            };
            await ProcessData(list, progress);
            lblStatus.Text = "Done!......";
            Form obj1 = new Igrica();
            obj1.Show();
            } catch(Exception e)
              {MessageBox.Show("Klikni start");}

        }
        private void PromenaLokacije(object sender, EventArgs e)
        {
            this.Location = new Point(250, 263);//fiksna lokacija
            this.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            player.SoundLocation = @"C:\Users\Pc\source\repos\Barbie\Barbie\bin\Debug\muzikabarbi.wav";
            Width = 916;
            Height = 633;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
