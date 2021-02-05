using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sapi sapiSaya, sapiKamu;

            sapiSaya = new Sapi();
            //sapiKamu.nama = "Komooo";

            //sapiSaya.jumlahKaki = 4;
            //sapiSaya.umur = 1;
            //sapiSaya.makanan = "rumput";

            //Console.WriteLine("Nama sapi saya adalah {0}", sapiSaya.nama);
            //Console.WriteLine("Ia memiliki kaki sebanyak {0}", sapiSaya.jumlahKaki);
            //Console.WriteLine("Saat ini ia berumur {0}", sapiSaya.umur);
            //Console.WriteLine("Sapi Kamu {0} Sapi Saya {1}", sapiSaya.nama, sapiKamu.nama);
            //sapiSaya.Jalan();
            //sapiSaya.Makan();
            //sapiSaya.Bobo();

            sapiSaya.GantiNama("Unyil");
            Console.WriteLine("Nama sapi saya adalah {0}", sapiSaya.LihatNama());
            Console.WriteLine("Ia memiliki kaki sebanyak {0}", sapiSaya.LihatJumlahKaki());
            Console.WriteLine("Saat ini ia berumur {0}", sapiSaya.LihatUmur());


        }
    }
}
