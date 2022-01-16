using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication2_with_NTTFramework.Models;

namespace WebApplication2_with_NTTFramework.Controllers.API
{
    public class FootballController : ApiController
    {
        GroupDBContext dBContext = new GroupDBContext();
        // GET: api/Football
        public IHttpActionResult Get()
        {
            List<Football> footballs = dBContext.Footballs.ToList();
            return Ok(new { footballs });
        }

        // GET: api/Football/5
        public async Task<IHttpActionResult> Get(int Id)
        {
            Football football = await dBContext.Footballs.FindAsync(Id);
            return Ok(new { football });
        }

        // POST: api/Football
        public async Task<IHttpActionResult> Post([FromBody] Football player)
        {
            dBContext.Footballs.Add(player);
            await dBContext.SaveChangesAsync();
            return Ok("you add one");
        }

        // PUT: api/Football/5
        public async Task<IHttpActionResult> Put(int Id, [FromBody] Football player)
        {
            Football playerToChange = await dBContext.Footballs.FindAsync(Id);
            playerToChange.Name = player.Name;
            playerToChange.LName = player.LName;
            playerToChange.Position = player.Position;
            playerToChange.Age = player.Age;
            await dBContext.SaveChangesAsync();
            return Ok("you change that player");
        }

        // DELETE: api/Football/5
        public async Task<IHttpActionResult> Delete(int Id)
        {
            Football playerToChange = await dBContext.Footballs.FindAsync(Id);
            await dBContext.SaveChangesAsync();
            return Ok("you delete the player");
        }
    }
}
