using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z25
{
    class InsuranceClient
    {
        public string Name { get; set; }
        public string InsuranceType { get; set; }
        public double InsuranceAmount { get; set; }
        public InsuranceClient(string name, string insuranceType, double insuranceAmount)
        {
            Name = name;
            InsuranceType = insuranceType;
            InsuranceAmount = insuranceAmount;
        }
        public string GetClientInfo()
        {
            return $"Name: {Name}, Insurance Type: {InsuranceType}, Insurance Amount: {InsuranceAmount}";
        }
    }
}
