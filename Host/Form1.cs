using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenHosts();
        }
        public void OpenHosts()
        {
            string caminho = @"C:\Windows\System32\drivers\etc\hosts";
            StreamWriter aqv = new StreamWriter(caminho, true);
            string URL = "\r\n127.0.0.1 http://" + textBox1.Text +
            " 127.0.0.1 http://www." + textBox1.Text;

            aqv.Write(URL);
            aqv.Close();
            MessageBox.Show(textBox1.Text + " blocked");
        }
    }
}
