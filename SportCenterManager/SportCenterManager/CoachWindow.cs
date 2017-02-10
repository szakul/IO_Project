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
        private CoachWindowModel data;


        public CoachWindow(CoachWindowModel data)
        {
            this.data = data;
            InitializeComponent();
            BindEvents();
        }

        public void DisplayContent()
        {
            DisplayAccountInfo();
            displayFacilities();
            DisplayWeekSchedule();
        }

        public void DisplayAccountInfo()
        {
            if(data.Coach != null)
            {
                loginInfo.Text = data.Coach.employees.accounts.LOGIN;
            }          
        }

        public void DisplayWeekSchedule()
        {
            for (int i = 0; i < weekDayPanel.Controls.Count; i++)
            {
                Control control = weekDayPanel.Controls[i];
                var checkbox = control as WeekDayCheckBox;
                if (checkbox != null)
                {
                    var startHourPicker = startTimePanel.Controls[i] as WeekDayHourPicker;
                    var endHourPicker = endTimePanel.Controls[i] as WeekDayHourPicker;
                    DateTime startHour = DateTime.Now.Date;    
                    DateTime endHour = DateTime.Now.Date;
                    bool enable = false;

                    if (data.WeekSchedule.Keys.Contains(checkbox.AssociatedDay))
                    {
                        var timePeriod = data.WeekSchedule[checkbox.AssociatedDay];
                        startHour = timePeriod.Item1;
                        endHour = timePeriod.Item2;
                        enable = true;
                    }

                    startHourPicker.Value = startHour;
                    endHourPicker.Value = endHour;
                    startHourPicker.Enabled = enable;
                    endHourPicker.Enabled = enable;
                }
            }
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
            BindWeekSchedulePanelEvents(weekDayPanel, OnWeekScheduleChange);
            BindWeekSchedulePanelEvents(startTimePanel, OnWeekScheduleChange);
            BindWeekSchedulePanelEvents(endTimePanel, OnWeekScheduleChange);
        }

        private void BindWeekSchedulePanelEvents(Panel panel, EventHandler eventHandler)
        {
            foreach (Control control in panel.Controls)
            {
                var weekDayCheckBoxControl = control as WeekDayCheckBox;
                if (weekDayCheckBoxControl != null)
                {
                    weekDayCheckBoxControl.CheckedChanged += eventHandler;
                }
                var weekDayHourPickerControl = control as WeekDayHourPicker;
                if (weekDayHourPickerControl != null)
                {
                    weekDayHourPickerControl.ValueChanged += eventHandler;
                }
            }
        }


        private void OnWeekScheduleChange(object sender, EventArgs args)
        {
            WeekScheduleChange.Invoke(sender, new WeekScheduleChangedEventArgs(weekDayPanel, startTimePanel, endTimePanel));
        }

        private void OnReportReservationButtonClick(object sender, EventArgs args)
        {
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            int facilityListIndex = facilityComboBox.SelectedIndex;
            DateTime start = fromDatePicker.Value;
            DateTime end = toDatePicker.Value;

            ReservationRequestEventArgs eventArgs = new ReservationRequestEventArgs(name, description, facilityListIndex, start, end);
            ReservationRequested.Invoke(sender, eventArgs);
        }

        public delegate void WeekScheduleChangeEventHandler(object sender, WeekScheduleChangedEventArgs e);
        public delegate void ReservationRequestEventHandler(object sender, ReservationRequestEventArgs e);
        public event ReservationRequestEventHandler ReservationRequested;
        public event WeekScheduleChangeEventHandler WeekScheduleChange;

        private void weekDayHourPicker14_ValueChanged(object sender, EventArgs e)
        {

        }

        private void weekDayHourPicker11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void weekDayHourPicker9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void weekDayHourPicker10_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
