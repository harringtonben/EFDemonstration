using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EFDemonstration.Models;

namespace EFDemonstration.Controllers
{
    public class FarmsController : ApiController
    {
        private AppDbContext db = new AppDbContext();

        // GET: api/Farms
        public IQueryable<Farm> GetFarms()
        {
            return db.Farms;
        }

        // GET: api/Farms/5
        [ResponseType(typeof(Farm))]
        public IHttpActionResult GetFarm(int id)
        {
            Farm farm = db.Farms.Find(id);
            if (farm == null)
            {
                return NotFound();
            }

            return Ok(farm);
        }

        // PUT: api/Farms/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFarm(int id, Farm farm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != farm.Id)
            {
                return BadRequest();
            }

            db.Entry(farm).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FarmExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Farms
        [ResponseType(typeof(Farm))]
        public IHttpActionResult PostFarm(Farm farm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Farms.Add(farm);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = farm.Id }, farm);
        }

        // DELETE: api/Farms/5
        [ResponseType(typeof(Farm))]
        public IHttpActionResult DeleteFarm(int id)
        {
            Farm farm = db.Farms.Find(id);
            if (farm == null)
            {
                return NotFound();
            }

            db.Farms.Remove(farm);
            db.SaveChanges();

            return Ok(farm);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FarmExists(int id)
        {
            return db.Farms.Count(e => e.Id == id) > 0;
        }
    }
}