using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4Depreciation
{
    class DepreciationDoubleDeclining : DepreciationStraightLine
    {

       

        public override void Calc()
        {

            decimal assetBookValue;
            decimal doubleSlRate;
            decimal depreciationPerYear;
            decimal eoyBookValue;
            TimeSpan lifeTimeInYears;
            TimeSpan timeInInventory;
                
            //set initial book value to start value
            assetBookValue = StartValue;
            //set double SL rate
            doubleSlRate = 2.0M / Convert.ToDecimal(LifeTime);
            //calculate yearly depreciation
            depreciationPerYear = assetBookValue - doubleSlRate * assetBookValue;

            //convert LifeTime to a TimeSpan
            lifeTimeInYears = new TimeSpan((LifeTime * 365), 0, 0, 0);
            DateRemovedFromInventory = DateAddedToInventory + lifeTimeInYears;

            //at this point, see how long item in inventory
            //if finished depreciating, end value
            //if not finished, am i depreciating continuously?  if so, how.
            //if not,  annual calc and stop on whole years?


            ////time in inventory
            //if (DateRemovedFromInventory < DateTime.Today)
            //{
            //    timeInInventory = DateRemovedFromInventory - DateAddedToInventory;
            //}
            //else
            //{
            //    timeInInventory = DateTime.Now - DateAddedToInventory;
            //}

            //yearsInInventory = Convert.ToDecimal(timeInInventory.TotalDays) / 365.0M;

            //SalvageValue = StartValue - (yearsInInventory * depreciationPerYear);
        }

        public override string ToString()
        {
           return base.ToString() + " using double declining depreciation.";
        }

    }
}
