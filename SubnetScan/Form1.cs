using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace SubnetScan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls=false;
        }
        Thread myThread = null;
        public void scan(string subnet)
        {
            Ping myPing;
            PingReply reply;
            IPAddress addr;
            IPHostEntry host;
            for (int i = 1; i < 255; i++)
            {
                string subnetn = "." + i.ToString();
                myPing = new Ping();
                reply = myPing.Send(subnet + subnetn);
                if (reply.Status == IPStatus.Success)
                {
                    try
                    {
                        addr = IPAddress.Parse(subnet + subnetn);
                        host = Dns.GetHostEntry(addr);
                        textHosts.AppendText(subnet + subnetn + "\t" + "Up" + "\t"+ host.HostName.ToString() + Environment.NewLine );
                    }
                    catch
                    {

                    }
                }
            }
        }
        private void cmdScan_Click(object sender, EventArgs e)
        {
            myThread = new Thread(() => scan(textIP.Text));
            myThread.Start();
            if (myThread.IsAlive)
            {
                cmdStop.Enabled=true;
                cmdScan.Enabled=false;
                textIP.Enabled = false;
            }
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            myThread.Suspend();
            cmdStop.Enabled = false;
            cmdScan.Enabled = true;
            textIP.Enabled = true;
        }
    }
}
