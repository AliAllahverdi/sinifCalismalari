using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher muellim = new Teacher("Ismail");
            
            muellim.surname = "Ismailov";
            muellim.age = 30;
            muellim.degree = "developer";

            Student telebe = new Student("Nicat");
            
            telebe.surname = "Hemidov";
            telebe.age = 20;
            telebe.attendance = 30;
            telebe.books = 15;
            telebe.group = "p502";


          
            telebe.ishleri = new Works[2] { new Works() { cleancode = 100, intime = true, selfRespect = 5 }, new Works() { } };

            //Console.WriteLine(telebe.ishleri[0].cleancode);



            CodeAcademy codeAcad = new CodeAcademy(30, 40);
            Building bl = new Building(45,25);
            Console.WriteLine(bl.printBuild());


            Console.WriteLine(codeAcad.printBuild());
           
        }
    }

    class Person
    {
        public string name;
        public string surname;
        public int age;
        public Person(string ad)
        {
            name = ad;
        }

        public virtual string print ()
        {
            return name + surname;
        }
    }

    class Teacher : Person
    {
        public string degree;

        public Teacher(string tad):base(tad)
        {

        }
    }

    class Student : Person
    {
        public int attendance;
        public Works[] ishleri;
        public int books;
        public string group;
        public Student(string sad):base(sad)
        {

        }
    }

    class Works
    {
        public int cleancode;
        public int selfRespect;
        public bool intime;
    }

    class Building
    {
        public int height;
        public int width;
        public Building(int h, int e)
        {
            height = h;
            width = e;
        }

        public virtual int printBuild()
        {
            return 0;  
        }

    }

    class CodeAcademy:Building
    {
        public ClassRoom[] sinifler;
        public bool entrance;
        public int floor;
        public CodeAcademy(int h, int e):base(h, e)
        {

        }

        public override int printBuild()
        {
            return 10;
        }
    }

    class ClassRoom
    {
        public int door;
        public int window;
    }





}


