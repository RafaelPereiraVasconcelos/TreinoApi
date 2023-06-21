using Microsoft.AspNetCore.Mvc;

namespace TreinoAPI.Controllers
{
    [ApiController]
    [Route("[Controller}")]
    public class ExerciciosController : ControllerBase
    {
        private readonly DataContext _context;
         public ExerciciosController (DataContext context)
        {
                      
            _context = context;
        }
    }
}