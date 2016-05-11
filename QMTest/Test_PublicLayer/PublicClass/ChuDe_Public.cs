using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class ChuDe_Public
    {
        int _IdChuDe;

        public int IdChuDe
        {
            get { return _IdChuDe; }
            set { _IdChuDe = value; }
        }
        string _TenChuDe;

        public string TenChuDe
        {
            get { return _TenChuDe; }
            set { _TenChuDe = value; }
        }
        Chuong_Public _ch;

        public Chuong_Public Chuong
        {
            get { return _ch; }
            set { _ch = value; }
        }

        public ChuDe_Public()
        {
            _ch = new Chuong_Public();
        }
        string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }

    }
}
