using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassAndEnc
{
    class Program
    {
        static void Main(string[] args)
        {
            //CodeAcademy kursum = new CodeAcademy();

            ////kursum.cours = "Code Academy";
            ////kursum.groups = "P502";
            ////kursum.myteacher = "Ismail";

            ////kursum.melumat = "SITEP AYTI";
            ////Console.WriteLine(kursum.melumat);

            ////Console.WriteLine(kursum.getCoursName());

            ////  Console.WriteLine(kursum.setCoursName());

            //kursum.setNewName("hello world");

            //Hesaplama hesapla = new Hesaplama();


            //Console.WriteLine(hesapla.Sahe());
            //Console.WriteLine(hesapla.Perimetr());


            Book kitabim = new Book();
            kitabim.kitab = "Timsahin goz yaslari - VEZIR";
            kitabim.muellif = new Author();

            Console.WriteLine(kitabim.kitab);
        }




    }



    //class CodeAcademy
    //{
    //    private string cours;
    //    private string groups;
    //    private string teachers;
    //    private string mygroup;
    //    private string myteacher;

    //    public string melumat;

    //    private string newName;

    //    public CodeAcademy()
    //    {
    //        cours = "Code Acdemy";
    //        groups = "12";
    //        teachers = "Samir, Ulvi, Ismail";
    //        mygroup = "P502";
    //        myteacher = "Ismail";
    //        melumat = cours;
    //    }


    //    public string geriDonus ()
    //    {
    //        return "Men " + cours + "-da " + groups + "da tehsil aliram. Menim kurs mellimim " + myteacher + " mellimdir.";
    //    }

    //    public string getCoursName ()
    //    {
    //        return cours;
    //    }

    //    public void setNewName (string arg)
    //    {
    //        newName = arg;
    //    }
    //}


    //class Hesaplama
    //{
    //    public int en;
    //    public int hundurluk;


    //    public int Sahe()
    //    {
    //        int n = int.Parse( Console.ReadLine());
    //        int h = int.Parse(Console.ReadLine());
    //        return n * h;
    //    }

    //    public int Perimetr ()
    //    {
    //        int n = int.Parse(Console.ReadLine());
    //        int h = int.Parse(Console.ReadLine());
    //        return (n +h) * 2;
    //    }
        
    //}


    class Book
    {
        public string kitab;

        public Book()
        {
            kitab = "Timsahin goz yaslari - VEZIR";
        }

        public Author muellif;

    }


    class Author
    {
        
        public string ad;
        public string soyad;

        public Author ()
        {
            ad = "Ali";
            soyad = "Allahverdiyev";
        }

    } 
}
