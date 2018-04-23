using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Minimap.Infrastructure.Models
{
    public class MinimapDb :DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}