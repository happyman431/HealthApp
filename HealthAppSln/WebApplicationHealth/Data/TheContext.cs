using HealthApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationHealth.Data
{
    public class TheContext : DbContext
    {
        public TheContext(DbContextOptions<TheContext> options)
            : base(options)
        {
        }
        public DbSet<Items> TodoItems { get; set; }
    }
}