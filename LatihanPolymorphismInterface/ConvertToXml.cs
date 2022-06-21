using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace LatihanAbstraction
{
    public class ConvertToXml : ConvertObject
    {
        public override void Convert(Mahasiswa mhs)
        {
            using (StringWriter writer = new StringWriter())
            {
                //konversi object mahasiswa ke XML
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Mahasiswa));
                xmlSerializer.Serialize(writer, mhs);

                string xml = writer.ToString();

                Console.WriteLine("Hasil Konversi ke XML:\n");
                Console.WriteLine(xml);
            }
        }
    }
}
