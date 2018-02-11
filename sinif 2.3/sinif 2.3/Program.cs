using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sinif_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Human insan = new Human();
           
            insan.name = "Ali";
            //insan.surname = "Allahverdiyev";
            insan.Age = 25;

            Console.WriteLine("name:{0} - surname:{1} - Age:{2}", insan.name, insan.surname, insan.Age);
        }
    }

    public class Human 
    {
        private int age;
        public int Age
        {   get
            {
                return age;

            }
            set
            {
                age = value;

                if (value <= 100 && value >= 0)
                {
                    age = value;
                }
                else 
                {
                    age = 0;
                    throw new Exception("Fazla soğuk");
                }
            }
        }
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length < 10 && value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    
                    throw new Exception();
                }
            }
        }

        private string _surname;
        public string surname
        {
            get
            {
                return _surname;
            }

            private set
            {
                _surname = value;
            }

        }
        public Human()
        {
            surname = "Allahverdiyev";
        }

    }

}
