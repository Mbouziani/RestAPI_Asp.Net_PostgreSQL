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
        // init Connection String
        public NpgsqlConnection cnx = new NpgsqlConnection("_Connection_String_Url");

        // init Npgsql method to deal with NpgsqlDB
        public NpgsqlCommand cmd = new NpgsqlCommand();
        public NpgsqlDataAdapter da;
        public NpgsqlDataReader dr;


        // Check Connection State To Open it
        public void OpenConnection ()
        {
            if(cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.Open();
            }
        }

        // Check Connection State To Close it
        public void CloseConnection()
        {
            if (cnx.State == ConnectionState.Open )
            {
                cnx.Close();
            }
        }

    }
}