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
        string caminho = @"C:\Windows\System32\drivers\etc\hosts";
        #region buttons 
        private void button1_Click(object sender, EventArgs e)
        {
            OpenHosts();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Include();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            unlocked();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            save();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            locked();
        }
        #endregion
        #region Funções
        public void OpenHosts()
        {
            textBox2.Text = "";
            {

                try
                {
                    StreamReader sr = new StreamReader(caminho, true);
                    {
                        string linha;
                       
                        while ((linha = sr.ReadLine()) != null)
                        {
                            textBox2.AppendText(linha);
                            textBox2.AppendText("\n");
                        }
                        sr.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Não é possivel ler o arquivo");
                    MessageBox.Show(e.Message);
                }

            }
        }        
        public void unlocked()
        {
            textBox2.Enabled = true;
        }
        public void locked()
        {
            textBox2.Enabled = false;
        }
        public void Include()
        {          
                if(textBox1.Text == null)
                {
                    messageBox.Show("Nenhum link foi inserido no campo.");
                )
                else
                (
                    string URL = "\r\n127.0.0.1 " + textBox1.Text;
                    textBox2.AppendText(URL);             
                    MessageBox.Show(textBox1.Text + " blocked");
                )       
        }
        public void save()
        {
           // FileStream fs = new FileStream(caminho, FileMode.Create);
           try
                {
                
                StreamWriter sw = new StreamWriter(caminho);
                    {
                    sw.Write("");
                    sw.Write(textBox2.Text);
                    sw.Flush();
                    sw.Close();
                    //fs.Close();
                    }
                }
            catch (Exception e)
                {
                    MessageBox.Show("Erro ao gravar arquivo em modo usuario normal");
                    MessageBox.Show(e.Message);
                }
        }
        #endregion        
    }
}
