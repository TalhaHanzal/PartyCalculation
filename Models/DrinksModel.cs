using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyCalculation.Models
{
  public class DrinksModel
  {
    public int LightDrinker { get; set; }

    public int AverageDrinker { get; set; }

    public int HeavyDrinker { get; set; }

    public int LightDrinkerConsumptionPerHr { get; set; }

    public int HeavyDrinkerConsumptionPerHr { get; set; }

    public int AverageDrinkerConsumptionPerHr { get; set; }

    public int TotalWinesBottles { get; set; }

    public int TotalLiquirBottles { get; set; }

    public int TotalBeerBottles { get; set; }

    public int  HourlyConsumptionOfLightDrinkerWine { get; set; }

    public int TotalHr { get; set; }

    public bool IsBeer { get; set; }

    public bool IsLiqiur { get; set; }

    public bool IsWine { get; set; }

    public int TotleBottesRequired { get; set; }

  }
}