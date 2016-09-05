using DapperSample.Model;
using DapperSample.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DapperSample.Controllers
{
    public class SupplierController : ApiController
    {
        private SupplierRepository Repository { get; set; } = new SupplierRepository();

        [HttpPost]
        public IHttpActionResult Post(Supplier model) 
        {
            this.Repository.Save(model);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(Supplier model) 
        {
            this.Repository.Update(model);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(Supplier model) 
        {
            this.Repository.Delete(model);
            return Ok();
        }
    }
}
