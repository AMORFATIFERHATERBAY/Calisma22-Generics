using System;

namespace Calisma22_Generics
{
    abstract class Memeli
    {
       abstract public void Konus();
    }
    class Kedi : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("miyavv miyavv");
        }
    }
    class Kopek : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("haavv  havv  havv");
        }
    }
    class Konusturma<T> where T : Memeli
    {
        private T memeli;
        public Konusturma(T memeli)
        {
            this.memeli=memeli;
        }
        public void Konustur()
        {
            memeli.Konus();
        }
    }
}
