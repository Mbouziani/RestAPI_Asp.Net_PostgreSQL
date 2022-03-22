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


        public DataTable Load_data()
        {
            c.OpenCN();
            c.cmd = new NpgsqlCommand("select * from _TableName", c.cnx);
            c.da = new  NpgsqlDataAdapter(c.cmd);
            DataTable dt = new DataTable();
            c.da.Fill(dt);
            c.CloseCN();

            return dt;
        }

        public DataTable Load_data_with(int id)
        {
            c.OpenCN();
            c.cmd = new NpgsqlCommand($"select * from _TableName where _ID_Field = {id} ", c.cnx);
            c.da = new NpgsqlDataAdapter(c.cmd);
            DataTable dt = new DataTable();
            c.da.Fill(dt);

            c.CloseCN();

            return dt;
        }
        public DataTable GetDataWithQuery(string Query)
        {
            c.OpenCN();
            c.cmd = new NpgsqlCommand(Query, c.cnx);
            c.da = new NpgsqlDataAdapter(c.cmd);
            DataTable dt = new DataTable();
            c.da.Fill(dt);

            c.CloseCN();

            return dt;
        }

        public bool delete_personne(int id )
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
        public bool update_personne(int id)
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