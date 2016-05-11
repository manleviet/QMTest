using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class ChiTietQuyen_Public
    {
        GiaoVien_Public _giaoVien;

        public GiaoVien_Public GiaoVien
        {
            get { return _giaoVien; }
            set { _giaoVien = value; }
        }
        Quyen _quyen;

        public Quyen Quyen
        {
            get { return _quyen; }
            set { _quyen = value; }
        }
        public ChiTietQuyen_Public()
        {
            _giaoVien = new GiaoVien_Public();
            _quyen = new Quyen();
        }
    }
}
