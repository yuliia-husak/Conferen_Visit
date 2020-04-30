using Conferen_Visit.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conferen_Visit.Concrete
{
    public class EFDbContext: DbContext
    {
        public DbSet<GuestResponse> Guests { get; set; }
    }
}