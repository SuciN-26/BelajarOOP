using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiGameKeren
{
    public class MonsterKecoa : MonsterUdara
    {
        public MonsterKecoa()
        {
            Nyawa = 80;
        }

        public override void Menyerang()
        {
            Console.WriteLine("Kecoa Menggit");
        }
    }
}
