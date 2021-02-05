using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class Sapi
    {
        private string nama;
        private int jumlahKaki = 4;
        private int umur = 0;
        public string makanan;

        public void GantiNama(string namaBaru)
        {
            nama = namaBaru;
        }

        public string LihatNama()
        {
            return nama;
        }

        public int LihatJumlahKaki()
        {
            return jumlahKaki;
        }

        public int LihatUmur()
        {
            return umur;
        }

        public void Makan()
        {
            Console.WriteLine("{0} sedang makan. {0} memakan {1}.", nama, makanan);
        }

        public void Jalan() 
        {
            Console.WriteLine("{0} sedang jalan.", nama);
        }

        public void Bobo()
        {
            Console.WriteLine("{0} sedang bobo.", nama);
        }

    }
}
