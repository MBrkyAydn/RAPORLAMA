using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DialogResult sor;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("bilgiler.txt") == true)
            {

                MessageBox.Show("Dosya Mevcut ");

            }
            else

            {
                sor = MessageBox.Show("Dosya Yaratılsınmı","Dosya Oluşturma",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (sor == DialogResult.Yes)
                {
                    StreamWriter dosya;

                    dosya = File.CreateText("bilgiler.txt");
                    

                
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter yaz;

            yaz = File.AppendText("bilgiler.txt");
            yaz.WriteLine(textBox1.Text );
            yaz.Close();
        }
    }
}
