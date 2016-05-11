using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class ChiTietChucVu_Public
    {
        GiaoVien_Public gv;

        public GiaoVien_Public Gv
        {
            get { return gv; }
            set { gv = value; }
        }
        ChucVu_Public cv;

        public ChucVu_Public Cv
        {
            get { return cv; }
            set { cv = value; }
        }
        public ChiTietChucVu_Public()
        {
            gv = new GiaoVien_Public();
            cv = new ChucVu_Public();
        }
    }
}
