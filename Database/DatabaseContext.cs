using Microsoft.EntityFrameworkCore;
using OCTOTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCTOTeste.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            // Necessário para nossa implementação code first
            Database.EnsureCreated();
        }
    }
}