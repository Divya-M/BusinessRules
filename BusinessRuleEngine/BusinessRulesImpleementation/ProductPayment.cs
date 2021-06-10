using System;
using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.BusinessRulesImpleementation
{
    public class ProductPayment : IBusinessRules
    {
        public string MemberShipOperations()
        {
            return "No Membership operations to be peerformed";
        }

        public string PackingSlipOperations()
        {
            try
            {
                Console.WriteLine("Generating Packing slip");
                Console.WriteLine("Generating Commission payment");
                return Status.Success;
            }catch
            {
                return Status.Failure;
            }
        }
    }
}
