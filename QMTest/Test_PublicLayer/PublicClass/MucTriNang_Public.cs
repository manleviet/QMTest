using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class MucTriNang_Public
    {
        string _IdMucTriNang;

        public string IdMucTriNang
        {
            get { return _IdMucTriNang; }
            set { _IdMucTriNang = value; }
        }
        string _TenMucTriNang;

        public string TenMucTriNang
        {
            get { return _TenMucTriNang; }
            set { _TenMucTriNang = value; }
        }

    }
}
