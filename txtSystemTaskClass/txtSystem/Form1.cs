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

namespace txtSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();





            string fileoxu = "test.txt";
            //if (!File.Exists(fileoxu))
            //{
            //    var myFile = File.Create(fileoxu);
            //    myFile.Close();
            //}
            StreamReader sr = new StreamReader(fileoxu);
            List<string> suallar = new List<string>();
            Dictionary<int, List<string>> cavablar = new Dictionary<int, List<string>>();

            while (!sr.EndOfStream)
            {
                var thisLine = sr.ReadLine();
                if (thisLine.Trim() != "")
                {
                    if (thisLine.Contains("Sual"))
                    {
                        suallar.Add(thisLine);
                        cavablar[suallar.Count - 1] = new List<string>();
                    }
                    else
                    {
                        cavablar[suallar.Count - 1].Add(thisLine);
                    }
                }
            }
            sr.Close();
            int posit = 0;
            int a = 0;
           // var suallar = oxuContent.Where(w => w.Contains("Sual"));
            foreach (var sual in suallar)
            {
                Label lbl = new Label();
                lbl.Text = sual;
                lbl.Location = new Point(10,posit);
                lbl.Width = 300;
                this.Controls.Add(lbl);
                posit += 20;

                GroupBox grpBox = new GroupBox();
                grpBox.Height = 150;
                grpBox.Width = 300;
                grpBox.Location = new Point(10, posit);
                
                this.Controls.Add(grpBox);

                int pos = 10;
                foreach (var cavab in cavablar[a])
                {
                    RadioButton rdBtn = new RadioButton();
                    rdBtn.Location = new Point(10, pos);
                    rdBtn.Width = 300;
                    rdBtn.Text = cavab;
                    grpBox.Controls.Add(rdBtn);
                    posit += 50;
                    pos += 50;
                }
                a++;

            }

            

        }
       

      
    }
}
