

using Microsoft.EntityFrameworkCore;
using cadastroturmaa.Models;
using System;

namespace cadastroturmaa.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
        : base(options)
        {

        }
        public DbSet<Turma> Turma {get; set;}

        public DbSet<Aluno> Categories {get; set;}

        //internal object Data(Func<object, object> p)
        //{
            //throw new NotImplementedException();
        //}
    }
}