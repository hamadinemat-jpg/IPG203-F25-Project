using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
   
    public class AirConditioner : Appliance
    {
        private double _coolingCapacityBTU; 

        public AirConditioner(string serialNumber, string model, double baseCost, double coolingCapacityBTU)
            : base(serialNumber, model, baseCost)
        {
            _coolingCapacityBTU = coolingCapacityBTU;
        }

        public double CoolingCapacityBTU
        {
            get { return _coolingCapacityBTU; }
            set { _coolingCapacityBTU = value; }
        }

        
        public override double CalculateRepairCost()
        {
            return BaseCost + (_coolingCapacityBTU * 0.05);
        }
    }
}