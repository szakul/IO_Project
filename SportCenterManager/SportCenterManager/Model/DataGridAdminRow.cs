using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenterManager
{
    public class DataGridAdminRow : DataGridRow
    {
        public string Type { get; }
        public DataGridAdminRow(int id, string type, string trainingName, string facilityName, bool? accepted, DateTime? start, DateTime? end) : base(id, trainingName, facilityName, accepted, start, end)
        {
            Type = type;
        }
    }
}
