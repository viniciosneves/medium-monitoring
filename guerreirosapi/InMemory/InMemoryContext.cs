using guerreirosapi.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace guerreirosapi.InMemory
{
    public class InMemoryContext : DbContext
    {
        public InMemoryContext(DbContextOptions<InMemoryContext> options) : base(options)
        { }
        public DbSet<Guerreiro> Guerreiros { get; set; }
    }
}
