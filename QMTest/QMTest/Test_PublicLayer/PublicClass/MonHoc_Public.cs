using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class MonHoc_Public
    {
        ToBoMon_Public _ToBoMon;

        public ToBoMon_Public ToBoMon
        {
            get { return _ToBoMon; }
            set { _ToBoMon = value; }
        }
        int _IdMonHoc;
       
        public int IdMonHoc
        {
            get { return _IdMonHoc; }
            set { _IdMonHoc = value; }
        }
        string _TenMonHoc;

        public string TenMonHoc
        {
            get { return _TenMonHoc; }
            set { _TenMonHoc = value; }
        }
        string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        public MonHoc_Public()
        {
            _ToBoMon = new ToBoMon_Public();
        }

      
        
        
        
    }
}
