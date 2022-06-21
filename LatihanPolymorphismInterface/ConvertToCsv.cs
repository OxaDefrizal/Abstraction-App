using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAbstraction
{
    public class ConvertToCsv : ConvertObject
    {
        public override void Convert(Mahasiswa mhs)
        {
            //konversi objek mahasiswa ke csv
            string csv = string.Format("{0},{1},{2}", mhs.npm, mhs.nama, mhs.email);

            Console.WriteLine("hasil Konversi ke csv:\n");
            Console.WriteLine(csv);
        }
    }
}
