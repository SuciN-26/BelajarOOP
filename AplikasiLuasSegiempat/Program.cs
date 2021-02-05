using System;

namespace AplikasiLuasSegiempat
{
    class Program
    {
        static void Main(string[] args)
        {
            Segiempat s = new Segiempat();

            s.Panjang = 5;
            s.Lebar = 0;


            Console.WriteLine("Luas {0} \n Keliling = {1}", s.HitungLuasSegiempat(), s.KelilingSegiempat);
        }
    }
}
