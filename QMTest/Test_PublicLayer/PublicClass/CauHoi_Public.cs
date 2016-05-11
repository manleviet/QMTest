using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class CauHoi_Public
    {
        string _noiDung;
        int _idCauHoi;
        MonHoc_Public _mh;

        public MonHoc_Public Mh
        {
            get { return _mh; }
            set { _mh = value; }
        }

 
        public int IdCauHoi
        {
            get { return _idCauHoi; }
            set { _idCauHoi = value; }
        }
        GiaThietChung_Public _gtc;

        public GiaThietChung_Public Gtc
        {
            get { return _gtc; }
            set { _gtc = value; }
        }
        LoaiCauHoi_Public _lch;

        public LoaiCauHoi_Public Lch
        {
            get { return _lch; }
            set { _lch = value; }
        }
        MaTranKienThuc_Public _mtkt;

        public MaTranKienThuc_Public Mtkt
        {
            get { return _mtkt; }
            set { _mtkt = value; }
        }
        GiaoVien_Public _gv;

        public GiaoVien_Public Gv
        {
            get { return _gv; }
            set { _gv = value; }
        }
        DoKho_Public _dk;

        public DoKho_Public Dk
        {
            get { return _dk; }
            set { _dk = value; }
        }
        string _doPhanCach;

        public string DoPhanCach
        {
            get { return _doPhanCach; }
            set { _doPhanCach = value; }
        }
        DateTime _ngayTao;

        public DateTime NgayTao
        {
            get { return _ngayTao; }
            set { _ngayTao = value; }
        }
        DateTime _ngayCapNhat;

        public DateTime NgayCapNhat
        {
            get { return _ngayCapNhat; }
            set { _ngayCapNhat = value; }
        }
         
        public string NoiDung
        {
            get { return _noiDung; }
            set { _noiDung = value; }
        }
        public CauHoi_Public()
        {
            _gtc = new GiaThietChung_Public();
            _lch = new LoaiCauHoi_Public();
            _mtkt = new MaTranKienThuc_Public();
            _gv = new GiaoVien_Public();
            _dk = new DoKho_Public();
            _mh = new MonHoc_Public();

        }

    }
}
