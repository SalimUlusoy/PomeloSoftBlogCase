using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PomeloSoftBlogCaseWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PomeloSoftBlogCaseWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        PomelosoftblogcasewebapiContext db = new PomelosoftblogcasewebapiContext();

        [HttpGet]
        [Route("GetApiDataList")]
        public IEnumerable<TblBlogYazi> GetApiDataList()
        {

            return db.TblBlogYazi.ToList();
        }

        [HttpGet]
        [Route("GetApiDataListOrderByTarih")]
        public IEnumerable<TblBlogYazi> GetApiDataListOrderByTarih()
        {
            return db.TblBlogYazi.OrderByDescending(x => x.Tarih).ToList();
        }

        [HttpGet]
        [Route("GetApiDataListOrderByOkunmaSayisi")]
        public IEnumerable<TblBlogYazi> GetApiDataListOrderByOkunmaSayisi()
        {
            return db.TblBlogYazi.OrderByDescending(x => x.GirisSayisi).ToList();
        }

        [HttpGet]
        [Route("GetApiDataListById")]
        public TblBlogYazi GetOwnerById(int BlogId)
        {
            return db.TblBlogYazi.Where(u => u.Id.Equals(BlogId)).FirstOrDefault();
        }

        [HttpPost]
        public IActionResult Create([FromBody] TblBlogYazi item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            db.TblBlogYazi.Add(item);
            db.SaveChanges();

            return CreatedAtRoute("GetById", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] TblBlogYazi item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var supplier = db.TblBlogYazi.FirstOrDefault(t => t.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }

            supplier.Baslik = item.Baslik;
            supplier.Aciklama = item.Aciklama;
            supplier.Resim = item.Resim;
            supplier.Tarih = item.Tarih;

            db.TblBlogYazi.Update(supplier);
            db.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var supplier = db.TblBlogYazi.FirstOrDefault(t => t.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }

            db.TblBlogYazi.Remove(supplier);
            db.SaveChanges();
            return new NoContentResult();
        }
    }
}
