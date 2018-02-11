using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace film_rezerv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Button[] btns = new Button[23];
        int a;
        private Button[] btn;

        public object True { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
        
            var btn = (Button)sender;
            btn.BackColor = Color.Yellow;
            btn.Enabled = false;
            btns[a] = btn;
            a++;

           

         if (int.Parse(btn.Text) >= 1 && int.Parse(btn.Text) <= 7)
         {
                label2.Text = int.Parse(label2.Text) + 14 + "";

         }

            if (int.Parse(btn.Text) >= 8 && int.Parse(btn.Text) <= 13)
            {
                label2.Text = int.Parse(label2.Text) + 12 + "";

            }

            if (int.Parse(btn.Text) >= 14 && int.Parse(btn.Text) <= 18)
            {
                label2.Text = int.Parse(label2.Text) + 10 + "";

            }

            if (int.Parse(btn.Text) >= 19 && int.Parse(btn.Text) <= 22)
            {
                label2.Text = int.Parse(label2.Text) + 8 + "";

            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rezerv_Click(object sender, EventArgs e)
        {
            for (int a=0; a< btns.Length; a++)
            {
                if (btns[a]!= null)
                {
                    btns[a].BackColor = Color.Green;
                    btns[a].Enabled = false;
             
                }
            }


            MessageBox.Show("Rezerv edildi");
            this.Close();
            Application.Exit();
        }

        private void priceone_Click(object sender, EventArgs e)
        {
            //var buton = 0;
            //if(buton == )
            //{

            //    buton += 6;
            //}
        }

        private void pricetwo_Click(object sender, EventArgs e)
        {
           
                label2.Text = int.Parse(label2.Text) - (3 * a) + "";


            pricetwo.Enabled = false;

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
