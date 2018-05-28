using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mycloud.Models;

namespace mycloud.Controllers
{
    [Route("api/[controller]")]
    public class CatalogueController : Controller
    {
        [HttpGet]
        public IQueryable<Product> Get()
        {
            var context = new Models.mycloudContext();
            var objResult = context.Products ;
            return objResult;
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var context = new Models.mycloudContext();
            var objResult = context.Products.Where( i => i.ProductId == id).FirstOrDefault() ;
            return objResult;
        }

        [HttpGet("{inst1}/{inst2}/{inst3}")]
        public IQueryable<Product> Get(int inst1, int inst2, int inst3)
        {
            var context = new Models.mycloudContext();
            var objResult = context.LinkCableInstallations
                .Where(  i => i.Installation1Id == inst1 &&  i.Installation2Id == inst2 &&  i.Installation3Id == inst3  )
                .Select( j => j.Product ) ;
            return objResult;
        }

    }
}
