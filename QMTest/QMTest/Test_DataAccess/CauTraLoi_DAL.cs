using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_PublicLayer;
using System.Data;

namespace Test_DataAccess
{
    public class CauTraLoi_DAL
    {
        DataProvider dp = new DataProvider();
        public DataTable CauTraLoi_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("CauTraLoi_Select");
        }
        public int CauTraLoi_Insert(CauTraLoi_Public ctl)
        {
            const int Npar = 4;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@NoiDung1";
            obj[0] = ctl.NoiDung1;
            name[1] = "@DapAn";
            obj[1] = ctl.DapAn;
            name[2] = "@NoiDung2";
            obj[2] = ctl.NoiDung2;
            name[3] = "@CoDinh";
            obj[3] = ctl.CoDinh;
            return dp.SQL_Thuchien("CauTraLoi_Insert", name, obj, Npar);
        }
        public int CauTraLoi_Update(CauTraLoi_Public ctl, int IdLoaiCauHoi)
        {
            string[] name;
            object[] obj;
            int Npar;
            dp.KetnoiCSDL();
            if (IdLoaiCauHoi == 1)
            {
                Npar = 5;
                name = new string[Npar];
                obj = new object[Npar];
                name[0] = "@IdCauTraLoi";
                obj[0] = ctl.IdCauTraLoi;
                name[1] = "@NoiDung1";
                obj[1] = ctl.NoiDung1;
                name[2] = "@DapAn";
                obj[2] = ctl.DapAn;
                name[3] = "@CoDinh";
                obj[3] = ctl.CoDinh;
                name[4] = "@IdLoaiCauHoi";
                obj[4] = IdLoaiCauHoi;
                return dp.SQL_Thuchien("CauTraLoi_Update", name, obj, Npar);
            }
            else
                if (IdLoaiCauHoi == 2)
                {
                    Npar = 4;
                    name = new string[Npar];
                    obj = new object[Npar];
                    name[0] = "@IdCauTraLoi";
                    obj[0] = ctl.IdCauTraLoi;
                    name[1] = "@NoiDung1";
                    obj[1] = ctl.NoiDung1;
                    name[2] = "@DapAn";
                    obj[2] = ctl.DapAn;
                    name[3] = "@IdLoaiCauHoi";
                    obj[3] = IdLoaiCauHoi;
                    return dp.SQL_Thuchien("CauTraLoi_Update", name, obj, Npar);
                }
                else
                    if (IdLoaiCauHoi == 4)
                    {
                        Npar =4;
                        name = new string[Npar];
                        obj = new object[Npar];
                        name[0] = "@IdCauTraLoi";
                        obj[0] = ctl.IdCauTraLoi;
                        name[1] = "@NoiDung1";
                        obj[1] = ctl.NoiDung1;
                        name[2] = "@NoiDung2";
                        obj[2] = ctl.NoiDung2;
                        name[3] = "@IdLoaiCauHoi";
                        obj[3] = IdLoaiCauHoi;
                        return dp.SQL_Thuchien("CauTraLoi_Update", name, obj, Npar);
                    }
                    else
                        if ((IdLoaiCauHoi == 3)||(IdLoaiCauHoi == 6))
                        {
                            Npar = 3;
                            name = new string[Npar];
                            obj = new object[Npar];
                            name[0] = "@IdCauTraLoi";
                            obj[0] = ctl.IdCauTraLoi;
                            name[1] = "@NoiDung1";
                            obj[1] = ctl.NoiDung1;
                            name[2] = "@IdLoaiCauHoi";
                            obj[2] = IdLoaiCauHoi;
                            return dp.SQL_Thuchien("CauTraLoi_Update", name, obj, Npar);
                        }
            return 0;
        }
        public int CauTraLoi_Delete(CauTraLoi_Public ctl)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauTraLoi";
            obj[0] = ctl.IdCauTraLoi;
            return dp.SQL_Thuchien("CauTraLoi_Delete", name, obj, Npar);
        }
        public DataTable CauTraLoi_Select_IdCauHoi(CauTraLoi_Public ctl)
        {
            const int Npar = 1;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@IdCauHoi";
            obj[0] = ctl.CauHoi.IdCauHoi;
            return dp.SQL_Laydulieu("CauTraLoi_Select_IdCauHoi", name, obj, Npar);
        }
        public int CauTraLoi_Add(CauTraLoi_Public ctl)
        {
            const int Npar = 5;
            dp.KetnoiCSDL();
            string[] name = new string[Npar];
            object[] obj = new object[Npar];
            name[0] = "@NoiDung1";
            obj[0] = ctl.NoiDung1;
            name[1] = "@DapAn";
            obj[1] = ctl.DapAn;
            name[2] = "@NoiDung2";
            obj[2] = ctl.NoiDung2;
            name[3] = "@CoDinh";
            obj[3] = ctl.CoDinh;
            name[4] = "@IdCauHoi";
            obj[4] = ctl.CauHoi.IdCauHoi;
            return dp.SQL_Thuchien("CauTraLoi_Add", name, obj, Npar);
        }
    }
}
