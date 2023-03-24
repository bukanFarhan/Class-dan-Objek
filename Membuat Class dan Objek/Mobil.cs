using System;
using System.Collections.Generic;
using System.Text;

namespace Membuat_Class_dan_Objek
{
    class Mobil
    {
        // property
        public string warna { get; set; }
        public string merek { get; set; }
        public string model { get; set; }
        public int JumlahPintu { get; set; }
        public int TahunKeluaran { get; set; }
        public int kecepatan { get; set; }
        public string suara { get; set; }

        // methode
        public void Gas ()
        {
            Console.WriteLine("Muhammad Farhan Anggara");
            Console.WriteLine("19.11.2842");
            Console.WriteLine("");
            Console.Write("Mobil {0}", model);
            Console.Write(" Berjalan dengan kecepatan {0}", kecepatan);
            Console.WriteLine("\n");
        }

        public void Klakson()
        {
            Console.Write("Suara Klakson {0}", suara);
            Console.WriteLine("\n");
        }

        public void TampilkanInfo()
        {
            Console.Write("Mobil saya berwarna {0}", warna);
            Console.Write(" merek {0}", merek);
            Console.Write(" model {0}", model);
            Console.Write(" Keluaran tahun {0}", TahunKeluaran);
            Console.Write(" dengan jumlah pintu sebanyak {0}", JumlahPintu);
            Console.Write("\n");

        }

    }
}
