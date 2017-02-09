using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenterManager
{
    class CoachWindowController
    {
        private CoachWindow view;
        private CoachWindowData data;

        public CoachWindow View
        {
            get
            {
                return view;
            }
        }

        public CoachWindowController()
        {
            data = new CoachWindowData(getFacilities());
            view = new CoachWindow(data);
            view.displayFacilities();
        }

        public List<facilities> getFacilities()
        {
            List<facilities> facilitiesList = null;
            using (var context = new DatabaseConnection())
            {
                facilitiesList = context.facilities.ToList();
            }
            return facilitiesList;
        }
    }
}
