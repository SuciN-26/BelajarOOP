using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiLuasSegiempat
{
    class Segiempat
    {
        private double _panjang;
        private double _lebar;

        public double Panjang
        { 
            get { return _panjang; }
            set
            {
                if (value > 0)
                    _panjang = value;
                else
                    _panjang = 1;
            }
        }

        public double Lebar
        {
            get { return _lebar; }
            set
            {
                if (value > 0)
                    _lebar = value;
                else
                    _lebar = 1;
            }
        }

        public double HitungLuasSegiempat()
        {
            return Panjang * Lebar;
        }

        public double KelilingSegiempat
        {
            get { return 2 * (Panjang + Lebar); } 
        
        }
    }
}
