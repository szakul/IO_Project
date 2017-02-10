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
            data = new CoachWindowData(GetFacilities());
            view = new CoachWindow(data);
            view.displayFacilities();
            view.ReservationRequested += ReportReservation;
        }

        private void CreateNewTraining()
        {

        }

        private void ReportReservation(object sender, ReservationRequestEventArgs requestData)
        {
            trainings training1 = new trainings();
            training1.NAME = requestData.Name;
            training1.DESCRIPTION = requestData.Description;

            trainings training = new trainings();
            training.NAME = requestData.Name;
            training.DESCRIPTION = requestData.Description;

            using (var context = new DatabaseConnection())
            {
                context.trainings.Add(training);
                context.trainings.Add(training1);
            }
        }

        public List<facilities> GetFacilities()
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
