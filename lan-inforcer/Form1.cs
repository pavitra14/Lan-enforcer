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
using System.Net;
using System.Net.NetworkInformation;

namespace lan_inforcer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int threads = Decimal.ToInt32(numericUpDown1.Value);
            int bytes = Decimal.ToInt32(numericUpDown2.Value);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "ping";
            startInfo.Arguments = textBox1.Text + " -t -l " + bytes;
            for (int i = 0; i < threads; i++)
            {
                Process.Start(startInfo);
            }
            MessageBox.Show("Started " + threads + " threads");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*IPv4InterfaceStatistics interfaceStats = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics();          
            // Globally declare these
            int bytesSentSpeed = 0;
            int bytesReceivedSpeed = 0;

            // Grab speed in KB /s
            bytesSentSpeed = (int)(interfaceStats.BytesSent - bytesSentSpeed);
            bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - bytesReceivedSpeed);

            var ordinals = new[] { "", "", "K", "M", "G", "T", "P", "E" };

            long bandwidth = bytesSentSpeed + bytesReceivedSpeed;

            decimal rate = (decimal)bandwidth;

            var ordinal = 0;

            while (rate > 1024)
            {
                rate /= 1024;
                ordinal++;
            }

            toolStripStatusLabel1.Text = String.Format("Bandwidth: {0} {1}b/s",
               Math.Round(rate, 2, MidpointRounding.AwayFromZero),
               ordinals[ordinal]);
            IPv4InterfaceStatistics interfaceStatistic = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics();
            int bytesSentSpeed = (int)(interfaceStatistic.BytesSent) / 1000000;
            int bytesReceivedSpeed = (int)(interfaceStatistic.BytesReceived) / 1000000;
           

            toolStripStatusLabel2.Text = bytesSentSpeed.ToString() + " kB/s";
            toolStripStatusLabel4.Text = bytesReceivedSpeed.ToString() + " kB/s";
            */
        }

        

        
        
    }
}
