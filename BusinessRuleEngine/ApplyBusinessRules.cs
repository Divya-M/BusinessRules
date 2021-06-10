using System;
using BusinessRuleEngine.Interface;

namespace BusinessRuleEngine
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the Payment type : " +
            "Book \n" +
            "Product \n" +
            "Membership \n" +
            "MembershipUpgrade \n" +
            "Video \n");

            string paymentType = Console.ReadLine();

            IBusinessRules businessRule = ChooseBusinessRules.ProductPayment(paymentType);
            string packingstatus = businessRule.PackingSlipOperations();
            Console.WriteLine($"Packing Operations status : {packingstatus}");
            string membershipstatus = businessRule.MemberShipOperations();
            Console.WriteLine($"Membership status : {membershipstatus}");
        }
    }
}
