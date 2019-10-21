using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplateApi.Data;
using BoilerplateApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context) => _context = context;
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Value>> Get()
        {
            return _context.Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Value> Get(int id)
        {
            var valueitem = _context.Values.Find(id);
            return valueitem;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Value> Post([FromBody] Value value)
        {
            //var isi = new Value();
            //isi.Name = "cihui";

            //_context.Values.Add(isi);
            //_context.SaveChanges();
            //return "berhasil";
            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
