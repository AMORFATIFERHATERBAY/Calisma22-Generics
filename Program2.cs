using System;

namespace Calisma22_Generics
{
    class Program2
    {
        static void Main(string[] args)
        {


            Liste listem = new Liste();
            Console.WriteLine("Nesnenin Boyutu :{0}", listem.Kapasite);
            listem.Ekle(3);
            listem.Ekle(4);
            listem.Ekle(5);
            listem.Ekle(6);
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ali");
            listem.Ekle("Ahmet");
            listem.Ekle("Ahmet");
            listem.Ekle("Ahmet");
            listem.Ekle("Ahmet");
            listem.Ekle("Ahmet");
            // listem.Ekle("Ali");
            // listem.Ekle("Ali");
            // listem.Ekle("Ali");
            // Console.WriteLine(listem[0]);        
            // Console.WriteLine(listem[5]);        
            // Console.WriteLine(listem[19]);        
            for (int i = 0; i < listem.Kapasite; ++i)
                Console.WriteLine(listem.Elemanlar[i]);
            Console.WriteLine("Nesnenin Boyutu :{0}", listem.Kapasite);

            Liste2<int> listem2 = new Liste2<int>();
            Random rnd = new Random();
            for (int i = 0; i < 4; ++i)
            {
                listem2.Ekle(rnd.Next(0, 100));

            }
            int[] sayi = listem2.Elemanlar;
            int total = 0;
            foreach (int i in sayi)
            {
                Console.Write(i + " ");
                total += i;
            }
            Console.WriteLine();
            Console.WriteLine("Toplam = {0}", total);



        }
    }
}
