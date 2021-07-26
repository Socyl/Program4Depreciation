using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4Depreciation
{
    class DepreciationStraightLine
    {
        private DateTime dateAddedToInventory;
        private DateTime dateRemovedFromInventory;
        private decimal endValue;
        private decimal startValue;
        private int lifetime= -1;

        public DateTime DateAddedToInventory
        {
            get
            {
                return dateAddedToInventory;
            }
            set
            {
                dateAddedToInventory = value;
                Calc();
            }
        }

        public decimal EndValue
        {
            get
            {
                return endValue;
            }
            set
            {
                endValue = value;
               Calc();
            }
        }

        public int LifeTime
        {
            get
            {
                return lifetime;
            }
            set
            {
                lifetime = value;
                Calc();
            }
        }
       
        public decimal SalvageValue
        {
            get;
            protected set;
        }

        public string Title
        {
            get;
            set;
        }

        public decimal StartValue
        {
            get
            {
                return startValue;
            }
            set
            {
                startValue = value;
                Calc();
            }
        }

        public override string ToString()
        {
            return "Title: " + Title + " Start Value($): " + StartValue + " End Value($): " +
                    EndValue + " Lifetime(Years): " + LifeTime;
        }

        public DateTime DateRemovedFromInventory
        {
            get 
            { 
                return dateRemovedFromInventory; 
            }
            set 
            {
                dateRemovedFromInventory = value;
            }
        }

        public virtual void Calc() 
        {

            TimeSpan lifeTimeInYears;
            TimeSpan timeInInventory;
            decimal yearsInInventory;
            decimal depreciableAssetCost;
            decimal depRate;
            decimal depreciationPerYear;

            //convert LifeTime to a TimeSpan
            lifeTimeInYears = new TimeSpan((LifeTime * 365), 0, 0, 0);
            DateRemovedFromInventory = DateAddedToInventory + lifeTimeInYears;

            //depreciable amount
            depreciableAssetCost = StartValue - EndValue;

            //depreciation rate
            depRate = 1.0M / Convert.ToDecimal(LifeTime);

            //depreciation per year
            depreciationPerYear = depreciableAssetCost * depRate;

            //time in inventory
            if (DateRemovedFromInventory < DateTime.Now)
            {
                SalvageValue = EndValue;  //fully depreciated, no need for math
            }
            else
            {
                timeInInventory = DateTime.Now - DateAddedToInventory;
                yearsInInventory = Convert.ToDecimal(timeInInventory.TotalDays) / 365.0M;
                SalvageValue = StartValue - (yearsInInventory * depreciationPerYear);
            }

        }

    }      
    
}