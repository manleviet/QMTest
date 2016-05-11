using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class ChucVu_Public
    {
        string _IdChucVu;

        public string IdChucVu
        {
            get { return _IdChucVu; }
            set { _IdChucVu = value; }
        }
        string _TenChucVu;

        public string TenChucVu
        {
            get { return _TenChucVu; }
            set { _TenChucVu = value; }
        }
        string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        List<ChiTietChucVu_Public> _listCTCV;

        public List<ChiTietChucVu_Public> ListCTCV
        {
            get { return _listCTCV; }
            set { _listCTCV = value; }
        }
        public ChucVu_Public()
        {
            _listCTCV = new List<ChiTietChucVu_Public>();
        }

    }
}
