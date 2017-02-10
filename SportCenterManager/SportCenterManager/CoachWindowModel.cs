using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    public class CoachWindowModel
    {
        public List<facilities> Facilities { get; set; }
        public Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> WeekSchedule { get; set; }
        public coaches Coach { get; set; }

        public CoachWindowModel(List<facilities> facilities)
        {
            this.Facilities = facilities;
            this.WeekSchedule = new Dictionary<DayOfWeek, Tuple<DateTime, DateTime>>();
        }
    }
}
