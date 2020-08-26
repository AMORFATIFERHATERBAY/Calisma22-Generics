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



            // ListeT<int> listem2 = new ListeT<int>();
            // ListemT<int> listem2 = new ListemT<int>();

            Liste2<int> listem2 = new Liste2<int>();

            Random rnd = new Random();

            for (int i = 0; i < 6; ++i)
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


            ListeT<int> list = new ListeT<int>();

            for (int i = 0; i < 6; ++i)
            {
                list.Ekle1(rnd.Next(0, 100));

            }

            int[] sayi1 = list.Elemanlar1;
            int total1 = 0;

            foreach (int i in sayi1)
            {
                Console.Write(i + " ");
                total1 += i;
            }
            Console.WriteLine();
            Console.WriteLine("Toplam = {0}", total1);

            Islemler<int> islem = new Islemler<int>();

            int a = islem.IslemYap(4, 5);
            Console.WriteLine(a);

            int b = islem.IslemYap(4, -1);
            Console.WriteLine(b);
            islem.Metot();

            Kedi kedi = new Kedi();
            Kopek kopek = new Kopek();

            Konusturma<Kedi> k1 = new Konusturma<Kedi>(kedi);
            k1.Konustur();

            Konusturma<Kopek> k2 = new Konusturma<Kopek>(kopek);
            k2.Konustur();





        }
    }
}
