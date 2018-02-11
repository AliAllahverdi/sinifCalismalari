using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delgateTapsiriqSinif
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


            

           
        }


        int a = 0;
        List<TextBox> txtBoxlist = new List<TextBox>();

        List<Label> lblaylist = new List<Label>();
       
        private void btnpls_Click_1(object sender, EventArgs e)
        {
            a++;

            TextBox txtBox = new TextBox();
            txtBox.Left = 10;
            txtBox.Top = a * 30;
            txtBox.Size = new Size(100, 150);
            txtBox.Click += new EventHandler(myTextBox);
            this.Controls.Add(txtBox);

            txtBoxlist.Add(txtBox);

          



            Label lblay = new Label();
            lblay.Left = txtBox.Width+txtBox.Left+10;
            lblay.Top = txtBox.Top;
            //lblay.Size = new Size(100, 150);          
            lblay.Text = a.ToString();
            lblaylist.Add(lblay);
            Controls.Add(lblay);


        }


        static void myTextBox(object sender, EventArgs e)
        {

        }

      
        private void mylblAy(object sender, EventArgs e)
        {
            
        }

        private void mezunbox_TextChanged(object sender, EventArgs e)
        {

        }
        delegate void myDelegate(double cem);
        public void btnHsp_Click(object sender, EventArgs e)
        {
           
            myDelegate mydel;
            mydel = new myDelegate(Mezun);
            mydel += Vergi;
            mydel += DSMF;
            mydel += NET;
            int cem = 0;
            foreach (var mydl in txtBoxlist)
            {
                cem += int.Parse(mydl.Text);
            }
            mydel(cem);
        }

        private int Maas(int sayi)
        {
            throw new NotImplementedException();
        }
       
        
        void Mezun(double cem)
        {
            

            mezunbox.Text = (cem / txtBoxlist.Count).ToString();
        }

        void Vergi (double cem)
        {
            vergibox.Text = (cem/100*14).ToString();
        }
       
        private void NET(double cem)
        {
            netbox.Text = (cem - double.Parse(vergibox.Text) - double.Parse(dsmfbox.Text)).ToString();
        }

        private void DSMF(double cem)
        {
            dsmfbox.Text = (cem / 100 * 3).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vergibox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
