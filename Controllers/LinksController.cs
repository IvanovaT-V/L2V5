using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using L2V5.Models;

namespace L2V5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        private readonly IRepository _context ;
        public LinksController(IRepository context)
        {
            _context = context;
            
        }

        // GET: api/Links
        [HttpGet(Name = "GetLinks")]
        public  IEnumerable<Link> GetLinks()
        {
            return _context.Get();
        }

        // GET: api/Links/5
        [HttpGet("{id}", Name = "GetLink")]
        public ActionResult<Link> GetLink(long id)
        {
            var link = _context.Get(id);

            if (link == null)
            {
                return NotFound();
            }

            return new ObjectResult(link); ;
        }

        // PUT: api/Links/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Link link)
        {
            if (id != link.Id| link == null)
            {
                return BadRequest();
            }
            var l = _context.Get(id);
            if (l == null)
            {
                return NotFound();
            }
            _context.Update(link);
                           
            return RedirectToRoute("Getlinks") ;
        }

     
        [HttpPost]
        public ActionResult Create([FromBody] Link link)
        {
            _context.Create(link);
            return CreatedAtRoute("GetLink", new { id = link.Id }, link);
        }

        // DELETE: api/Links/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var link =  _context.Delete(id);
            if (link == null)
            {
                return NotFound();
            }          

            return new ObjectResult(link); ;
        }

       
    }
}
