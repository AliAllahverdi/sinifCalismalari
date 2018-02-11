using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum halfMoon { yanvar=1, fevral, mart, aprel, may=12};


    class Program
    {
        static void Main(string[] args)
        {
            int a = (int)halfMoon.yanvar;
            int b = (int)halfMoon.fevral;
            int c = (int)halfMoon.mart;
            int d = (int)halfMoon.aprel;
            int e = (int)halfMoon.may;

            Vaxt vaxt = new Vaxt(1, 12, 52, 8766, 525690, 31557600);
            
            Console.WriteLine(vaxt.print());

            Console.WriteLine();
               

               

            

        }
    }

    struct Vaxt
    {
        public int il;
        public int ay;
        public int hefte;
        public int saat;
        public int deqiqe;
        public int saniye;

        public Vaxt (int a, int b, int c, int d, int e, int f)
        {
            il = a;
            ay = b;
            hefte = c;
            saat = d;
            deqiqe = e;
            saniye = f;

        }

        public string print()
        {
            return "il: " + il + " ay: " + (halfMoon)ay + " hefte: " + hefte + " saat: " + saat + " deqiqe: " + " saniye:   ";
        }
    }
}
