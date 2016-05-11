using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;

namespace Test_PublicLayer
{
    public class ThongTinDuyet_Public
    {
        CauHoi_Public _cauHoi;

        public CauHoi_Public CauHoi
        {
            get { return _cauHoi; }
            set { _cauHoi = value; }
        }
        GiaoVien_Public _giaoVien;

        public GiaoVien_Public GiaoVien
        {
            get { return _giaoVien; }
            set { _giaoVien = value; }
        }
        public ThongTinDuyet_Public()
        {
            _cauHoi = new CauHoi_Public();
            _giaoVien = new GiaoVien_Public();
        }

    }
}
