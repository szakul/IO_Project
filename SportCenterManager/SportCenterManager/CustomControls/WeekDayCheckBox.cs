using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{

    public class WeekDayCheckBox : System.Windows.Forms.CheckBox
    {
        public DayOfWeek AssociatedDay { get; set; }
    }

}
