using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskThreat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            int cem = 0;
            Stopwatch timer = new Stopwatch();

            StreamReader sr = new StreamReader("C:/Users/P502/Desktop/ali/myText.txt");
            StreamReader sr2 = new StreamReader("C:/Users/P502/Desktop/ali/myText.txt");

            Task task1 = new Task(() =>
            {
                
                timer.Start();
                var myTxt = sr.ReadToEnd();
                cem += myTxt.Length;
                //{
                //    ToolBarTextAlign = m100mb;
                //    ReadOnlyAttribute = 15mb'
                //    read / ToolBarTextAlign * 100'

                //}
                sr.Close();
               // MessageBox.Show(myTxt.Length.ToString() + " time is " + timer.ElapsedMilliseconds.ToString());
            });

            Task task2 = new Task(() =>
            {
                timer.Start();
                var myTxt2 = sr2.ReadToEnd();
                cem += myTxt2.Length;
                //{
                //    ToolBarTextAlign = m100mb;
                //    ReadOnlyAttribute = 15mb'          //totali oyrenecem
                //    read / ToolBarTextAlign * 100'

                //}
                sr2.Close();
                //MessageBox.Show(myTxt2.Length.ToString() + " time is " + timer.ElapsedMilliseconds.ToString());
            });

            task1.Start();
            task2.Start();
            Task.WaitAll(task1, task2);

            MessageBox.Show(cem.ToString() + " time is " + timer.ElapsedMilliseconds.ToString());

//-------------------------------------------------------

            //Stopwatch timer = new Stopwatch();
            //StreamReader sr = new StreamReader("C:/Users/P502/Desktop/ali/myText.txt");
            //timer.Start();
            //var myTxt = sr.ReadToEnd();
            //sr.Close();
            //MessageBox.Show(myTxt.Length.ToString() + " time is " + timer.ElapsedMilliseconds.ToString());
//----------------------------------------------
            // task1.Start();

            //Parallel.For(0, 1000000000, u =>
            //{
            //    progressBar1.Value = u / 10000000;
            //});
            ////for (int u = 0; u <= 1000000000; u++)
            ////{
            ////    progressBar1.Value = u / 10000000;
            ////}
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Task task1 = Task.Factory.StartNew(() =>
            //{
            //    for (int u = 0; u <= 1000000000; u++)
            //    {
            //        progressBar1.Value = u / 10000000;
            //    }

            //});
            //Task task2 = Task.Factory.StartNew(() =>
            //{
            //    for (int u = 0; u <= 1000000000; u++)
            //    {
            //        progressBar2.Value = u / 10000000;
            //    }
            //});
        }

        private  void Button2_Click(object sender, EventArgs e)
        {

           
            //Parallel.For(0, 1000000000, u =>
            //{
            //    progressBar2.Value = u / 10000000;
            //});

            //for (int u = 0; u <= 1000000000; u++)
            //{
            //    progressBar2.Value = u / 10000000;
            //}
        }
    }
}
