using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class HinhTron
    {
        public ToaDo tam;
        public double banKinh;

        public ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }

        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }

        public HinhTron(ToaDo tam, double bankinh)
        {
            this.tam = tam;
            this.banKinh = bankinh;
        }

        public HinhTron() { }

        public double tinhDienTich()
        {
            return BanKinh * BanKinh * 3.14;
        }

        public double tinhChuVi()
        {
            return BanKinh * 2 * 3.14;
        }

    }
}
