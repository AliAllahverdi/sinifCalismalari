using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_hefte
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programProqnoz=true;

            while (programProqnoz)
            {
                Console.Write("Adinizi daxil edin: ");
                string name = Console.ReadLine().ToString();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (name=="Vezir" || name == "Vezirxan" || name == "Kamal"){

                    Console.WriteLine("basqa qapiya");
                    return;
                }
                Console.WriteLine("Xos geldiniz {0}", name);
                Console.ResetColor();
                Console.WriteLine();
                YenidenBasla:
                Console.Write("Telebesiniz? beli/xeyr: ");
                string telebeyem = (Console.ReadLine()).ToString();
                Console.WriteLine();
                switch (telebeyem)
                {
                    case "beli":
                        Console.Write("Hansi universitetde oxuyursunuz?: ");
                        string universitet = (Console.ReadLine()).ToString();
                        Console.WriteLine();
                        Console.Write("Ixtisasiniz nedir?: ");
                        string ixtisas = (Console.ReadLine()).ToString();
                        int tekEdedlerinCemi = tekEdedCemi(100);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tesekkur edirik {0}, sen {1}-de oxuyursan, {2} tehsili alirsan ve 1-den 100-e qeder tek ededlerin ceminin {3} oldugunu bilirsen",
                            name, universitet, ixtisas, tekEdedlerinCemi);
                        Console.ResetColor();
                        break;

                    case "xeyr":

                        YenidenSec:
                        Console.Write("Ishleyirsiniz? beli/xeyr : ");
                        string ish = (Console.ReadLine()).ToString();
                        Console.WriteLine();
                       
                        switch (ish)
                        {
                            case "beli":
                                Console.Write("Hansi sirketde? : ");
                                string sirket = Console.ReadLine().ToString();
                                Console.WriteLine();
                                Console.Write("Vezifeniz: ");
                                string vezife = Console.ReadLine().ToString();
                                int tekededlerinCemi = tekEdedCemi(101);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tesekkur edirik {0}, sen {1}-de {2} vezifesinde isleyirsen ve 1-den 101-e qeder tek ededlerin ceminin {3} oldugunu bilirsen",
                                name, sirket, vezife, tekededlerinCemi); //burada ""-lardan sonra ustegel qoydum, evvel isledi ama sonra xeta verdi. digerlerinde de eyni oldu. bunu izah edersizniz zehmet olmasa
                                Console.ResetColor();
                                break;

                            case "xeyr":
                                int uceBolunenCutEdedCemi = uceBolunenCutEdedlerinCemi();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("{0}, Boyuk ehtimalla sen sagirdsen, buna baxmayaraq 1-den 200e qeder olan 3-e bolunen cut ededlerin ceminin {1} oldugunu bilirsen",
                                    name, uceBolunenCutEdedCemi);
                                Console.ResetColor();
                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Zehmet olmasa seciminizi duzgun yazin beli/xeyr");
                                Console.ResetColor();
                                goto YenidenSec;
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zehmet olmasa seciminizi duzgun yazin");
                        Console.ResetColor();
                        goto YenidenBasla;
                }

                Console.WriteLine();


                bool yanlisSecim = false;


                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Proqramdan cixmaq isteyirsiz? beli/xeyr : ");
                    Console.ResetColor();
                    string cixis = Console.ReadLine().ToString();
                    if (string.Equals("beli", cixis))
                    {
                        yanlisSecim = false;
                        programProqnoz = false;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Proqrami baglamaq ucun zehmet olmasa her hansi duymeye klikleyin");
                        Console.ResetColor();

                    }
                    else if (string.Equals("xeyr", cixis))
                    {
                        yanlisSecim = false;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Davam etmek ucun Enter duymesine klikleyin!!!");
                        Console.ResetColor();
                        Console.Clear();

                    }
                    // istifadeci sehv secim ederse
                    else
                    {
                        yanlisSecim = true;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zehmet olmasa duzgun secim edin !!!");
                        Console.ResetColor();
                    }

                } while (yanlisSecim);

                Console.ReadKey();
            }
        }

        public static int tekEdedCemi(int tekler)
        {
            int cem = 0;
            for (int i = 1; i <= tekler; i++)
            {
                if (i % 2 != 0)
                {
                    cem += i;
                }
            }
            return cem;
        }

        public static int uceBolunenCutEdedlerinCemi()
        {
            int cem = 0;
            for (int i = 1; i <= 200; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    cem += i;
                }
            }
            return cem;
        }
    }
}
