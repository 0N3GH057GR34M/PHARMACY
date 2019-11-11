using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHARMACY.Models
{
  public class Merchandise
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public int MG { get; set; }
    public double Prise { get; set; }
    public int Count { get; set; }
    public int ShelfLife { get; set; }
    public bool IsAdd { get; set; }

    public int? ProviderID { get; set; }
    public Provider Provider { get; set; }
  }
}
