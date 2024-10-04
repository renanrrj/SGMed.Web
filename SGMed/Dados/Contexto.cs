using Microsoft.EntityFrameworkCore;
using SGMed.Models;

namespace SGMed.Dados
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        {
        }

        public DbSet<ClienteModel> Tb_Cliente { get; set; }
        public DbSet<EmpresaModel> Tb_Empresa { get; set; }
        public DbSet<ExameModel> Tb_Exame { get; set; }

    }
}
