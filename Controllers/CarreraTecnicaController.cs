using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiKalum.Entities;

namespace WebApiKalum.Controllers
{
    [ApiController]
    [Route("v1/KalumManagement/[controller]")]

    public class CarreraTecnicaController : ControllerBase
    {
        private readonly KalumDbContext DbContext;

        public CarreraTecnicaController(KalumDbContext _Dbcontext)
        {
            this.DbContext = _Dbcontext;
        }
        [HttpGet]

        public ActionResult<List<CarreraTecnica>> Get()
        {
           List<CarreraTecnica> carrerasTecnicas = null;
           carrerasTecnicas = DbContext.CarreraTecnica.Include (c => c.Aspirantes).Include(c => c.Inscripciones).ToList();
           if(carrerasTecnicas == null || carrerasTecnicas.Count == 0)
           {
               return new NoContentResult();
           }    
           return Ok(carrerasTecnicas);
        }

        private void ToList()
        {
            throw new NotImplementedException();
        }
    }

}