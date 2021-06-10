using System;
using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.BusinessRulesImpleementation
{
    public class VideoPayment : IBusinessRules
    {
        public string MemberShipOperations()
        {
            return "No Membership Operations to be performed";
        }

        public string PackingSlipOperations()
        {
            try
            {
                Console.WriteLine("Generating Packing slip");
                Console.WriteLine("Generating Commission payment");
                Console.WriteLine("Add FirstAid Video to the packing slip");
                return Status.Success;
            }
            catch
            {
                return Status.Failure;
            }
        }
    }
}
