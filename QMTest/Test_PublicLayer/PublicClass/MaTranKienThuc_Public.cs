using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class MaTranKienThuc_Public
    {
        string _IdMaTranKienThuc;
        int _SoCauNhap;

        public int SoCauNhap
        {
            get { return _SoCauNhap; }
            set { _SoCauNhap = value; }
        }
        int _SoCauQuyDinh;

        public int SoCauQuyDinh
        {
            get { return _SoCauQuyDinh; }
            set { _SoCauQuyDinh = value; }
        }

        public string IdMaTranKienThuc
        {
            get { return _IdMaTranKienThuc; }
            set { _IdMaTranKienThuc = value; }
        }
        MucKienThuc_Public _mkt;

        public MucKienThuc_Public Mkt
        {
            get { return _mkt; }
            set { _mkt = value; }
        }
        MucTriNang_Public _mtn;

        public MucTriNang_Public Mtn
        {
            get { return _mtn; }
            set { _mtn = value; }
        }
        public MaTranKienThuc_Public()
        {
            _mtn =new MucTriNang_Public();
            _mkt=new MucKienThuc_Public();
            SoCauNhap = 0;
            SoCauQuyDinh = 0;
        }

    }
}
