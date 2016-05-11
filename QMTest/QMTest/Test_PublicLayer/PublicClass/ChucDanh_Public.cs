using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class ChucDanh_Public
    {
        string _IdChucDanh;

        public string IdChucDanh
        {
            get { return _IdChucDanh; }
            set { _IdChucDanh = value; }
        }
        string _TenChucDanh;

        public string TenChucDanh
        {
            get { return _TenChucDanh; }
            set { _TenChucDanh = value; }
        }
        string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        List<ChiTietChucDanh_Public> _ChiTietChucDanh;

        internal List<ChiTietChucDanh_Public> ChiTietChucDanh
        {
            get { return _ChiTietChucDanh; }
            set { _ChiTietChucDanh = value; }
        }
        public ChucDanh_Public()
        {
            _ChiTietChucDanh = new List<ChiTietChucDanh_Public>();
        }

    }
}
