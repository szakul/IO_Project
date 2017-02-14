using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    public class DataGridRow
    {
        public int Id { get; }
        public string TrainingName { get; }
        public string FacilityName { get; }
        public bool? Accepted { get; }
        public DateTime? Start { get; }
        public DateTime? End { get; }

        public DataGridRow(int id, string trainingName, string facilityName, bool? accepted, DateTime? start, DateTime? end)
        {
            Id = id;
            TrainingName = trainingName;
            FacilityName = facilityName;
            Accepted = accepted;
            Start = start;
            End = end;
        }
    }
}
