using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Test_PublicLayer;


namespace Test_DataAccess
{
    public class MucTriNang_DAL
    {
        DataProvider dp=new DataProvider();
        public DataTable MucTriNang_Select()
        {
            dp.KetnoiCSDL();
            return dp.SQL_Laydulieu("MucTriNang_Select");
        }
        public int MucTriNang_Insert(MucTriNang_Public mtn)
        {
            dp.KetnoiCSDL();
            int Npara = 1;
            string[] name = new string[1];
            object[] value = new object[1];
            name[0] = "@TenMucTriNang";
            value[0] = mtn.TenMucTriNang;
            return dp.SQL_Thuchien("MucTriNang_Insert", name, value, Npara);
        }
        public int MucTriNang_Delete(MucTriNang_Public mtn)
        {
            dp.KetnoiCSDL();
            int Npara = 1;
            string[] name = new string[Npara];
            object[] value = new object[Npara];
            name[0] = "@IdMucTriNang";
            value[0] = int.Parse(mtn.IdMucTriNang);
            return dp.SQL_Thuchien("MucTriNang_Delete", name, value, Npara);
        }
        public int MucTriNang_Update_TenMucTriNang(MucTriNang_Public mtn)
        {
            dp.KetnoiCSDL();
            const int Npara = 2;
            string[] name = new string[Npara];
            object[] value = new object[Npara];
            name[0] = "@IdMucTriNang";
            value[0] = int.Parse(mtn.IdMucTriNang);
            name[1] = "@TenMucTriNang";
            value[1] = mtn.TenMucTriNang;
            return dp.SQL_Thuchien("MucTriNang_Update", name, value, Npara);
        }

    }
}
