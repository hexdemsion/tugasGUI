using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasGUI
{
    class Lingkaran
    {
        public double jari, phi;

        public void Konstruksi(double jari, double phi)
        {
            this.jari = jari;
            this.phi = phi;
        }

        public double Keliling()
        {
            return this.phi * this.jari * 2;
        }

        public double Luas()
        {
            return this.phi * Math.Pow(this.jari, 2);
        }
    }
}
