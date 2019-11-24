using CRMApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApp.Data
{
    public class CRMAppContext: DbContext
    {
        public CRMAppContext (DbContextOptions<CRMAppContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
