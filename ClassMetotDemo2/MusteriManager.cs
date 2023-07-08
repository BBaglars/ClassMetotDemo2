using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo2
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
            {
            Console.WriteLine("\nMüşteri Eklendi = " + musteri.Id + " - " + musteri.Name + " " + musteri.Surname);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("\nMüşteri Silindi = " + musteri.Id + " - " + musteri.Name + " " + musteri.Surname);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("\nMüşteri Id : " + musteri.Id);
            Console.WriteLine("Müşteri Adı : " + musteri.Name);
            Console.WriteLine("Müşteri Soyadı : " + musteri.Surname);
            Console.WriteLine("------------------------------------------");
        }
    }
}
