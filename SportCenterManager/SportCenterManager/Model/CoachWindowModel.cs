using SportCenterManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenterManager
{
    public class CoachWindowModel
    {
        public List<facilities> Facilities { get; set; }
        public Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> WeekSchedule { get; set; }
        //public List<reservations> Reservations { get; set; }
        public accounts Account { get; set; }
        public IList<DataGridRow> DataGridItems { get; set; }


        public CoachWindowModel()
        {
            Facilities = GetFacilities();
            WeekSchedule = new Dictionary<DayOfWeek, Tuple<DateTime, DateTime>>();
        }

        public void UpdateDataGrid()
        {
            using (var context = new DatabaseConnection())
            {
                int? creatorId = context.employees.Where(i => i.ACCOUNT_ID == Account.ID).Select(i => i.ID).FirstOrDefault();
                DataGridRowsBuilder rowsCreator = new DataGridRowsBuilder();
                DataGridItems = rowsCreator.LoadFromDatabase(context, creatorId);             
            }
        }

        private trainings CreateNewTraining(string name, string description)
        {
            trainings training = new trainings();
            training.NAME = name;
            training.DESCRIPTION = description;

            return training;
        }

        public void ChangeWeekSchedule(WeekScheduleChangedEventArgs eventArgs)
        {
            var weekSchedule = new Dictionary<DayOfWeek, Tuple<DateTime, DateTime>>();
            Array daysOfWeek = Enum.GetValues(typeof(DayOfWeek));

            IEnumerable<WeekDayCheckBox> weekDayCheckBoxCollection = eventArgs.WeekDayPanel.Cast<WeekDayCheckBox>();
            IEnumerable<WeekDayHourPicker> startTimePickerCollection = eventArgs.StartTimePanel.Cast<WeekDayHourPicker>();
            IEnumerable<WeekDayHourPicker> endTimePickerCollection = eventArgs.EndTimePanel.Cast<WeekDayHourPicker>();

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Tuple<DateTime, DateTime> timePeriod;
                var weekDayCheckBox = weekDayCheckBoxCollection.Where(item => item.AssociatedDay == (DayOfWeek)daysOfWeek.GetValue(i)).FirstOrDefault();
                if (weekDayCheckBox != null)
                {
                    if (weekDayCheckBox.Checked)
                    {
                        DateTime start = DateTime.Now.Date;
                        DateTime end = DateTime.Now.Date;

                        var datePicker = startTimePickerCollection.Where(item => item.AssociatedDay == (DayOfWeek)daysOfWeek.GetValue(i)).FirstOrDefault();
                        if (datePicker != null)
                        {
                            start = datePicker.Value;
                        }
                        datePicker = endTimePickerCollection.Where(item => item.AssociatedDay == (DayOfWeek)daysOfWeek.GetValue(i)).FirstOrDefault();
                        if (datePicker != null)
                        {
                            end = datePicker.Value;
                        }

                        if (end > start)
                            throw new InvalidTimePeriodException();

                        timePeriod = new Tuple<DateTime, DateTime>(start, end);
                        weekSchedule.Add(weekDayCheckBox.AssociatedDay, timePeriod);
                    }
                }
            }
            WeekSchedule = weekSchedule;
        }



        private facilities GetFacility(int facilityListIndex, DatabaseConnection context)
        {
            try
            {
                int facilityId = Facilities[facilityListIndex].ID;
                facilities facility = context.facilities.Where(i => (i.ID == facilityId)).FirstOrDefault();
                return facility;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw new FacilityNotChoosenException();
            }
        }

        public void ReportReservation(ReservationRequestEventArgs requestData)
        {
            if (requestData.End < requestData.Start)
                throw new InvalidTimePeriodException();

            using (var context = new DatabaseConnection())
            {
                var creator = context.employees.Where(i => i.ACCOUNT_ID == Account.ID).FirstOrDefault();
                var training = CreateNewTraining(requestData.Name, requestData.Description);
                var facility = GetFacility(requestData.FacilityListIndex, context);
                var coach = context.coaches.Where(i => i.EMPLOYEE_ID == creator.ID).FirstOrDefault();
                coach.trainings.Add(training);

                IEnumerable<reservations> reservationsList = ReservationsCreator.Create(WeekSchedule, requestData, creator, training, facility);
                foreach (reservations reservation in reservationsList)
                {
                    context.reservations.Add(reservation);
                }

                context.SaveChanges();
            }
        }

        public List<facilities> GetFacilities()
        {
            List<facilities> facilitiesList = null;
            using (var context = new DatabaseConnection())
            {
                facilitiesList = context.facilities.ToList();
            }
            return facilitiesList;
        }
    }
}
