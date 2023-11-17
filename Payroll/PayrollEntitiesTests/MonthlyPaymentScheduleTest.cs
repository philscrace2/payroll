using NUnit.Framework;
using PayrollEntities;
using PayrollEntities.paymentschedule;

namespace YourNamespace
{
    [TestFixture]
    public class MonthlyPaymentScheduleTest
    {
        private static readonly DateTime FIRST_DAY_OF_A_MONTH = new DateTime(2015, 11, 01);
        private static readonly DateTime LAST_DAY_OF_A_MONTH = new DateTime(2015, 11, 30);
        private static readonly DateTime LAST_DAY_OF_NEXT_MONTH = new DateTime(2015, 12, 31);
        MonthlyPaymentSchedule monthlyPaymentSchedule = null;

        [SetUp]
        public void Setup()
        {
            monthlyPaymentSchedule = new MonthlyPaymentSchedule();
        }

        [Test]
        public void isPaydayOnLastDayOfMonth_ShouldBeTrue()
        {
            Assert.That(monthlyPaymentSchedule.isPayDate(LAST_DAY_OF_A_MONTH), Is.EqualTo(true));
            Assert.That(monthlyPaymentSchedule.isPayDate(LAST_DAY_OF_NEXT_MONTH), Is.EqualTo(true));
        }

        [Test]
        public void isPaydayOnNotLastDayOfMonth_ShouldBeFalse()
        {
            Assert.That(monthlyPaymentSchedule.isPayDate(LAST_DAY_OF_A_MONTH.AddDays(1)), Is.EqualTo(false));
            Assert.That(monthlyPaymentSchedule.isPayDate(LAST_DAY_OF_A_MONTH.Subtract(TimeSpan.FromDays(1))), Is.EqualTo(false));
            Assert.That(monthlyPaymentSchedule.isPayDate(LAST_DAY_OF_A_MONTH.Subtract(TimeSpan.FromDays(5))), Is.EqualTo(false));
        }


        [Test]
        public void testGetIntervalOnPayday()
        {
            DateInterval dateInterval = monthlyPaymentSchedule.getPayInterval(LAST_DAY_OF_A_MONTH);
            Assert.That(dateInterval.from, Is.EqualTo(FIRST_DAY_OF_A_MONTH));
            Assert.That(dateInterval.to, Is.EqualTo(LAST_DAY_OF_A_MONTH));
        }


        [Test]
        public void testGetNextPayday()
        {
            Assert.That(monthlyPaymentSchedule.getSameOrNextPayDate(FIRST_DAY_OF_A_MONTH), Is.EqualTo(LAST_DAY_OF_A_MONTH));
            Assert.That(monthlyPaymentSchedule.getSameOrNextPayDate(LAST_DAY_OF_A_MONTH), Is.EqualTo(LAST_DAY_OF_A_MONTH));
            Assert.That(monthlyPaymentSchedule.getSameOrNextPayDate(LAST_DAY_OF_A_MONTH.AddDays(1)), Is.EqualTo(LAST_DAY_OF_NEXT_MONTH));

        }
    }
}