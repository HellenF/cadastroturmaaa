using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cadastroturmaa.Data;
using cadastroturmaa.Models;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.VisualBasic;

namespace cadastroturmaa.ControllersControllerBase
{
    [ApiController]
    [Route("v1/amarelo")]
    public class AlunoController : Controller
    {
        [HttpGet]
        [Route("")]
        [AllowAnonymous]
        [ResponseCache(VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any, Duration = 30)]
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<ActionResult<List<Aluno>>> Get([FromServices] DataContext context)
        {
            var Turma = await context.Categories.AsNoTracking().ToListAsync();
            return Turma;
        }
        [HttpGet]
        [Route("{id:int}")]
        [AllowAnonymous]
        public async Task<ActionResult<Aluno>> GetById([FromServices] DataContext context, int id)
        {
            var Aluno = await context.Categories.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return Aluno;
        }

        public DateTime dataDeNascimento { get; set; }

        public Int64 idade
        {
             get 
             {
                 //DateTime.Now pega a hora do sistema- 
                 return DateAndTime.DateDiff(DateInterval.Year, dataDeNascimento, DateTime.Now);
             }


        }


       
        [HttpPut]
        [Route("{id:int}")]
        
        public async Task<ActionResult<Aluno>> Put(
            [FromServices] DataContext context,
            int id,
            [FromBody]Aluno model)
        {
            
            try
            {
                context.Entry<Aluno>(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return model;
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest(new { message = "Não foi possível atualizar o aluno" });

            }
        }
      
    }
}

