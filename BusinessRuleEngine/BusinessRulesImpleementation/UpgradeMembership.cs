using System;
using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.BusinessRulesImpleementation
{
    public class UpgradeMembership : IBusinessRules
    {
        public string MemberShipOperations()
        {
            try
            {
                Console.WriteLine("MemberShip Upgraded");
                Console.WriteLine("Intimate Owner by sending email, Send Grid Service can be used to send email");
                return Status.Success;
            }
            catch
            {
                return Status.Failure;
            }
        }

        public string PackingSlipOperations()
        {
            return "No PackingSlip operations to be peerformed";
        }
    }
}
