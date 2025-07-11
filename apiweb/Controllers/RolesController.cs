using Microsoft.AspNetCore.Mvc;
using ProyectoRolesApi.Data;
using ProyectoRolesApi.Models;
using Microsoft.EntityFrameworkCore;


namespace ProyectoRolesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RolesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rol>>> GetRoles()
        {
            return await _context.RolesEstudiantes.ToListAsync();
        }
    }

}
