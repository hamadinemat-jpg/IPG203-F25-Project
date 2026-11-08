using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    
    public static class ValidationHelper
    {
        private static int _validationCount = 0;

        public static int ValidationCount
        {
            get { return _validationCount; }
        }

        public static bool IsValidSerialNumber(string serialNumber)
        {
            _validationCount++;
            if (string.IsNullOrEmpty(serialNumber) || serialNumber.Length < 4)
            {
                return false;
            }
            return true;
        }

        public static bool IsValidCost(double cost)
        {
            return cost >= 0;
        }
    }
}