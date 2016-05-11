using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class DoKho_Public
    {
        string _IdDoKho;

        public string IdDoKho
        {
            get { return _IdDoKho; }
            set { _IdDoKho = value; }
        }
        string _TenDoKho;

        public string TenDoKho
        {
            get { return _TenDoKho; }
            set { _TenDoKho = value; }
        }

    }
}
