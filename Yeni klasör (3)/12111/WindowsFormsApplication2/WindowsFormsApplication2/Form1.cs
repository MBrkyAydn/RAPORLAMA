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
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    struct   bilgiler 
       {
        public string adi;
        public string soyadi;
       }
    Int32 toplam;
        double ortalama=0;
        private void button1_Click(object sender, EventArgs e)

        {
            StreamWriter yaz;
            yaz = File.AppendText("bilgiler.txt");
            yaz.WriteLine(textBox1.Text );
            yaz.Close();


        }
        DialogResult sor;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("bilgiler.txt") == true)
            {
                MessageBox.Show("dosya mevcut");
            }
            else
            {
                sor = MessageBox.Show("Dosya oluşturulsunmu","",MessageBoxButtons.YesNo,MessageBoxIcon.Question );
                if (sor == DialogResult.Yes)
                {
                    StreamWriter dosya;
                    dosya = File.CreateText("bilgiler.txt");

                
                }
            
            }
        }
    }
}
