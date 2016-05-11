using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class Quyen
    {
        string _tenQuyen;
        int _idquyen;

        public int IdQuyen
        {
            get { return _idquyen; }
            set { _idquyen = value; }
        }
        public string TenQuyen
        {
            get { return _tenQuyen; }
            set { _tenQuyen = value; }
        }

    }
}
