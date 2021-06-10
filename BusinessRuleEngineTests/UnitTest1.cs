using BusinessRuleEngine.BusinessRulesImpleementation;
using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BusinessRuleEngineTests
{
    [TestClass]
    public class UnitTest1
    {
        private IBusinessRules _businessrules;

        
        [TestMethod]
        public void TestMethod_ProductPayment()
        {
            _businessrules = new ProductPayment();
            string result = _businessrules.PackingSlipOperations();
            string expected = Status.Success;
            Assert.AreEqual(expected, result);

            var businessruleMock = new Mock<IBusinessRules>();
            businessruleMock.Setup(s => s.PackingSlipOperations()).Returns(Status.Failure);
            string mockResult = businessruleMock.Object.PackingSlipOperations();
            string mockExpected = Status.Failure;
            Assert.AreEqual(mockExpected,mockResult);
        }

        [TestMethod]
        public void TestMethod_BookPayment()
        {
            _businessrules = new BookPayment();
            string result = _businessrules.PackingSlipOperations();
            string expected = Status.Success;
            Assert.AreEqual(expected, result);

            var businessruleMock = new Mock<IBusinessRules>();
            businessruleMock.Setup(s => s.PackingSlipOperations()).Returns(Status.Failure);
            string mockResult = businessruleMock.Object.PackingSlipOperations();
            string mockExpected = Status.Failure;
            Assert.AreEqual(mockExpected, mockResult);
        }

        [TestMethod]
        public void TestMethod_VideoPayment()
        {
            _businessrules = new VideoPayment();
            string result = _businessrules.PackingSlipOperations();
            string expected = Status.Success;
            Assert.AreEqual(expected, result);

            var businessruleMock = new Mock<IBusinessRules>();
            businessruleMock.Setup(s => s.PackingSlipOperations()).Returns(Status.Failure);
            string mockResult = businessruleMock.Object.PackingSlipOperations();
            string mockExpected = Status.Failure;
            Assert.AreEqual(mockExpected, mockResult);
        }

        [TestMethod]
        public void TestMethod_ActivateMembership()
        {
            _businessrules = new ActivateMembership();
            string result = _businessrules.MemberShipOperations();
            string expected = Status.Success;
            Assert.AreEqual(expected, result);

            var businessruleMock = new Mock<IBusinessRules>();
            businessruleMock.Setup(s => s.MemberShipOperations()).Returns(Status.Failure);
            string mockResult = businessruleMock.Object.MemberShipOperations();
            string mockExpected = Status.Failure;
            Assert.AreEqual(mockExpected, mockResult);
        }

        [TestMethod]
        public void TestMethod_UpgradeMembership()
        {
            _businessrules = new UpgradeMembership();
            string result = _businessrules.MemberShipOperations();
            string expected = Status.Success;
            Assert.AreEqual(expected, result);

            var businessruleMock = new Mock<IBusinessRules>();
            businessruleMock.Setup(s => s.MemberShipOperations()).Returns(Status.Failure);
            string mockResult = businessruleMock.Object.MemberShipOperations();
            string mockExpected = Status.Failure;
            Assert.AreEqual(mockExpected, mockResult);
        }
    }
}
