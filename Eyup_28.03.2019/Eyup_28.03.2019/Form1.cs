using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eyup_28._03._2019
{
    public partial class Form1 : Form
    {
       
        int[] dizi = new int[12];
        string s = "";
      string yaz = "";
      Random rnd = new Random();
     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= 50; a++)
            {
               
                for (int i = 1; i <= 9; i++)
                {
                    dizi[i] = rnd.Next(1, 9);

                }
                dizi[10] = (dizi[1] + dizi[3] + dizi[5] + dizi[7] + dizi[9]) * 7 - (dizi[2] + dizi[4] + dizi[6] + dizi[8]);
                dizi[10] = dizi[10] % 10;
                dizi[11] = (dizi[1] + dizi[2] + dizi[3] + dizi[4] + dizi[5] + dizi[6] + dizi[7] + dizi[8] + dizi[9] + dizi[10]);
                dizi[11] = dizi[11] % 10;
                for (int i = 1; i <= 11; i++)
                {
                    
                    yaz = dizi[i].ToString();
                    s = s + yaz;


                }
                listBox1.Items.Add(s);
           
                s = "";
                yaz = "";

            }
        }
    }
}
