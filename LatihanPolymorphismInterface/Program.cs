using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contoh data mahasiswa
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "21.11.4388";
            mhs.nama = "Oxa Defrizal Khasay";
            mhs.email = "oxadefrizal@students.amikom.ac.id";

            Console.WriteLine("Pilih format konversi Data: ");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. Csv\n");

            Console.Write("Nomor format Data [1..3]: ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            ConvertObject convert; //deklarasi object konversi

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();

            // konversi object mhs berdasarkan format yang dipilih
            convert.Convert(mhs);

            Console.ReadKey();
        }
    }
}
