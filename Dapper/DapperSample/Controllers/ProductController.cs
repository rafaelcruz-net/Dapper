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
    [RoutePrefix("Product")]
    public class ProductController : ApiController
    {
        private ProductRepository Repository { get; set; } = new ProductRepository();  

        [HttpGet]
        public IHttpActionResult Get() 
        {
            return Ok<List<Product>>(this.Repository.GetProducts());
        }

        [HttpGet]
        public IHttpActionResult Get(int productId) 
        {
            return Ok<Product>(this.Repository.GetProductById(productId));
        }

        [HttpGet]
        public IHttpActionResult GetProductBySupplier(int supplierId) 
        {
            return Ok<List<Product>>(this.Repository.GetProductBySupplier(supplierId));
        }
    }
}
