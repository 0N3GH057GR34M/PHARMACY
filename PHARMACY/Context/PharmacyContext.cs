using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PHARMACY.Models;

namespace PHARMACY.Context
{
  public class PharmacyContext : DbContext
  {
    public DbSet<Pharmacy> Pharmacies { get; set; }
    public DbSet<Merchandise> Merchandises { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options)
    {
      Database.EnsureCreated();
    }
  }
}
