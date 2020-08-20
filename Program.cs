using System;

namespace Calisma22_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime dtBaslangici1 = DateTime.Now;
            Liste listem1 = new Liste();
            for (int i = 0; i < 10000; i++)
            {
                listem1.Ekle(i);
                int eleman = (int)listem1[i];
            }
            DateTime dtSon1 = DateTime.Now;
            TimeSpan tsSure1 = dtSon1 - dtBaslangici1;

            Console.WriteLine("Klasik versiyonu : " + tsSure1.TotalMilliseconds);
            // Liste listem = new Liste();
            //     Console.WriteLine("Nesnenin Boyutu :{0}", listem.Kapasite);
            //   // listem.Ekle(3);
            //     listem.Ekle(4);
            //     listem.Ekle(5);
            //     listem.Ekle(6);
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ali");
            //     listem.Ekle("Ahmet");
            //     listem.Ekle("Ahmet");
            //     listem.Ekle("Ahmet");
            //     listem.Ekle("Ahmet");
            //     listem.Ekle("Ahmet");
            //     // listem.Ekle("Ali");
            //     // listem.Ekle("Ali");
            //     // listem.Ekle("Ali");
            //     Console.WriteLine(listem[0]);        
            //     Console.WriteLine(listem[5]);        
            //     Console.WriteLine(listem[19]);        
            //     for (int i=0; i<listem.Kapasite; ++i)
            //     Console.WriteLine(listem[i]);
            //      Console.WriteLine("Nesnenin Boyutu :{0}", listem.Kapasite);

            DateTime dtBaslangici2 = DateTime.Now;
            Liste2<int> listem2 = new Liste2<int>();
            for (int i = 0; i < 10000; i++)
            {
                listem2.Ekle(i);
                int eleman = listem2[i];
            }
            DateTime dtSon2 = DateTime.Now;
            TimeSpan tsSure2 = dtSon2 - dtBaslangici2;

            Console.WriteLine("Şablon tür versiyonu : " + tsSure2.TotalMilliseconds);
        }
    }
}
