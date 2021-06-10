using System;
using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.BusinessRulesImpleementation
{
    public class BookPayment : IBusinessRules
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
                Console.WriteLine("Generating duplicate packing slip");
                return Status.Success;
            }
            catch
            {
                return Status.Failure;
            }
        }
    }
}
