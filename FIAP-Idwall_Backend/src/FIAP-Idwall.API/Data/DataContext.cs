using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FIAP_Idwall.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FIAP_Idwall.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<FiapIdwall> GetDbFiapIdwalls { get; set; }
    }
}