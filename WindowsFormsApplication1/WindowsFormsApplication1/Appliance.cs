using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public abstract class Appliance : IDeviceOperations
    {
        private readonly string _serialNumber;
        private string _model;
        private double _baseCost;
        private string _status;

        
        public Appliance(string serialNumber, string model, double baseCost)
        {
            _serialNumber = serialNumber;
            _model = model;
            _baseCost = baseCost;
            _status = "New";
        }

        public string SerialNumber
        {
            get { return _serialNumber; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public double BaseCost
        {
            get { return _baseCost; }
            set { _baseCost = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public abstract double CalculateRepairCost();

        public virtual void Diagnose()
        {
        }

        public virtual void UpdateRepairStatus(string newStatus)
        {
            _status = newStatus;
        }
    }
}