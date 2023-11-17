using Moq;
using NUnit.Framework;
using PayrollEntities;
using PayrollEntities.paymentschedule;

namespace YourNamespace
{
    [TestFixture]
    public class BiWeeklyPaymentScheduleTest
    {
        // Assuming DateInterval and other necessary classes are defined elsewhere
        private static readonly DateTime REFERENCE_EVEN_FRIDAY = Constants.BIWEEKLY_PAYMENT_SCHEDULE_REFERENCE_FRIDAY;
        private static readonly DateTime ODD_FRIDAY = REFERENCE_EVEN_FRIDAY.AddDays(7);
        private static readonly DateTime NEXT_EVEN_FRIDAY = REFERENCE_EVEN_FRIDAY.AddDays(14);
        private static readonly DateTime NEXT_ODD_FRIDAY = REFERENCE_EVEN_FRIDAY.AddDays(21);

        Mock<BiWeeklyPaymentSchedule> biWeeklyPaymentSchedule = null;
        BiWeeklyPaymentSchedule bwPs = null;

        [SetUp]
        public void SetUp()
        {
            Mock<BiWeeklyPaymentSchedule> biWeeklyPaymentSchedule = new Mock<BiWeeklyPaymentSchedule>();
            bwPs = biWeeklyPaymentSchedule.Object;
        }

        [Test]
        public void isPaydayOnNotFridays_ShouldBeFalse()
        {
            Assert.That(bwPs.isPayDate(ODD_FRIDAY.AddDays(1)), Is.EqualTo(false));
            Assert.That(bwPs.isPayDate(ODD_FRIDAY.Subtract(TimeSpan.FromDays(1))), Is.EqualTo(false));
        }


        [Test]
        public void isPaydayOnEvenFridays_ShouldBeTrue()
        {
            Assert.That(bwPs.isPayDate(REFERENCE_EVEN_FRIDAY), Is.EqualTo(true));
            Assert.That(bwPs.isPayDate(NEXT_EVEN_FRIDAY), Is.EqualTo(true));
        }


        [Test]
        public void isPaydayOnOddFridays_ShouldBeFalse()
        {
            Assert.That(bwPs.isPayDate(ODD_FRIDAY), Is.EqualTo(false));
            Assert.That(bwPs.isPayDate(NEXT_ODD_FRIDAY), Is.EqualTo(false));
        }


        [Test]
        public void getIntervalOnAnEvenFriday()
        {
            DateInterval dateInterval = bwPs.getPayInterval(NEXT_EVEN_FRIDAY);
            Assert.That(dateInterval.from, Is.EqualTo(REFERENCE_EVEN_FRIDAY.AddDays(1)));
            Assert.That(dateInterval.to, Is.EqualTo(NEXT_EVEN_FRIDAY));
        }


        [Test]
        public void testGetNextPayday()
        {
            Assert.That(bwPs.getSameOrNextPayDate(REFERENCE_EVEN_FRIDAY), Is.EqualTo(REFERENCE_EVEN_FRIDAY));
            Assert.That(bwPs.getSameOrNextPayDate(REFERENCE_EVEN_FRIDAY.AddDays(1)), Is.EqualTo(NEXT_EVEN_FRIDAY));
            Assert.That(bwPs.getSameOrNextPayDate(ODD_FRIDAY), Is.EqualTo(NEXT_EVEN_FRIDAY));
            Assert.That(bwPs.getSameOrNextPayDate(NEXT_EVEN_FRIDAY), Is.EqualTo(NEXT_EVEN_FRIDAY));

        }
    }
}
