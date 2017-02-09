using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    public class CoachWindowData
    {
        public List<facilities> Facilities { get; set; }

        public CoachWindowData(List<facilities> facilities)
        {
            this.Facilities = facilities;
        }
    }
}
