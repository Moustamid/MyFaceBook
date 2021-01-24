using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
   public class DataContext  : DbContext
   {
     public DataContext(DbContextOptions options) : base(options)
     {  
     }
     
     public DbSet<value> Values { get; set; }
      // Table name : Values
   }

}