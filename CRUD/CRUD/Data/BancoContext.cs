using CRUD.Controllers;
using CRUD.Models;

using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<ContatoModel> Contatos { get; set; }

    }
}
