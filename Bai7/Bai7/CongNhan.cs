using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class CongNhan
    {
        private string _maCN, _mHo, _mTen;
        private int _mSoSP;

        public string MaCN 
        {
            get { return _maCN; }
            set { _maCN = value; }
        }
        public string MHo
        {
            get { return _mHo; }
            set { _mHo = value; }
        }
        public string MTen
        {
            get { return _mTen; }
            set { _mTen = value; }
        }
        public int MSoSP
        {
            get { return _mSoSP; }
            set { _mSoSP = value; }
        }
        public CongNhan()
        {
           
        }
        public CongNhan(string _maCN, string _mHo, string _mTen, int _mSoSP)
        {
            this._maCN = _maCN;
            this._mHo = _mHo;
            this._mTen = _mTen;
            this._mSoSP = _mSoSP;
        }

        public double tinhLuong()
        {
            if(_mSoSP>=1 && _mSoSP<=199)
            {
                return _mSoSP * 0.5;
            }
            else if(_mSoSP>=200 && _mSoSP<=399)
            {
                return _mSoSP * 0.55;
            }
            else if (_mSoSP >= 400 && _mSoSP <= 599)
            {
                return _mSoSP * 0.6;
            }
            return _mSoSP * 0.65;
        }
        public void toString()
        {
            Console.WriteLine("Nhap ma cong nhan: " + _maCN);
            Console.WriteLine("Thong tin cua cong nhan:" + _maCN, _mHo, _mTen, _mSoSP, tinhLuong());
        }
    }
}
