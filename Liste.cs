using System;

namespace Calisma22_Generics
{
    public class Liste
    {
        private object[] elemanlar;
        private static int varSayilanKapasite = 4;
        private int buyukluk;
        public Liste()
        {
            elemanlar = new object[varSayilanKapasite];
        }
        public virtual int Ekle(object deger)
        { 
            Console.WriteLine("Büyüklük = " + buyukluk);

            if (this.buyukluk == this.elemanlar.Length)
            {
                this.GerekliyseKapasiteArtir(this.buyukluk + 1);
            }
            this.elemanlar[this.buyukluk] = deger;
            return this.buyukluk++;
        }
        public object this[int index]
        {
            get
            {
                if ((index < 0) || (index >= this.buyukluk))
                {
                    throw new Exception("yanlış index");
                }
                return this.elemanlar[index];
            }
            set
            {
                if ((index < 0) || (index >= this.buyukluk))
                {
                    throw new Exception("yanlış index");
                }
                this.elemanlar[index] = value;
            }
        }
        private void GerekliyseKapasiteArtir(int min)
        {
            if (elemanlar.Length < min)
            {// Console.WriteLine(min);
                int adet = (elemanlar.Length == 0) ? varSayilanKapasite : min;
                if (adet < min)
                {
                    adet = min;
                }
                this.Kapasite = adet;
            }
        }
        public int Kapasite
        {
            get { return elemanlar.Length; }
            set
            {
                if (value != this.elemanlar.Length)
                {
                    if (value > 0)
                    {
                        object[] yenidizi = new object[value];
                        if (this.buyukluk > 0)
                        {
                            Array.Copy(elemanlar, 0, yenidizi, 0, this.buyukluk);
                        }
                        this.elemanlar = yenidizi;
                    }
                    else
                    {
                        this.elemanlar = new object[varSayilanKapasite];
                    }
                }
            }
        }
        public int Boyut
        {
            get { return elemanlar.GetUpperBound(0); }
        }
        public object[] Elemanlar
        {
            get { return elemanlar; }
            set { elemanlar = value; }

        }

    }
}
