
using Minimap.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Minimap.Infrastructure.Models
{
    public class MinimapDBContext
    {
        public DbSet<AccountDetail> Users { get; set; }
    }
}