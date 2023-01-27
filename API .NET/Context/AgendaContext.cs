using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_.NET.Entities;

namespace API_.NET.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext>options) : base(options)
        {

        }

        public DbSet<Contatos> Contatos{get; set;}
    }
}