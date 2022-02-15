using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            int giris ,say;
            int sayi = 0;
            say=Convert.ToInt32(textBox2.Text);
            giris=Convert.ToInt32 (textBox1.Text);
            while (sayi< giris) 
            {
                listBox1.Items.Add("" + textBox2.Text );
                sayi++;
            }



        }
    }
}
