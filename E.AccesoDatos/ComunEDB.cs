using E.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.AccesoDatos
{
    public class ComunEDB : DbContext
    {
        public DbSet<PersonaE> PersonaE { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-NFDMETJ\\SQLEXPRESS;Initial Catalog=EDB;Integrated Security=True");
        }
    }
}
