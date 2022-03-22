using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Npgsql;
namespace RestfullDEMO.Models
{
    public class CRUD
    {

        Chaine c  = new Chaine();

        // To Get All Data From TABLE
        public DataTable GetData()
        {
            c.OpenCN();
            c.cmd = new NpgsqlCommand("select * from _TableName", c.cnx);
            c.da = new  NpgsqlDataAdapter(c.cmd);
            DataTable dt = new DataTable();
            c.da.Fill(dt);
            c.CloseCN();
            return dt;
        }
        // To Get Data From TABLE By ID
        public DataTable GetDataByID(int id)
        {
            c.OpenCN();
            c.cmd = new NpgsqlCommand($"select * from _TableName where _ID_Field = {id} ", c.cnx);
            c.da = new NpgsqlDataAdapter(c.cmd);
            DataTable dt = new DataTable();
            c.da.Fill(dt);
            c.CloseCN();
            return dt;
        }

        // To Get Data From TABLE By Query
        public DataTable GetDataByQuery(string Query)
        {
            c.OpenCN();
            c.cmd = new NpgsqlCommand(Query, c.cnx);
            c.da = new NpgsqlDataAdapter(c.cmd);
            DataTable dt = new DataTable();
            c.da.Fill(dt);
            c.CloseCN();
            return dt;
        }

        // To Delete Data From TABLE By ID
        public bool DeleteDataByID(int id )
        {
            try
            {
                c.OpenCN();
                c.cmd = new NpgsqlCommand($"delete from _TableName where _ID_Field = {id} ", c.cnx);
                c.cmd.ExecuteNonQuery();
                c.CloseCN();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // To Update Data in TABLE By ID
        public bool UpdateDataByID(int id)
        {
            try
            {
                c.OpenCN();
                c.cmd = new NpgsqlCommand($"Update _TableName set _Update_Field = _Update_Value where _ID_Field = {id} ", c.cnx);
                c.cmd.ExecuteNonQuery();
                c.CloseCN();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}