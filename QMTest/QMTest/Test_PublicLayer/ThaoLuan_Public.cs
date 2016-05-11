using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class ThaoLuan_Public
    {
        int _idThaoLuan;

        public int IdThaoLuan
        {
            get { return _idThaoLuan; }
            set { _idThaoLuan = value; }
        }
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
        string _noiDung;

        public string NoiDung
        {
            get { return _noiDung; }
            set { _noiDung = value; }
        }
        public ThaoLuan_Public()
        {
            _cauHoi = new CauHoi_Public();
            _giaoVien = new GiaoVien_Public();
        }
    }
}
