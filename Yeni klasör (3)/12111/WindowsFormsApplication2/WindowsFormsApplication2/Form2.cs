using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string adi, soyadi, ders;
        Int32 toplam, kactane;
        double ortalama = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            adi = Interaction.InputBox("adı gir","asdsf","asdfsdf");
            soyadi = Interaction.InputBox("soyad","adf","sdsafs");
            ders = Interaction.InputBox("asdfasdf","sdfsdaf","asdfsdf");
            kactane = int.Parse(Interaction.InputBox("jaç adert","sdfsdf"));

            for (int i =1; i<=kactane; i++)
            {

                toplam += int.Parse(Interaction.InputBox(i + " . sayı nedşr", "asdsfg0"));
            
            }
            ortalama = toplam / kactane;
            listBox1.Items.Add(ortalama.ToString());
        
        }
    }
}
