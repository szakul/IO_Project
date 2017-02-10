using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    class WeekDayHourPicker : System.Windows.Forms.DateTimePicker
    {
        public DayOfWeek AssociatedDay { get; set; }

        private void DefaultSettings()
        {
            this.CustomFormat = "HH:mm";
            this.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ShowUpDown = true;
        }

        public WeekDayHourPicker()
        {
            DefaultSettings();
        }
    }
}
