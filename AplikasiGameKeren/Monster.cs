using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiGameKeren
{
    public class Monster
    {
        private int _nyawa;

        public int Nyawa
        {
            get { return _nyawa; }
            set { _nyawa = value; }
        }

        public virtual void Menyerang()
        {
            Console.WriteLine("Monster Menyerang dengan sangat brutal");
        }

        public void MelarikanDiri()
        {
            Console.WriteLine("Monster Melarikan Diri");
        }
    }
}
