using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DBAccess
/// </summary>
public class DBAccess
{
    public static String cnnstr = @"Data Source=CHUONG-PC\SQLEXPRESS;Initial Catalog=thaoduoc;Persist Security Info=True;User ID=sa;Password=123456";
    //public static String cnnstr = "workstation id=thaoduoc.mssql.somee.com;packet size=4096;user id=thaoduocnhapkhau_SQLLogin_1;pwd=tqqth4vz1g;data source=thaoduoc.mssql.somee.com;persist security info=False;initial catalog=thaoduoc";
    public DBAccess()
    {
        
    }
    public static bool ExecQuery(string query)
    {
        bool res = false;
        return res;
    }

    public  static DataTable GetDataTable(string query)
    {
        DataTable dataTable = new DataTable();
        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cnnstr);
        dataAdapter.Fill(dataTable);
        return dataTable;
    }

    public static DataTable GetDataTable(string sql, CommandType commandType, SqlParameter[] parameters)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(cnnstr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = commandType;
                    foreach (SqlParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }

                    
                    cmd.CommandTimeout = 3600;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public static int ExecuteNonQuery(string commandText, SqlParameter[] parameters)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(cnnstr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    foreach (SqlParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public static int ExecuteNonQuery(string commandText)
    {
        SqlConnection con = new SqlConnection(cnnstr);
        con.Open();
        SqlCommand cmd = new SqlCommand(commandText, con);
        int rowsAffected = cmd.ExecuteNonQuery();
        return rowsAffected;
    }
    public static bool ExecuteCheck(string commandText, SqlParameter[] parameters)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(cnnstr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    foreach (SqlParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public static bool ExecuteCheck(string commandText)
    {
        try
        {
            SqlConnection con = new SqlConnection(cnnstr);
            con.Open();
            SqlCommand cmd = new SqlCommand(commandText, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                return true;
            else
                return false;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public static int CallProc(string commandText, SqlParameter[] parameters)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(cnnstr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public static void GetDataSource(string query, DataTable dt)
    {

        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, cnnstr);
        dataAdapter.Fill(dt);
    }
}