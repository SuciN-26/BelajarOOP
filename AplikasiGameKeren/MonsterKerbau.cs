using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiGameKeren
{
    public class MonsterKerbau : MonsterDarat
    {
        public MonsterKerbau()
        {
            Nyawa = 100;
        }

        public override void Menyerang()
        {
            Console.WriteLine("Kerbau Menyereduk");
        }

        public new void MelarikanDiri()
        {
            Console.WriteLine("Kerbau Melarikan Diri");
        }
    }
}
