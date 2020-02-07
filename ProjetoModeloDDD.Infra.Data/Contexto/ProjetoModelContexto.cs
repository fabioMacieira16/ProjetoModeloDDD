using ProjetoModeloDDD.domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace ProjetoModeloDDD.Infra.Data.Contexto
{
    public class ProjetoModelContexto : DbContext
    {
        public ProjetoModelContexto()
            : base("ProjetoModeloDDD")
        {

        }
       public DbSet <Cliente> Clientes { get; set; }
    }
}
