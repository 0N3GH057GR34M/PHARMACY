using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHARMACY.Models
{
  public class Pharmacy
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime CurrentDate { get; set; }
    public List<Provider> Providers { get; set; }
  }
}
