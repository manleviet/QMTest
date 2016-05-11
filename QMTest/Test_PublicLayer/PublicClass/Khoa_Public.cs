using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class Khoa_Public
    {
    #region "Variable"
        int _IdKhoa;
        string _TenKhoa;
        string _MoTa;
    #endregion
#region "Properties"
         public int IdKhoa
        {
            get { return _IdKhoa; }
            set { _IdKhoa = value; }
        }
         public string TenKhoa
        {
            get { return _TenKhoa; }
            set { _TenKhoa = value; }
        }
         public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }     
#endregion
    #region "Methods"
        public Khoa_Public()
        {
            _TenKhoa = "";
            _MoTa = "";
        }
        public Khoa_Public(string TK,string MT)
        {
            TenKhoa = TK;
            MoTa = MT;
        }
    #endregion


    }
}
