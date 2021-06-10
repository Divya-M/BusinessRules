using System;
using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Models;

namespace BusinessRuleEngine.BusinessRulesImpleementation
{
    public class ActivateMembership : IBusinessRules
    {

        public string PackingSlipOperations()
        {
            return "No PackingSlip operations to be peerformed";
        }

        public string MemberShipOperations()
        {
            try
            {
                Console.WriteLine("Membership Activated");
                Console.WriteLine("Intimate Owner by sending email, SendGrid service can be used to send email");
                return Status.Success;
            }
            catch
            {
                return Status.Failure;
            }
        }
    }
}
