using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class ChiTietChucDanh_Public
    {
        DateTime _ThoiDiem;

        public DateTime ThoiDiem
        {
            get { return _ThoiDiem; }
            set { _ThoiDiem = value; }
        }
        GiaoVien_Public _GiaoVien;

        public GiaoVien_Public GiaoVien
        {
            get { return _GiaoVien; }
            set { _GiaoVien = value; }
        }
        ChucDanh_Public _ChucDanh;

        public ChucDanh_Public ChucDanh
        {
            get { return _ChucDanh; }
            set { _ChucDanh = value; }
        }
        public ChiTietChucDanh_Public()
        {
            _GiaoVien = new GiaoVien_Public();
            _ChucDanh = new ChucDanh_Public();
        }

        

      


    }
}
