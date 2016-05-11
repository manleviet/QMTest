using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class Chuong_Public
    {
        int _IdChuong;
        string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }

        public int IdChuong
        {
            get { return _IdChuong; }
            set { _IdChuong = value; }
        }
        string _TenChuong;

        public string TenChuong
        {
            get { return _TenChuong; }
            set { _TenChuong = value; }
        }
        MonHoc_Public _mh;

        public MonHoc_Public Mh
        {
            get { return _mh; }
            set { _mh = value; }
        }
        public Chuong_Public()
        {
            _mh = new MonHoc_Public();
            _MoTa = null;
            _TenChuong = null;
        }

    }
}
