using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo td = new ToaDo(5,5);
            //Console.WriteLine("Nhap toa do:", td.x, td.y);
            //td.x = float.Parse(Console.ReadLine());
            //td.y = float.Parse(Console.ReadLine());

            HinhTron ht = new HinhTron(td,10.5);
            Console.WriteLine("Hinh tron co tam O voi ban kinh {1} co dien tich va chu vi lan luot la {2} và {3}", ht.tam, ht.BanKinh, Math.Round(ht.tinhDienTich(), 2), Math.Round(ht.tinhChuVi(), 3));
            Console.ReadKey();
                
        }
    }
}
