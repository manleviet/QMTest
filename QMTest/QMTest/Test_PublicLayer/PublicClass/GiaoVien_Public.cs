using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class GiaoVien_Public
    {
        #region "Variables"
        int _IdGiaoVien;
        string _TenGiaoVien; 
        string _TaiKhoan;    
        string _MatKhau;   
        string _IdToBoMon;     
        DateTime _NgaySinh;
        string _DiaChi="";  
        string _SoDienThoai;
        bool _TrangThai;
        ToBoMon_Public _toBoMon;
        string _ghiChu;
        byte[] _image;
        Quyen _quyen;
        string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Quyen Quyen
        {
            get { return _quyen; }
            set { _quyen = value; }
        }

        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public ToBoMon_Public ToBoMon
        {
            get { return _toBoMon; }
            set { _toBoMon = value; }
        }
        public GiaoVien_Public()
        {
            _toBoMon = new ToBoMon_Public();
            _image = null;
            _quyen = new Quyen();
        }
        #endregion

        #region "Properties"
        public string SoDienThoai
        {
            get { return _SoDienThoai; }
            set { _SoDienThoai = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public string IdToBoMon
        {
            get { return _IdToBoMon; }
            set { _IdToBoMon = value; }
        }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        public string TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }
        public int IdGiaoVien
        {
            get { return _IdGiaoVien; }
            set { _IdGiaoVien = value; }
        }
        public string TenGiaoVien
        {
            get { return _TenGiaoVien; }
            set { _TenGiaoVien = value; }
        }
        public bool TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
        #endregion

        #region "Methods"
        #endregion

    }
}
