using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SportCenterManager;

/**
 * How to get this working:
 * 1. Tools -> NuGet Package Manager -> Package Manager Console -> (set default project to SportCenterManager.Tests) Install-Package NUnit
 * 2. Select SportCenterManager.Test from solution explorer. Add reference to SportCenterManager.Tests
 * 
 * How to run tests:
 * 1. Tools -> Extensions and updates -> install NUnit3 Test Adapter
 * 2. Restart Visual Studio
 * 3. View -> Test Explorer -> Run All
 * 
 **/

namespace ReservationCreatorTests
{
    [TestFixture]
    public class ReservationCreatorTests
    {

        public Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> CreateWeekScheduleMock(int[] weekDays)
        {
            Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> mock = new Dictionary<DayOfWeek, Tuple<DateTime, DateTime>>();
            Array weekDaysEnumArray = Enum.GetValues(typeof(DayOfWeek));

            for (int i = 0; i < weekDays.Length; i++)
            {
                mock.Add((DayOfWeek)weekDaysEnumArray.GetValue(weekDays[i]), null);
            }
            return mock;
        }


        [Test]
        public void ComputeDaysDistances_AllDays_Calculated()
        {
            int[] weekDays = { 0, 1, 2, 3, 4, 5, 6 };
            int[] expectedResult = { 1, 1, 1, 1, 1, 1, 1 };

            var result = ReservationsCreator.ComputeDaysDistances(CreateWeekScheduleMock(weekDays));

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(new int[] { 0, 4 }, new int[] { 4, 3 })]
        [TestCase(new int[] { 1, 3, 6 }, new int[] { 2, 3, 2 })]
        [TestCase(new int[] { 0, 4, 5 }, new int[] { 4, 1, 2 })]
        public void ComputeDaysDistances_OrdinaryCases_Calculated(int[] weekDays, int[] expectedResult)
        {
            var result = ReservationsCreator.ComputeDaysDistances(CreateWeekScheduleMock(weekDays));

            Assert.AreEqual(result, expectedResult);
        }
    }
}
