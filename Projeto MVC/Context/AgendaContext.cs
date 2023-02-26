using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto_MVC.Context
{
    public class AgendaContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Models.Contato> Contatos{get; set;}
    }
}