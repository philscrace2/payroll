
//    using NUnit.Framework;
//    using System;

//    namespace YourNamespace
//    {
//        [TestFixture]
//        public class WeeklyPaymentScheduleTest
//        {
//            // Assuming DateInterval and other necessary classes are defined elsewhere

//            [Test]
//public void Test isPaydayOnFridays_ShouldBeTrue() throws Exception {
//		Assert.That(weeklyPaymentSchedule.isPayDate(THIS_FRIDAY), Is.EqualTo(true)));
//		Assert.That(weeklyPaymentSchedule.isPayDate(NEXT_FRIDAY), Is.EqualTo(true)));


//[Test]
//public void Test isPaydayOnNonFridays_ShouldBeFalse() throws Exception {
//		Assert.That(weeklyPaymentSchedule.isPayDate(THIS_MONDAY), Is.EqualTo(false)));
//		Assert.That(weeklyPaymentSchedule.isPayDate(PREV_SATURDAY), Is.EqualTo(false)));


//[Test]
//public void Test getIntervalOnAFriday() throws Exception {
//		DateInterval dateInterval = weeklyPaymentSchedule.getPayInterval(THIS_FRIDAY));
//		Assert.That(dateInterval.from, 	is(PREV_SATURDAY)));
//		Assert.That(dateInterval.to, 	is(THIS_FRIDAY)));


//[Test]
//public void Test testGetNextPayday() {
//		Assert.That(weeklyPaymentSchedule.getSameOrNextPayDate(PREV_SATURDAY), Is.EqualTo(THIS_FRIDAY)));
//		Assert.That(weeklyPaymentSchedule.getSameOrNextPayDate(THIS_FRIDAY), Is.EqualTo(THIS_FRIDAY)));
//		Assert.That(weeklyPaymentSchedule.getSameOrNextPayDate(THIS_FRIDAY.plusDays(1)), Is.EqualTo(NEXT_FRIDAY)));

//        }
//    }
