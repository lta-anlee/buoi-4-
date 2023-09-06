using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class ToaDo
    {
        public string ten;
        public float x, y;

        public ToaDo(String Ten)
        {
            this.ten = Ten;
        }
        public ToaDo( float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public ToaDo()
        {

        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
