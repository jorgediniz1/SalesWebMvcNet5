﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc2.Models;

namespace SalesWebMvc2.Data
{
    public class SalesWebMvc2Context : DbContext
    {
        public SalesWebMvc2Context(DbContextOptions<SalesWebMvc2Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        
    }
}
