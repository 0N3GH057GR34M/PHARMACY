using PHARMACY.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHARMACY.Edition
{
  public class Edition
  {
    public void MerchIsAddChanging(PharmacyContext data, int num)
    {
      var merches = data.Merchandises.Where(settings => settings.ID == num);
      merches.First().IsAdd = !merches.First().IsAdd;
      data.SaveChanges();
    }
    public void MerchDelete(PharmacyContext data, int num)
    {
      var merch = data.Merchandises.Where(settings => settings.ID == num).FirstOrDefault();
      data.Merchandises.Remove(merch);
      data.SaveChanges();
    }
    public void ProviderDelete(PharmacyContext data, int num)
    {
      var merches = data.Merchandises.Where(settings => settings.ProviderID == num).ToList();
      foreach (var merch in merches)
      {
        data.Merchandises.Remove(merch);
      }
      data.SaveChanges();
      var provider = data.Providers.Where(settings => settings.ID == num).FirstOrDefault();
      data.Providers.Remove(provider);
      data.SaveChanges();
    }
    public void ProviderAdd(PharmacyContext data, string name)
    {
      data.Providers.Add(new Models.Provider { Name = name, PharmacyID = 1 });
      data.SaveChanges();
    }
    public void MerchAdd(PharmacyContext data, int p, string name, int mg, double price, int count, int sl)
    {
      data.Merchandises.Add(new Models.Merchandise { Name = name, MG = mg, Prise = price, Count = count, ShelfLife = sl, IsAdd = false, ProviderID = p });
      data.SaveChanges();
    }
  }
}
