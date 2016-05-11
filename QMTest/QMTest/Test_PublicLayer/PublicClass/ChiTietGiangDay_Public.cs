using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class ChiTietGiangDay_Public
    {
        MonHoc_Public _MonHoc;

        public MonHoc_Public MonHoc
        {
            get { return _MonHoc; }
            set { _MonHoc = value; }
        }
        GiaoVien_Public _GiaoVien;

        public GiaoVien_Public GiaoVien
        {
            get { return _GiaoVien; }
            set { _GiaoVien = value; }
        }
        DateTime _NgayBatDau;

        public DateTime NgayBatDau
        {
            get { return _NgayBatDau; }
            set { _NgayBatDau = value; }
        }
        DateTime _NgayKetThuc;

        public DateTime NgayKetThuc
        {
            get { return _NgayKetThuc; }
            set { _NgayKetThuc = value; }
        }
        public ChiTietGiangDay_Public()
        {
            _MonHoc = new MonHoc_Public();
            _GiaoVien = new GiaoVien_Public();
        }

    }
}
