using PartyCalculation.BusinessLogic;
using PartyCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PartyCalculation.Controllers
{
  public class DrinksCalculationController : Controller
  {
    // GET: DrinksCalculation
    public ActionResult Index(DrinksModel drinksModel)
    {
      DrinksModel dm = drinksModel == null ? new DrinksModel() : drinksModel;
      return View(dm);
    }


    // GET: DrinksCalculation/Create
    [HttpPost]
    public ActionResult Calculate(DrinksModel drinksModel)
    {

   
      CalculateRequiredBottles calculateRequired = new CalculateRequiredBottles();
      DrinksModel calculatedData = calculateRequired.GetRequiredBottles(drinksModel);
      return RedirectToAction("Index", calculatedData);
    }

  }
}
