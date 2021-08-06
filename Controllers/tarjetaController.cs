using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using backendTarjeta.modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backendTarjeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tarjetaController : ControllerBase
    {
        private readonly aplicationDBContext _dbContext;

        //creo controlador
        public tarjetaController( aplicationDBContext _context )
        {
            _dbContext = _context;
        }

        // GET: api/<tarjetaControles>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {   //await espere a unos instantes
                var listTarjetas = await _dbContext.TarjetaCredito.ToListAsync();
                return Ok(listTarjetas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<tarjetaControles>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TarjetaCredito tarjeta)
        {
            try
            {
                _dbContext.Add(tarjeta);
                await _dbContext.SaveChangesAsync();
                return Ok(tarjeta);
            }
            catch (Exception ex)
            {
                return (BadRequest(ex.Message));
            }
        }

        // PUT api/<tarjetaControles>/5
        [HttpPut("{id}")]
        public async Task<IActionResult>  Put(int id, [FromBody] TarjetaCredito tarjeta)
        {
            try
            {
                if (id != tarjeta.Id)
                {
                    return NotFound();
                }

                _dbContext.Update(tarjeta); // await, espera a que los cambios sean hechos
                await _dbContext.SaveChangesAsync();
                return Ok(new { message = "La tarjeta se actualizo"});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<tarjetaControles>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
