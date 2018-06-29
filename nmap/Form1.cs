using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace nmap
{
    public partial class Form1 : Form
    {
        int mode = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.result.Invoke((MethodInvoker)delegate
            {
                if (e.Data == null)
                {
                    cer_bt.Enabled = true;
                    ssl_bt.Enabled = true;
                    state.Text = "已結束";
                    state.BackColor = Color.LightGreen;
                }
                else
                {
                    //result.AppendText(e.Data + "\r\n");
                    //Cer
                    if(mode == 1)
                    {
                        if (e.Data.StartsWith("| Issuer:")) { result.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("| Public Key type:")) { result.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("| Public Key bits:")) { result.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("| Signature Algorithm:")) { result.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("| Not valid before:")) { result.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("| Not valid after:")) { result.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("|_SHA-1:")) { result.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("|_ssl-date:")) { result.AppendText(e.Data + "\r\n"); }
                    }
                    

                    //SSL
                    if(mode == 2)
                    {
                        if (e.Data.StartsWith("| ")) { result.AppendText(e.Data + "\r\n"); }
                        if (e.Data.StartsWith("|_")) { result.AppendText(e.Data + "\r\n"); }
                    }
                    

                    //common
                    if (e.Data.StartsWith("Nmap done:")) { result.AppendText(e.Data + "\r\n"); }
                }

                
                
            });
        }


        private void BtCer_Click(object sender, EventArgs e)
        {
            result.Focus();
            mode = 1;
            if (check())
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                state.Text = "掃描中";
                state.BackColor = Color.Coral;
                cer_bt.Enabled = false;
                ssl_bt.Enabled = false;
                result.Text = "";
                string str = Console.ReadLine();
                
                process.StartInfo.FileName = "nmap.bat";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                string str1 = "-sC";
                string str2 = "-p";
                string str3 = "-v";

                if (port_box.Text == null || port_box.Text == "")
                    port_box.Text = "443";

                process.StartInfo.Arguments = string.Format(str3 + " " + str1 + " " + ip_box.Text + " " + str2 + " " + port_box.Text);
                process.Start();
                process.OutputDataReceived += proc_OutputDataReceived;
                process.BeginOutputReadLine();
                process.StandardInput.AutoFlush = true;
                process.Close();
                
            }
        }

        


        private void BtSSL_Click(object sender, EventArgs e)
        {
            result.Focus();
            mode = 2;
            if (check())
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                state.Text = "掃描中";
                state.BackColor = Color.Coral;
                cer_bt.Enabled = false;
                ssl_bt.Enabled = false;
                result.Text = "";
                string str = Console.ReadLine();
                
                process.StartInfo.FileName = "nmap.bat";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                string str1 = "--script";  //--script ssl-enum-ciphers
                string str2 = "-p";
                string str3 = "ssl-enum-ciphers";

                if (port_box.Text == null || port_box.Text == "")
                    port_box.Text = "443";

                process.StartInfo.Arguments = string.Format(str1 + " " + str3 + " " + ip_box.Text + " " + str2 + " " + port_box.Text);
                process.Start();
                process.OutputDataReceived += proc_OutputDataReceived;
                process.BeginOutputReadLine();
                process.StandardInput.AutoFlush = true;
                process.Close();
            }
            
        }

        private bool check()
        {
            
            Regex ipRgx = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$");
            Regex portRgx = new Regex(@"^\d{1,5}$");
            Regex domainRex = new Regex(@"^(([\w][\w\-\.]*)\.)?([\w][\w\-]+)(\.([\w][\w\.]*))?$");
            if (!(portRgx.IsMatch(port_box.Text, 0)|port_box.Text==""))
            {
                result.Text = "port is not courrect";
                return false;
            }
            if (ipRgx.IsMatch(ip_box.Text, 0)|domainRex.IsMatch(ip_box.Text,0))
            {
                return true;
            }
            else
            {
                result.Text = "ip is not courrect";
                return false;
            }

        }
        private void LbIP_Click(object sender, EventArgs e)
        {}
        private void result_TextChanged(object sender, EventArgs e)
        {}
        private void Form1_Load(object sender, EventArgs e)
        {}
        private void port_box_TextChanged(object sender, EventArgs e)
        {}
        private void port_txt_Click(object sender, EventArgs e)
        {}

        private void state_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
