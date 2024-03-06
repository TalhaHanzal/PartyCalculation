using PartyCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyCalculation.BusinessLogic
{
  public class CalculateRequiredBottles
  {

    public DrinksModel GetRequiredBottles(DrinksModel drinksModel)
    {
      
      try
      {
        bool isWine = drinksModel.IsWine;
        bool isLiqiur = drinksModel.IsLiqiur;
        bool isBeer = drinksModel.IsBeer;

        int lightdrinker = drinksModel.LightDrinker, AvgDrinker = drinksModel.AverageDrinker, HeavyDrinker = drinksModel.HeavyDrinker;

        int hr = drinksModel.TotalHr;
        int hrlyConsumptionOfWine = drinksModel.HourlyConsumptionOfLightDrinkerWine;
        int hrlyConsumptionOfLiquir = hrlyConsumptionOfWine + 2;
        int hrlyConsumptionOfBeer = hrlyConsumptionOfLiquir + 2;

        if (isWine)
        {
          int Winebottles = GetDrinksCalcutions(hr, lightdrinker, AvgDrinker, HeavyDrinker, hrlyConsumptionOfWine);
          drinksModel.TotalWinesBottles = Winebottles;
          drinksModel.TotleBottesRequired += Winebottles;
        }
        if (isLiqiur)
        {
          int Liquirbottles = GetDrinksCalcutions(hr, lightdrinker, AvgDrinker, HeavyDrinker, hrlyConsumptionOfLiquir);
          drinksModel.TotalLiquirBottles = Liquirbottles;
          drinksModel.TotleBottesRequired += Liquirbottles;
        }
        if (isBeer)
        {
          int Beerbottles = GetDrinksCalcutions(hr, lightdrinker, AvgDrinker, HeavyDrinker, hrlyConsumptionOfBeer);
          drinksModel.TotalBeerBottles = Beerbottles;
          drinksModel.TotleBottesRequired += Beerbottles;
        }
      }
      catch (Exception ex)
      {

        throw;
      }
      return drinksModel;

    }

    private int GetDrinksCalcutions(int hr, int lightdrinker, int avgDrinker, int heaveDrinker, int hrlyCnsumption)
    {

      int bottleConsumption = 0;
      for (int j = 0; j < hr; j++)
      {
        int lightdrinkerConsumption = hrlyCnsumption;
        int AvgDrinkerConsumption = lightdrinkerConsumption + hrlyCnsumption;
        int HeaverDrinkerConsumption = AvgDrinkerConsumption + hrlyCnsumption;
        if (lightdrinker > 0)
        {
          int lightBttle = 0;
          for (int i = 0; i < lightdrinker; i++)
          {
            lightBttle += lightdrinkerConsumption;

          }
          bottleConsumption = bottleConsumption + lightBttle;

        }
        if (avgDrinker > 0)
        {
          int AvgBttle = 0;
          for (int i = 0; i < avgDrinker; i++)
          {
            AvgBttle += AvgDrinkerConsumption;

          }
          bottleConsumption = bottleConsumption + AvgBttle;
        }
        if (heaveDrinker > 0)
        {
          int HeavyBttle = 0;
          for (int i = 0; i < heaveDrinker; i++)
          {
            HeavyBttle += HeaverDrinkerConsumption;

          }
          bottleConsumption = bottleConsumption + HeavyBttle;
        }
        hrlyCnsumption = hrlyCnsumption / 2;
      }
      return bottleConsumption;
    }
  }
}