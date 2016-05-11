using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class MucKienThuc_Public
    {
        string _IdMucKienThuc;
        string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }

        public string IdMucKienThuc
        {
            get { return _IdMucKienThuc; }
            set { _IdMucKienThuc = value; }
        }
        string _TenMucKienThuc;

        public string TenMucKienThuc
        {
            get { return _TenMucKienThuc; }
            set { _TenMucKienThuc = value; }
        }
        ChuDe_Public _cd;

        public ChuDe_Public Cd
        {
            get { return _cd; }
            set { _cd = value; }
        }
        public MucKienThuc_Public()
        {
            _cd = new ChuDe_Public();
        }
        
    }
}
