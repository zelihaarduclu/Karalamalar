using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarişması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dogrusayısı=0,yanlişsayisi=0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                dogrusayısı = dogrusayısı + 1;
                label2.Text = dogrusayısı.ToString();

            }
            else
            {
                yanlişsayisi = yanlişsayisi + 1;
                label3.Text = yanlişsayisi.ToString();
            }
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(radioButton2.Checked==true)
            {
                dogrusayısı = dogrusayısı + 1;
                label2.Text = dogrusayısı.ToString();
            }
           else
            {
                yanlişsayisi = yanlişsayisi + 1;
                label3.Text = yanlişsayisi.ToString();
                
            }
          button1.Enabled=false;
        }
    }
}
