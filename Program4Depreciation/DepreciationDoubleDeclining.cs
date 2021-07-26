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
            int yearsInInventoryInt;
            decimal assetBookValue;
            decimal doubleSlRate;
            decimal depreciationForYear;
            decimal yearsInInventory; 
            TimeSpan lifeTimeInYears;
            TimeSpan timeInInventory;
                
            //set initial book value to start value
            assetBookValue = StartValue;
            //set double SL rate
            doubleSlRate = 2.0M / Convert.ToDecimal(LifeTime);

            //convert LifeTime to a TimeSpan
            lifeTimeInYears = new TimeSpan((LifeTime * 365), 0, 0, 0);

            DateRemovedFromInventory = DateAddedToInventory + lifeTimeInYears;

            //time in inventory
            //if fully depreciated
            if (DateRemovedFromInventory < DateTime.Now)
            {
                //timeInInventory = DateRemovedFromInventory - DateAddedToInventory;
                SalvageValue = EndValue; 
            }
            else  //if partially depreciated
            {
                timeInInventory = DateTime.Now - DateAddedToInventory;

                yearsInInventory = Convert.ToDecimal(timeInInventory.TotalDays) / 365.0M;
                yearsInInventoryInt = (int)yearsInInventory;  //convert to int for loop

                for (int i = 0; i < yearsInInventoryInt; i++)
                {
                    //calculate yearly depreciation
                    depreciationForYear = doubleSlRate * assetBookValue;
                    //subtract it from starting asset value
                    assetBookValue -= depreciationForYear;
                }
                SalvageValue = assetBookValue;
            }

        }

        public override string ToString()
        {
           return base.ToString() + " using double declining depreciation.";
        }

    }
}
