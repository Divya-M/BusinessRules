using System;
namespace BusinessRuleEngine.Models
{
    public class PaymentType
    {
        public enum PaymentTypes
        {
            Book,
            Product,
            Membership,
            MembershipUpgrade,
            Video
        }
    }
}
