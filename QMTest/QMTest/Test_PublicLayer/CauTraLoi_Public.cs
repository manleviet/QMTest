using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_PublicLayer
{
    public class CauTraLoi_Public
    {
        int _idCauTraLoi;
        CauHoi_Public _cauHoi;

        public CauHoi_Public CauHoi
        {
            get { return _cauHoi; }
            set { _cauHoi = value; }
        }
        public int IdCauTraLoi
        {
            get { return _idCauTraLoi; }
            set { _idCauTraLoi = value; }
        }
        int _idCauHoi;

        public int IdCauHoi
        {
            get { return _idCauHoi; }
            set { _idCauHoi = value; }
        }
        string _noiDung1;

        public string NoiDung1
        {
            get { return _noiDung1; }
            set { _noiDung1 = value; }
        }
        string _noiDung2;

        public string NoiDung2
        {
            get { return _noiDung2; }
            set { _noiDung2 = value; }
        }
        Boolean _DapAn;
        Boolean _coDinh;

        public Boolean CoDinh
        {
            get { return _coDinh; }
            set { _coDinh = value; }
        }

        public Boolean DapAn
        {
            get { return _DapAn; }
            set { _DapAn = value; }
        }

        public CauTraLoi_Public()
        {
            _noiDung2 = null;
            //_noiDung1 = null;
            _cauHoi = new CauHoi_Public();
        }

    }
}
