﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LatihanAbstraction
{
    public class ConvertToJson : ConvertObject
    {
        public override void Convert(Mahasiswa mhs)
        {
            //konversi object mahasiswa ke json
            string json = JsonConvert.SerializeObject(mhs);

            Console.WriteLine("Hasil konversi ke json:\n");
            Console.WriteLine(json);
        }
    }
}
