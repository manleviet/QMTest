using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class LoaiCauHoi_Public
    {
        int _IdLoaiCauHoi;

        public int IdLoaiCauHoi
        {
            get { return _IdLoaiCauHoi; }
            set { _IdLoaiCauHoi = value; }
        }
        string _TenLoaiCauHoi;

        public string TenLoaiCauHoi
        {
            get { return _TenLoaiCauHoi; }
            set { _TenLoaiCauHoi = value; }
        }
        string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
    }
}
