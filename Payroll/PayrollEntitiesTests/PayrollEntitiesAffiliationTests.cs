//using Moq;
//using NUnit.Framework;
//using PayrollEntities;
//using PayrollEntities.affiliation;


//namespace PayrollEntitiesTests
//{
//    [TestFixture]
//    public class UnionMemberAffiliationTest
//    {
//        private static readonly DateInterval IntervalHas4Fridays =
//            new DateInterval(new DateTime(2015, 12, 01), new DateTime(2015, 12, 31));


//        [Test]
//        public void TestCalculateDeductionsAmount()
//        {
//            var mockUnionMemberAffiliation = new Mock<UnionMemberAffiliation>();
//            mockUnionMemberAffiliation.CallBase = true; // Use CALLS_REAL_METHODS equivalent
//            mockUnionMemberAffiliation.Setup(uma => uma.getWeeklyDueAmount()).Returns(25);

//            Assert.That(mockUnionMemberAffiliation.Object.calculateDeductionsAmount(IntervalHas4Fridays), Is.EqualTo(4 * 25));
//        }
//    }

//}