using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Imtahan imtahan = new Imtahan();
            imtahan.riyaziyyat = new result(10, 3);
            imtahan.azdili = new result(19, 6);
            imtahan.edebiyyat = new result(19, 5);
            imtahan.tarix = new result(24, 1);
            imtahan.xaricidil = new result(14, 7);
            imtahan.printresult();

        }
    }

    public class Imtahan
    {
        public result riyaziyyat;
        public result azdili;
        public result edebiyyat;    
        public result tarix;
        public result xaricidil;

        public void printresult()
        {
            double netice = 0;
            netice += (riyaziyyat.dogru-riyaziyyat.yanlis/4) * 4;
            netice += (azdili.dogru - azdili.yanlis/4) * 8;
            netice += (edebiyyat.dogru - edebiyyat.yanlis/4) * 4;
            netice += (tarix.dogru - tarix.yanlis/4) * 8;
            netice += (xaricidil.dogru - xaricidil.yanlis/4) * 4;

            Console.WriteLine(netice);
            Console.ReadLine();
        }

    }

    public  class result
    {
        public double dogru;
        public double yanlis;


        public result(double a, double b)
        {
           
            dogru = a;
            yanlis = b;

           
        }

         
    }
}
