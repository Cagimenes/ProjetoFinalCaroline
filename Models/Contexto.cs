using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace ProjetoFinalCaroline.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        //public DbSet<Paciente>? Paciente { get; set; }
    }
}
