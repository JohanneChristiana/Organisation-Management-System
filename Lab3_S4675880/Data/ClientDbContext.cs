//--------------------------------------------------------//
// Stores Client Database
// This defines the database context for InnovationStar system,
// This is really important when using Entity Framework Core for data access.
//--------------------------------------------------------//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab3_S4675880.Models;

    public class ClientDbContext : DbContext
    {
        public ClientDbContext (DbContextOptions<ClientDbContext> options)
            : base(options) // passes the options to the base DbContext class.
    {
        }

        public DbSet<Lab3_S4675880.Models.ClientModel> ClientModel { get; set; } = default!; // This is essential for the database table connection
    }
