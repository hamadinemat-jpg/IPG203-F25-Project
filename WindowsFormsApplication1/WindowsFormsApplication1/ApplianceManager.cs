using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class ApplianceManager
    {
        
        private List<Appliance> _appliances;

        public ApplianceManager()
        {
            _appliances = new List<Appliance>();
        }

        public void AddAppliance(Appliance appliance)
        {
            _appliances.Add(appliance);
        }

        public List<Appliance> GetAllAppliances()
        {
            return _appliances;
        }

       
        public double CalculateTotalRepairCost()
        {
            double totalCost = 0;
            foreach (Appliance app in _appliances)
            {
                totalCost += app.CalculateRepairCost(); 
            }
            return totalCost;
        }
    }
}