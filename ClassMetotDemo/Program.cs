using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            MusteriManager customer = new MusteriManager();
            musteri.Id = 1;
            musteri.Name = "Muhammet";
            musteri.Surname = "Balıkçı";

            musteri1.Id = 2;
            musteri1.Name = "Kerem";
            musteri1.Surname = "Akkaş";

            musteri2.Id = 3;
            musteri2.Name = "Yasin";
            musteri2.Surname = "Kahveci";

            customer.Add(musteri);
            customer.Add(musteri1);
            customer.Add(musteri2);

            Musteri[] list = new Musteri[3] {musteri,musteri1,musteri2 };
            
            customer.List(list);

            customer.Remove(musteri1);



            



            
        }
    }
}
