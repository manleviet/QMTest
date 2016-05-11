using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class PhanQuyenNhapCauHoi_Public
    {
        GiaoVien_Public gv;

        public GiaoVien_Public Gv
        {
            get { return gv; }
            set { gv = value; }
        }
        MaTranKienThuc_Public mtkt;

        public MaTranKienThuc_Public Mtkt
        {
            get { return mtkt; }
            set { mtkt = value; }
        }
        int _SoCauPhaiNhap;

        public int SoCauPhaiNhap
        {
            get { return _SoCauPhaiNhap; }
            set { _SoCauPhaiNhap = value; }
        }
        int _SoCauDaNhap;

        public int SoCauDaNhap
        {
            get { return _SoCauDaNhap; }
            set {
                if (SoCauDaNhap.ToString()==null)
                    SoCauDaNhap = 0;
                else _SoCauDaNhap = value; 
            }
        }
        public PhanQuyenNhapCauHoi_Public()
        {
            gv = new GiaoVien_Public();
            mtkt = new MaTranKienThuc_Public();
            _SoCauDaNhap = 0;
            _SoCauPhaiNhap = 0;
        }

    }
}
