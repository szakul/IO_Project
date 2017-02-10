using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenterManager
{
    public class WeekScheduleChangedEventArgs
    {
        public Control.ControlCollection StartTimePanel { get; }
        public Control.ControlCollection EndTimePanel { get; }
        public Control.ControlCollection WeekDayPanel { get; }

        public WeekScheduleChangedEventArgs(Panel weekDayPanel, Panel startTimePanel, Panel endTimePanel)
        {
            WeekDayPanel = weekDayPanel.Controls;
            StartTimePanel = startTimePanel.Controls;
            EndTimePanel = endTimePanel.Controls;
        }
    }
}
