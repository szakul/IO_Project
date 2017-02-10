using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenterManager
{
    public partial class CoachWindow : Form
    {
        private CoachWindowData data;


        public CoachWindow(CoachWindowData data)
        {
            this.data = data;
            InitializeComponent();
            BindEvents();
        }

        public void displayFacilities()
        {
            foreach (facilities facility in data.Facilities)
            {
                this.facilityComboBox.Items.Add(facility.NAME);
            }
        }

        private void BindEvents()
        {
            reportReservationButton.Click += OnReportReservationButtonClick;
        }

        private Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> GetWeekSchedule()
        {
            Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> weekSchedule = new Dictionary<DayOfWeek, Tuple<DateTime, DateTime>>();
            Array daysOfWeek = Enum.GetValues(typeof(DayOfWeek));

            for (int i = 0; i < weekDayPanel.Controls.Count; i++)
            {
                Tuple<DateTime, DateTime> timePeriod;
                CheckBox checkbox = weekDayPanel.Controls[i] as CheckBox;
                if (checkbox != null)
                {
                    if (checkbox.Checked)
                    {
                        DateTime start = DateTime.MinValue;
                        DateTime end = DateTime.MinValue;

                        var datePicker = startTimePanel.Controls[i] as DateTimePicker;
                        if (datePicker != null)
                        {
                            start = datePicker.Value;
                        }
                        datePicker = endTimePanel.Controls[i] as DateTimePicker;
                        if (datePicker != null)
                        {
                            end = datePicker.Value;
                        }
                        timePeriod = new Tuple<DateTime, DateTime>(start, end);
                        weekSchedule.Add((DayOfWeek)daysOfWeek.GetValue(i), timePeriod);
                    }
                }
            }
            return weekSchedule;
        }


        private void OnReportReservationButtonClick(object sender, EventArgs args)
        {
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            int facilityListIndex = facilityComboBox.SelectedIndex;
            DateTime start = fromDatePicker.Value;
            DateTime end = toDatePicker.Value;
            Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> weekSchedule = GetWeekSchedule();

            ReservationRequestEventArgs eventArgs = new ReservationRequestEventArgs(name, description, facilityListIndex, start, end, weekSchedule);
            ReservationRequested.Invoke(sender, eventArgs);
        }

        public delegate void ReservationRequestEventHandler(object sender, ReservationRequestEventArgs e);
        public event ReservationRequestEventHandler ReservationRequested;
    }
}
