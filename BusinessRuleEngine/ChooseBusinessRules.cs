using System;
using BusinessRuleEngine.BusinessRulesImpleementation;
using BusinessRuleEngine.Interface;
using static BusinessRuleEngine.Models.PaymentType;

namespace BusinessRuleEngine
{
    public class ChooseBusinessRules
    {
        public static IBusinessRules ProductPayment(string PaymentType)
        {
            IBusinessRules businessRules = null;

            if (PaymentType == PaymentTypes.Book.ToString())
            {
                businessRules = new BookPayment();
            }
            else if (PaymentType == PaymentTypes.Product.ToString())
            {
                businessRules = new ProductPayment();
            }
            else if (PaymentType == PaymentTypes.Membership.ToString())
            {
                businessRules = new ActivateMembership();
            }
            else if (PaymentType == PaymentTypes.MembershipUpgrade.ToString())
            {
                businessRules = new UpgradeMembership();
            }
            else if (PaymentType == PaymentTypes.Video.ToString())
            {
                businessRules = new VideoPayment();
            }
            return businessRules;
        }
    }
}
