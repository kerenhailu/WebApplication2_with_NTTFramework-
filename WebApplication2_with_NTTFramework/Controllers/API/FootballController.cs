using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            try
            {
                List<Football> footballs = dBContext.Footballs.ToList();
                return Ok(new { footballs });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // GET: api/Football/5
        public async Task<IHttpActionResult> Get(int Id)
        {
            try
            {
                Football football = await dBContext.Footballs.FindAsync(Id);
                return Ok(new { football });
            }
            catch (SqlException ex)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        // POST: api/Football
        public async Task<IHttpActionResult> Post([FromBody] Football player)
        {
            try
            {
                dBContext.Footballs.Add(player);
                await dBContext.SaveChangesAsync();
                return Ok("you add one");
            }
            catch (SqlException ex)
            {
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        // PUT: api/Football/5
        public async Task<IHttpActionResult> Put(int Id, [FromBody] Football player)
        {
            try
            {
                Football playerToChange = await dBContext.Footballs.FindAsync(Id);
                playerToChange.Name = player.Name;
                playerToChange.LName = player.LName;
                playerToChange.Position = player.Position;
                playerToChange.Age = player.Age;
                await dBContext.SaveChangesAsync();
                return Ok("you change that player");
            }
            catch (SqlException ex)
            {
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }



        }

        // DELETE: api/Football/5
        public async Task<IHttpActionResult> Delete(int Id)
        {
            try
            {
                Football playerToChange = await dBContext.Footballs.FindAsync(Id);
                await dBContext.SaveChangesAsync();
                return Ok("you delete the player");
            }
            catch (SqlException ex)
            {
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
