using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

    public class PeopleContext : DbContext
    {
        public PeopleContext (DbContextOptions<PeopleContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
