using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyutlama__Abstraction_2
{
    internal class Program
    {
        // Interface 1
        interface IKosabilir
        {
            void Kos();
        }

        // Interface 2
        interface IUcabilir
        {
            void Uc();
        }

        // Abstract sınıf
        abstract class Canli
        {
            public string Ad { get; set; }

            public Canli(string ad)
            {
                Ad = ad;
            }

            public abstract void Tanit();
        }

        // Birden fazla interface uygulayan sınıf
        class Kartal : Canli, IKosabilir, IUcabilir
        {
            public Kartal(string ad) : base(ad) { }

            public override void Tanit()
            {
                Console.WriteLine($"Ben bir kartalım. Adım: {Ad}");
            }

            public void Kos()
            {
                Console.WriteLine($"{Ad}: Kısa mesafe koşabiliyor.");
            }

            public void Uc()
            {
                Console.WriteLine($"{Ad}: Yükseklere uçuyor.");
            }
        }
        static void Main(string[] args)
        {
            Kartal k = new Kartal("Şahin");
            k.Tanit();
            k.Kos();
            k.Uc();
        }
    }
}
