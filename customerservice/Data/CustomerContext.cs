using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using customerservice.Models;
using Microsoft.Extensions.Logging;

    public class CustomerContext : DbContext
    {
        private readonly ILogger<CustomerContext> _logger;

        public CustomerContext (ILogger<CustomerContext> logger, DbContextOptions<CustomerContext> options)
            : base(options)
        {
            _logger = logger;
        }

        public DbSet<customerservice.Models.Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.LogTo(l => _logger.LogInformation(l));
    }
