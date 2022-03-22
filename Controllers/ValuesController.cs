using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using RestfullDEMO.Models;

namespace RestfullDEMO.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<DataRow> Get()
        {
            CRUD cr = new CRUD();   
            return cr.Load_data().AsEnumerable();
        }

        // GET api/values/5

        [Route("values/{idr?}/{idc?}")]
        public IEnumerable<DataRow> Get(int? idr = null, int? idc = null)
        {

            string Query = $"select * from personne where ID_contry = {idr} and ID_city = {idc}";
            
            CRUD cr = new CRUD();
            return cr.GetDataWithQuery(Query).AsEnumerable();

        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            return "perfecto";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            //
            //
        }

        [HttpDelete]
        // DELETE api/values/5
        public string msah(int id)
        {
            CRUD cr = new CRUD();
            if(cr.delete_personne(id)==true)
            {
                return "Personne Deleted.";
            }
            else 
            {
                return "Error Deleting !";
            }
        }
    }
}
