using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReferance
{
    class Program
    {

 

         static void calcArea (ref int r, ref double s)
        {
            s = Math.PI * r * r;
         
            
        }
         
        static void Main(string[] args)
        {



            double s = 0;
            int r = 15;
            calcArea(ref r, ref s);
            Console.WriteLine(s);


            //DordbucaqKaMal dordbucaq = new DordbucaqKaMal();
            //dordbucaq.hundurluk = 350;
            //Console.WriteLine(dordbucaq.Sahe());
            //Console.WriteLine(dordbucaq.Perimetr());
            ////DordbucaqKaMal b = dordbucaq.Copy();
            //DordbucaqKaMal b = dordbucaq;
            //b.hundurluk = 450;
            //Console.WriteLine(dordbucaq.hundurluk);
            //Console.WriteLine(b.hundurluk);
        }

       
    }


    //class DordbucaqKaMal
    //{
    //    public int hundurluk;
    //    public int en;

    //    public int Sahe()
    //    {
    //        int n = int.Parse(Console.ReadLine());
    //        int h = int.Parse(Console.ReadLine());
    //        return n * h;
    //    }

    //    public int Perimetr()
    //    {
    //        int n = int.Parse(Console.ReadLine());
    //        int h = int.Parse(Console.ReadLine());
    //        return (n + h) * 2;
    //    }

    //    public DordbucaqKaMal Copy()
    //    {
    //        DordbucaqKaMal x = new DordbucaqKaMal();
    //        x.en = en;
    //        x.hundurluk = hundurluk;
    //        return x;
            
    //    }
    //}



 
   
   


} 
