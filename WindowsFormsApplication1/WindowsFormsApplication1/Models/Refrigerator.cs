
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
     
    public class Refrigerator : Appliance
    {
         
        private int _numberOfDoors;

         
        public Refrigerator(string serialNumber, string model, double baseCost, int numberOfDoors)
            : base(serialNumber, model, baseCost)
        {
            _numberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors
        {
            get { return _numberOfDoors; }
            set { _numberOfDoors = value; }
        }

         
        public override double CalculateRepairCost()
        {
            
            return BaseCost + (_numberOfDoors * 50.0);
        }
    }
}