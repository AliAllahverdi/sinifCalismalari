using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._02_AllEx
{
    public class Library
    {
        public string libName { get; set; }
        public List<BookShelf> Shkaflar { get; set; }

    }

    public class BookShelf
    {
        public List<Box> qutular { get; set; }
    }

    public class Box
    {
       public List<Book> kitablar { get; set; }
    }

    public class Book
    {
        public string author;
        public string title;
        public int page;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Library kitabxana = new Library();
            kitabxana.libName = "Axundov";

            Book kitab1 = new Book() { title = "HopHopName", author = "Sabir", page = 400 };
            Book kitab2 = new Book() { title = "Diplomacy", author = "Kissinger", page = 900 };
            Book kitab3 = new Book() { title = "reqemsal qala", author = "Dan Brown", page = 500 };
            Book kitab4 = new Book() { title = "BBC jurnalistikasi", author = "BBC", page = 600 };
            Book kitab5 = new Book() { title = "Qilinc ve Qelem", author = "Ordubadi", page = 400 };
            Book kitab6 = new Book() { title = "Dovsanlarin reqsi", author = "Ali", page = 500 };
            Book kitab7 = new Book() { title = "Herb ve Sulh", author = "Tolstoy", page = 1200 };
            Book kitab8 = new Book() { title = "Yasamaq yanmaqdisa yanasan gerek", author = "Seni yanasan ay qiz", page = 10 };
            Book kitab9 = new Book() { title = "Gunes Panelinin Uzay Mecaralari - Bioqrafiya", author = "Kamal", page = 500 };

            Box qutu1 = new Box();
            qutu1.kitablar = new List<Book>();
            qutu1.kitablar.Add(kitab1);
            qutu1.kitablar.Add(kitab2);
            qutu1.kitablar.Add(kitab3);

            Box qutu2 = new Box();
            qutu2.kitablar = new List<Book>();
            qutu2.kitablar.Add(kitab4);
            qutu2.kitablar.Add(kitab5);
            qutu2.kitablar.Add(kitab6);

            Box qutu3 = new Box();
            qutu3.kitablar = new List<Book>();
            qutu3.kitablar.Add(kitab7);
            qutu3.kitablar.Add(kitab8);
            qutu3.kitablar.Add(kitab9);

            BookShelf Shkaf = new BookShelf();
            Shkaf.qutular = new List<Box>();
            Shkaf.qutular.Add(qutu1);
            Shkaf.qutular.Add(qutu2);
            Shkaf.qutular.Add(qutu3);

            kitabxana.Shkaflar = new List<BookShelf>();
            kitabxana.Shkaflar.Add(Shkaf);

            var result = kitabxana.Shkaflar.Where(sh => sh.qutular == sh.qutular.Where(q => q.kitablar == q.kitablar.Where(k => k.title == "Diplomacy")));
            foreach(var items in result)
            {
                Console.WriteLine(items.qutular); 
            }
        }
    }
}
