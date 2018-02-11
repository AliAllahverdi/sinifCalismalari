using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linktapsiriqSinif
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> students = new List<Person>();
            students.Add(new Person("Ali", "Allahverdiyev", 27));
            students.Add(new Person("Vezir", "Tarverdiyev", 21));
            students.Add(new Person("KaMal", "Rzazade", 25));
            students.Add(new Person("Kenan", "Bagirov", 27));
            students.Add(new Person("AliAga", "Musayev", 28));

            List<Person> wanteds = new List<Person>();
            //var search = Console.ReadLine();

            //var search = students.Where(a => a.age > 20 && a.age <= 27 && a.name != "KaMal");

            //foreach(var wanted in search)
            //{
            //    Console.WriteLine("name: {0}, lastname: {1}, age: {2}", wanted.name, wanted.lastName, wanted.age);
            //}


            var greatword = students.Where(b => b.name.Substring(0,1) == "K");

            foreach (var wanted in greatword)
            {
                wanted.name = wanted.name.Substring(0, wanted.name.Length - 1) + wanted.name.Substring(wanted.name.Length - 1, 1).ToUpper();
                Console.WriteLine(wanted.name);
            }







            //foreach (var student in students)
            //{
            //    if(student.lastName == search)
            //    {
            //        wanteds.Add(student);
            //    }
            //}
            //foreach(var wanted in wanteds)
            //{
            //    Console.WriteLine("name: {0}, lastname: {1}, age: {2}", wanted.name, wanted.lastName, wanted.age);
            //}


        }
    }

    class Person
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public Person(string n, string l, int a)
        {
            name = n;
            lastName = l;
            age = a;
        }
    }
}
