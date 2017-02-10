using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    public class ReservationsCreator
    {
        public static int[] ComputeDaysDistances(Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> weekSchedule)
        {
            int[] weekScheduleDays = Array.ConvertAll(weekSchedule.Keys.ToArray(), item => Convert.ToInt32(item));
            int[] weekScheduleDaysDistances = new int[weekSchedule.Keys.Count];

            for (int j = 0; j < weekScheduleDaysDistances.Length; j++)
            {
                if (j == weekScheduleDaysDistances.Length - 1)
                {
                    weekScheduleDaysDistances[j] = 7 - weekScheduleDays[j] + weekScheduleDays[0];
                }
                else
                {
                    weekScheduleDaysDistances[j] = weekScheduleDays[j + 1] - weekScheduleDays[j];
                }
            }

            return weekScheduleDaysDistances;
        }

        private static reservations CreateSingleReservation(employees creator, facilities facility, DateTime date, Tuple<DateTime, DateTime> timePeroid = null, trainings training = null, admins admin = null, bool? accepted = null, events orgranisedEvent = null, ICollection<schedules> schedules = null)
        {
            reservations newReservation = new reservations();          
            newReservation.admins = admin;
            newReservation.employees = creator;
            newReservation.events = orgranisedEvent;
            newReservation.facilities = facility;
            newReservation.schedules = schedules;
            newReservation.trainings = training;
            newReservation.START = ((date.AddHours(timePeroid.Item1.Hour)).AddMinutes(timePeroid.Item1.Minute));
            newReservation.END = ((date.AddHours(timePeroid.Item2.Hour)).AddMinutes(timePeroid.Item2.Minute));
            newReservation.ACCEPTED = accepted; 
            return newReservation;
        }


        public static IEnumerable<reservations> Create(Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> weekSchedule, ReservationRequestEventArgs requestData, employees creator, trainings training, facilities facility)
        {
            int[] weekScheduleDaysDistances = ComputeDaysDistances(weekSchedule);
            List<reservations> reservations = new List<reservations>();
            DateTime currentDate = requestData.Start;

            //set date pointer to first day from weekSchedule
            while (currentDate.DayOfWeek != weekSchedule.Keys.First() && currentDate <= requestData.End)
            {
                try
                {
                    var timePeriod = weekSchedule[currentDate.DayOfWeek];
                    reservations.Add(CreateSingleReservation(creator, facility, currentDate, timePeriod, training));
                }
                catch (Exception ex)
                {
                    //TODO: implement handlers of exceptions occured while inserting to database
                }
                finally
                {
                    currentDate = currentDate.AddDays(1.00);
                }              
            }


            int i = 0;
            //main algorithm
            while (currentDate <= requestData.End)
            {
                try
                {
                    var timePeriod = weekSchedule[currentDate.DayOfWeek];
                    reservations.Add(CreateSingleReservation(creator, facility, currentDate, timePeriod, training));                   
                }
                catch (Exception ex)
                {
                    //when week schedule doesnt contain key
                }
                finally
                {
                    currentDate = currentDate.AddDays(weekScheduleDaysDistances[i++ % weekScheduleDaysDistances.Length]);
                }

            }
            return reservations;
        }
    }
}
