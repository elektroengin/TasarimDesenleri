using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternV4
{
    /// <summary>
    /// Product sınıfımız olacak inşaa edecek sınıfım olacak
    /// </summary>
    public class Promosyon
    {
        public string UrunAdi { get; set; }
        public int PromosyonNumarasi { get; set; }
        public string CalisanProfili { get; set; }
        public override string ToString()
        {
            Console.WriteLine(
                $"{PromosyonNumarasi} numaralı {UrunAdi} promosyonu {CalisanProfili} çalışanlarına verilmiştir.");
            return "";
        }
    }
}
