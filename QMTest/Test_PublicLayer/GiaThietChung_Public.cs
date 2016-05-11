using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class GiaThietChung_Public
    {
        int _IdGiaThietChung;

        public int IdGiaThietChung
        {
            get { return _IdGiaThietChung; }
            set { _IdGiaThietChung = value; }
        }
        string _NoiDung;
        

        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }

    }
}
