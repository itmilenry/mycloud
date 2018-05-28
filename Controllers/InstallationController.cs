using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mycloud.Models;

namespace mycloud.Controllers
{
    [Route("api/[controller]")]
    public class InstallationController : Controller
    {
        // GET api/values
        [HttpGet]
        public IQueryable<Installation1> Get()
        {
            var context = new Models.mycloudContext();
            var objResult = context.Installation1s;
            return objResult;
        }

        [HttpGet("{id}")]
        public IEnumerable<Installation2> Get(int id)
        {
            var context = new Models.mycloudContext();
            var objResult = context.LinkCableInstallations.Where( i => i.Installation1Id == id ).Select( y => y.Installation2);
            return objResult;
        }

        [HttpGet("{id1}/{id2}")]
        public IEnumerable<Installation3> Get(int id1, int id2)
        {
            var context = new Models.mycloudContext();
            var objResult = context.LinkCableInstallations.Where( i => i.Installation1Id == id1 ).Where( i => i.Installation2Id == id2 ).Select( y => y.Installation3);
            return objResult;
        }


        // GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
