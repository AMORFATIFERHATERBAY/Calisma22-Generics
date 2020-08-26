using System;

namespace Calisma22_Generics
{
    // public class ListemT 
    // {

    //     private object[] elemanlar;
    //     private static int varSayilanKapasite = 4;
    //     private int buyukluk;
    //     public ListemT()
    //     {
    //         elemanlar = new object[varSayilanKapasite];
    //     }
    //     public virtual int Ekle(object deger)
    //     { 
    //         Console.WriteLine("Büyüklük = " + buyukluk);

    //         if (this.buyukluk == this.elemanlar.Length)
    //         {
    //             this.GerekliyseKapasiteArtir(this.buyukluk + 1);
    //         }
    //         this.elemanlar[this.buyukluk] = deger;
    //         return this.buyukluk++;
    //     }
    //     public object this[int index]
    //     {
    //         get
    //         {
    //             if ((index < 0) || (index >= this.buyukluk))
    //             {
    //                 throw new Exception("yanlış index");
    //             }
    //             return this.elemanlar[index];
    //         }
    //         set
    //         {
    //             if ((index < 0) || (index >= this.buyukluk))
    //             {
    //                 throw new Exception("yanlış index");
    //             }
    //             this.elemanlar[index] = value;
    //         }
    //     }
    //     private void GerekliyseKapasiteArtir(int min)
    //     {
    //         if (elemanlar.Length < min)
    //         {// Console.WriteLine(min);
    //             int adet = (elemanlar.Length == 0) ? varSayilanKapasite : min;
    //             if (adet < min)
    //             {
    //                 adet = min;
    //             }
    //             this.Kapasite = adet;
    //         }
    //     }
    //     public int Kapasite
    //     {
    //         get { return elemanlar.Length; }
    //         set
    //         {
    //             if (value != this.elemanlar.Length)
    //             {
    //                 if (value > 0)
    //                 {
    //                     object[] yenidizi = new object[value];
    //                     if (this.buyukluk > 0)
    //                     {
    //                         Array.Copy(elemanlar, 0, yenidizi, 0, this.buyukluk);
    //                     }
    //                     this.elemanlar = yenidizi;
    //                 }
    //                 else
    //                 {
    //                     this.elemanlar = new object[varSayilanKapasite];
    //                 }
    //             }
    //         }
    //     }
    //     public int Boyut
    //     {
    //         get { return elemanlar.GetUpperBound(0); }
    //     }
    //     public object[] Elemanlar
    //     {
    //         get { return elemanlar; }
    //         set { elemanlar = value; }

    //     }

    // }
    public class ListeT<G>
    {
        private G[] elemanlar1;
        private static int varSayilanKapasite1 = 4;
        private int buyukluk1;
        public ListeT()
        {
            elemanlar1 = new G[varSayilanKapasite1];
        }
        public virtual int Ekle1(G deger)
        {
            Console.WriteLine("Büyüklük = " + buyukluk1);

            if (this.buyukluk1 == this.elemanlar1.Length)
            {
                Console.WriteLine(">>>" + (this.buyukluk1 + 1));
                this.GerekliyseKapasiteArtir1(buyukluk1 + 1);
            }
            this.elemanlar1[this.buyukluk1] = deger;
            return buyukluk1++;
        }
        public G this[int index]
        {
            get
            {
                if ((index < 0) || (index >= this.buyukluk1))
                {
                    throw new Exception("yanlış index");
                }
                return this.elemanlar1[index];
            }
            set
            {
                if ((index < 0) || (index >= this.buyukluk1))
                {
                    throw new Exception("yanlış index");
                }
                this.elemanlar1[index] = value;
            }
        }
        private void GerekliyseKapasiteArtir1(int min)
        {
            if (elemanlar1.Length < min)
            {

                int adet = (elemanlar1.Length == 0) ? varSayilanKapasite1 : min;
                if (adet < min)
                {
                    adet = min;
                }
                this.Kapasite1 = adet;

            }
        }

        public int Kapasite1
        {
            get { return elemanlar1.Length; }
            set
            {
                if (value != this.elemanlar1.Length)
                {
                    if (value > 0)
                    {
                        G[] yenidizi1 = new G[value];
                        if (this.buyukluk1 > 0)
                        {
                            Array.Copy(elemanlar1, 0, yenidizi1, 0, this.buyukluk1);
                        }
                        this.elemanlar1 = yenidizi1;
                    }
                    else
                    {
                        this.elemanlar1 = new G[varSayilanKapasite1];
                    }
                }
            }
        }
        public G[] Elemanlar1
        {
            get { return this.elemanlar1; }
            set { this.elemanlar1 = value; }

        }

    }

    class Islemler<T>
    {
        public T IslemYap(T v, int param)
        {
            if (param >= 0)
                return v;
            else
                return default(T);
        }
        public void Metot()
        {
            
            T degisken = default(T); 
            Console.WriteLine(degisken);
        }
    }

}