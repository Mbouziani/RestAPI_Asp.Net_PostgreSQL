using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using System.Data;
namespace RestfullDEMO
{
    public class Chaine
    {
        public NpgsqlConnection cnx = new NpgsqlConnection("_Connection_String_Url");

        public NpgsqlCommand cmd = new NpgsqlCommand();

        public NpgsqlDataAdapter da;

        public NpgsqlDataReader dr;


        public void OpenCN ()
        {
            if(cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.Open();
            }
        }
        public void CloseCN()
        {
            if (cnx.State == ConnectionState.Open )
            {
                cnx.Close();
            }
        }

    }
}