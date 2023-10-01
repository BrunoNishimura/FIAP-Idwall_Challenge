using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FIAP_Idwall.Domain;

namespace FIAP_Idwall.Persistence
{
    public class FIAP_IdwallContext : DbContext
    {
        public FIAP_IdwallContext(DbContextOptions<FIAP_IdwallContext> options) : base(options) { }
        public DbSet<FiapIdwall> FiapIdwalls { get; set; }
        public DbSet<ModelFbi> ModelFbis { get; set; }
        public DbSet<ModelInterpol> ModelInterpols { get; set; }

        //Cruzamento dos Ids do Modelo Interpol e FBI.
        // public DbSet<ModelInterpolFbi> ModelInterpolFbis { get; set; }

        //Serve para relacionar a Tabela da Interpol com a do FBI
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ModelInterpolFbi>()
        //        .HasKey(FI => new {FI.FbiId, FI.InterpolId});
        //}
    }
}
