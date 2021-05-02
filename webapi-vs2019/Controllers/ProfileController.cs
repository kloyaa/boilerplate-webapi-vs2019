using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi_vs2019.Models;

namespace webapi_vs2019.Controllers
{
    // [Authorize]
    public class ProfileController : ApiController
    {
        dbContext _db = new dbContext();

        [HttpPost]
        [Route("api/profile")]
        public IHttpActionResult Create(Profile profile)
        {
            _db.Profiles.Add(profile);
            _db.SaveChanges();
            return Ok(profile);
        }

        [HttpGet]
        [Route("api/profile/{Id}")]
        public IHttpActionResult GetByUniqueId(string Id)
        {
            var result = _db.Profiles.Where(x => x.UniqueId == Id).ToList().Take(1);
            if (result != null && result.Count() >= 1)
                return Ok(result.ElementAt(0));
            else
                return BadRequest("Result not found");
        }

        [HttpDelete]
        [Route("api/profile/{Id}")]
        public IHttpActionResult Delete(int Id)
        {
            var result = _db.Profiles.Find(Id);
            if (result != null)
            {
                _db.Profiles.Remove(result);
                _db.SaveChanges();
                return Ok("Removed successfully!");
            }
            else
                return BadRequest("Result not found");
        }

        [HttpPut]
        [Route("api/profile/update")]
        public IHttpActionResult Update(Profile profile)
        {
            var result = _db.Profiles.Where(x => x.UniqueId == profile.UniqueId).ToList().Take(1);

            if (result != null && result.Count() >= 1)
            {
                var _profile = result.ElementAt(0);
                _profile.FirstName = profile.FirstName;
                _profile.LastName = profile.LastName;
                _profile.Gender = profile.Gender;
                _profile.BirthDate = profile.BirthDate;

                _db.Entry(_profile).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return Ok(_profile);

            }

            else
                return BadRequest("Profile id is invalid/or not found");
        }
    }
}
