using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCollection2
{
    public class sales : karyawan
    {
        public double jumlahpenjualan { get; set; }
        public double komisi { get; set; }

        public override double gaji()
        {
            double jumlah = jumlahpenjualan * komisi;
            return jumlah;
        }
    }
}
