using System;

namespace Calisma22_Generics
{
    public class Liste2<T>
    {
        private T[] elemanlar;
        private static int varSayilanKapasite = 4;
        private int buyukluk;
        public Liste2()
        {
            elemanlar = new T[varSayilanKapasite];
        }
        public virtual int Ekle(T deger)
        {
            if (this.buyukluk == this.elemanlar.Length)
            {
                this.GerekliyseKapasiteArtir(this.buyukluk + 1);
            }
            this.elemanlar[this.buyukluk] = deger;
            return this.buyukluk++;
        }
        public T this[int index]
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
            {
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
                        T[] yenidizi = new T[value];
                        if (this.buyukluk > 0)
                        {
                            Array.Copy(elemanlar, 0, yenidizi, 0, this.buyukluk);
                        }
                        this.elemanlar = yenidizi;
                    }
                    else
                    {
                        this.elemanlar = new T[varSayilanKapasite];
                    }
                }
            }
        }
        public int Boyut
        {
            get {return elemanlar.GetUpperBound(0);}
        }
        // public override string ToString()
        // {
        //     return $"{"
        // }
    }
}
