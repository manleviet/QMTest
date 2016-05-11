using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class SystemLog_Public
    {
        public SystemLog_Public()
        {
            gv = new GiaoVien_Public();
        }
        string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
        GiaoVien_Public gv;

        public GiaoVien_Public Gv
        {
            get { return gv; }
            set { gv = value; }
        }
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _thoiGian;

        public string ThoiGian
        {
            get { return _thoiGian; }
            set { _thoiGian = value; }
        }
        string _tuNgay;

        public string TuNgay
        {
            get { return _tuNgay; }
            set { _tuNgay = value; }
        }
        string _denNgay;

        public string DenNgay
        {
            get { return _denNgay; }
            set { _denNgay = value; }
        }
    }
}
