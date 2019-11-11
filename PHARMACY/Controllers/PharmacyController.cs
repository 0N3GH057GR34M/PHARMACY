using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PHARMACY.Context;

namespace PHARMACY.Controllers
{
  public class PharmacyController : Controller
  {
    private readonly PharmacyContext data;
    public PharmacyController(PharmacyContext context)
    {
      data = context;
    }
    public IActionResult Start()
    {
      return View();
    }
    public IActionResult PharmacyInfo()
    {
      return View(data.Pharmacies.ToList());
    }
    public IActionResult ProviderInfo()
    {
      return View(data.Providers.ToList());
    }
    public IActionResult MerchInfo()
    {
      return View(data.Merchandises.ToList());
    }
    public IActionResult IsAddChanging(int num)
    {
      Edition.Edition edition = new Edition.Edition();
      edition.MerchIsAddChanging(data, num);
      return Redirect("done");
    }
    public IActionResult MerchDelete(int num)
    {
      Edition.Edition edition = new Edition.Edition();
      edition.MerchDelete(data, num);
      return Redirect("done");
    }
    public IActionResult ProviderDelete(int num)
    {
      Edition.Edition edition = new Edition.Edition();
      edition.ProviderDelete(data, num);
      return Redirect("done");
    }
    public IActionResult ProviderAddForm()
    {     
      return View();
    }
    [HttpPost]
    public IActionResult ProviderAdd(string name)
    {
      Edition.Edition edition = new Edition.Edition();
      edition.ProviderAdd(data, name);
      return Redirect("done");
    }
    public IActionResult MerchAddForm()
    {
      return View();
    }
    [HttpPost]
    public IActionResult MerchAdd(int provider, string name, int mg, double price, int count, int sl)
    {
      Edition.Edition edition = new Edition.Edition();
      edition.MerchAdd(data, provider, name, mg, price, count, sl);
      return Redirect("done");
    }
    public IActionResult Done()
    {
      return View();
    }
  }
}