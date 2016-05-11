using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class ToBoMon_Public
    {
        int _IdToBoMon;

        public int IdToBoMon
        {
            get { return _IdToBoMon; }
            set { _IdToBoMon = value; }
        }
        string _TenToBoMon;

        public string TenToBoMon
        {
            get { return _TenToBoMon; }
            set { _TenToBoMon = value; }
        }
        string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        Khoa_Public _khoa;

        public Khoa_Public Khoa
        {
            get { return _khoa; }
            set { _khoa = value; }
        }
        public ToBoMon_Public()
        {
            _khoa = new Khoa_Public();
        }
    }
}
