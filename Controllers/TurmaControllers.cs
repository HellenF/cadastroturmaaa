
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cadastroturmaa.Data;
using cadastroturmaa.Models;
using Microsoft.AspNetCore.Authorization;

namespace cadastroturmaa.Controllers
{
    [ApiController]
    [Route("v1/amarelo")]
    public class TurmaController : Controller
    {
        private const string V = "v1/amarelo";

        [HttpGet]
        [Route("")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Turma>>> Get([FromServices] DataContext context)
        {
            var Turma = await context.Turma.ToListAsync();
            return Turma;
        }

        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Turma>> Post(
            [FromServices] DataContext context,
            [FromBody]Turma model)
        {
            if (ModelState.IsValid)
            {
                context.Turma.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
                
            }
        }
    }
}