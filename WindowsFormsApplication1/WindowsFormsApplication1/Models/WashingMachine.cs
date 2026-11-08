using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    
    public class WashingMachine : Appliance
    {
        
        private int _capacity;

       
        public WashingMachine(string serialNumber, string model, double baseCost, int capacity)
            : base(serialNumber, model, baseCost)
        {
            _capacity = capacity;
        }

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

         
        public override double CalculateRepairCost()
        {
        
            return BaseCost + (_capacity * 10.0);
        }
    }
}
