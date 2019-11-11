using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHARMACY.Models
{
  public class Provider
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public List<Merchandise> Merchandises { get; set; }

    public int? PharmacyID { get; set; }
    public Pharmacy Pharmacy { get; set; }
  }
}
