using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFPartyInvites.Models
{
   public class DataContext : DbContext
   {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
       { }
       public DbSet<GuestResponse> Responses { get; set; }
   }
}
