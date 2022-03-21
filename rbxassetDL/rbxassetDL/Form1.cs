using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace rbxassetDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            filepathbox.Text = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Downloaded";
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Downloaded");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = URLStextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                using (Process p = new Process())
                {
                    p.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath); ;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "cmd.exe";
                    p.StartInfo.Arguments = "/c node getasset.js " + lines[i];
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.Start();
                    StreamReader reader = p.StandardOutput;
                    string output;
                    while ((output = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(output);
                        richTextBox1.Text = richTextBox1.Text + output + "\n";
                        using (var client = new WebClient())
                        {
                            client.DownloadFile(output, System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Downloaded\" + lines[i]+".mp3");
                        }
                    }
                }
            }
            richTextBox1.Text = richTextBox1.Text + "\n";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
