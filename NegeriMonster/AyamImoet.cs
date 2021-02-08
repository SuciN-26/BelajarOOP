using System;
using System.Collections.Generic;
using System.Text;

namespace NegeriMonster
{
    public class AyamImoet : Monster
    {
        public override void Bobo()
        {
            Console.WriteLine("Ayam Imoet sedang bobo siang..");
        }

        public void MakanCacing100Tahun()
        {
            Console.WriteLine("Nyam.. Nyam.. Nyam..");
        }
    }
}
