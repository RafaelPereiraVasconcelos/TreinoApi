using Microsoft.AspNetCore.Mvc;
using TreinoAPI.Data;
using TreinoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TreinoAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ExerciciosController : ControllerBase
    {
        private readonly DataContext _context;
         public ExerciciosController (DataContext context)
        {
                      
            _context = context;
        }
    
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Exercicio> lista = await _context.Exercicios.ToListAsync();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
            public async Task<IActionResult> Add(Exercicio novoExercicio)
            {
                try 
                {
                    if(novoExercicio.Repeticao == 0)
                    {
                        throw new Exception("Precisa ter no minimo uma repetição");
                    }
                    await _context.Exercicios.AddAsync(novoExercicio);
                    await _context.SaveChangesAsync();
                    return Ok("Exercicio adicionado");

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
    }
}
