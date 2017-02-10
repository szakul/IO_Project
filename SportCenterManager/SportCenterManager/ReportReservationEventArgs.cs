﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    public class ReservationRequestEventArgs
    {
        public string Name { get; }
        public string Description { get; }
        public int FacilityListIndex { get; }
        public Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> WeekSchedule { get; }
        public DateTime Start { get; }
        public DateTime End { get; }

        public ReservationRequestEventArgs(string name, string description, int facilityListIndex, DateTime start, DateTime end, Dictionary<DayOfWeek, Tuple<DateTime, DateTime>> weekSchedule)
        {
            Name = name;
            Description = description;
            Start = start;
            End = end;
            WeekSchedule = weekSchedule;
        }
    }
}
