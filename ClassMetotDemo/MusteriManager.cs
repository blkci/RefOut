using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " kişisi eklendi. ");
        }

        public void List(Musteri[] musteri)
        {
            for (int i = 0; i < musteri.Length; i++)
            {
                Console.WriteLine("Müşteri adı: " + musteri[i].Name);
            }
            
        }
        public void Remove(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " kişisi silindi. ");
        }

    }
}
