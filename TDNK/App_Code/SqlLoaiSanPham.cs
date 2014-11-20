using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SqlLoaiSanPham
/// </summary>
public class SqlLoaiSanPham
{
	public SqlLoaiSanPham()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static DataTable LoadSanPham(string MaLoaiSP)
    {
        SqlParameter[] param = new SqlParameter[1];
        param[0] = new SqlParameter("@MaLoaiSP", MaLoaiSP);
        return DBAccess.GetDataTable("LoadLoaiSanPham", CommandType.StoredProcedure, param);
    }
}