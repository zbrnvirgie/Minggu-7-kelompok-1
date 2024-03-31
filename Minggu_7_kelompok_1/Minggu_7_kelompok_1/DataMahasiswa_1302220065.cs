using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD07
{
    internal class DataMahasiswa_1302220065
    {
        public detail_name nama { set; get; }
        public string nim;
        public string fakultas { set; get; }

        public void getNama()
        {
            Console.WriteLine(this.nama);
        }

        public void getNim()
        {
            Console.WriteLine(nim);
        }

        public void getFalkultas()
        {
            Console.WriteLine("here");
            Console.WriteLine(fakultas);
        }

        public void details()
        {
            Console.Write("Nama : " + nama.depan + " " + nama.belakang);
            Console.Write(" , NIM : " + nim);
            Console.Write(" , Falkultas : " + fakultas);
        }
    }

    internal class detail_name
    {
        public string depan;
        public string belakang;
    }
}
