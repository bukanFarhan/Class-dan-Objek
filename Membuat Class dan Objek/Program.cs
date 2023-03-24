using System;

namespace Membuat_Class_dan_Objek
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            Mobil mobil2 = new Mobil();
            Mobil mobil3 = new Mobil();

            mobil1.warna = "Hitam";
            mobil1.JumlahPintu = 4;
            mobil1.merek = "Toyota";
            mobil1.model = "Kijang Innova";
            mobil1.TahunKeluaran = 2018;
            mobil1.kecepatan = 2000;
            mobil1.suara = "Embeeeee...";

            mobil1.Gas();
            mobil1.Klakson();
            mobil1.TampilkanInfo();
        }
    }
}
