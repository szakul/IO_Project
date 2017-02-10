using SportCenterManager;
using SportCenterManager.Exceptions;
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
        private CoachWindowModel model;

        public CoachWindow View
        {
            get
            {
                return view;
            }
        }

        public CoachWindowController()
        {
            model = new CoachWindowModel();
            view = new CoachWindow(model);
           
            //Change this later, so controller will be getting account as parameter
            using (var context = new DatabaseConnection())
            {
                model.Account = context.accounts.Where(i => i.ID == 2).ToList().First();
            }

            model.UpdateReservations();
            view.SetReservationsDataSource(model.Reservations);
            view.DisplayContent();
            SubscribeWindowEvents();
        }

        private void SubscribeWindowEvents()
        {
            view.ReservationRequested += ReportReservation;
            view.WeekScheduleChange += ChangeWeekSchedule;
        }

        private void ChangeWeekSchedule(object sender, WeekScheduleChangedEventArgs weekScheduleChangeData)
        {
            model.ChangeWeekSchedule(weekScheduleChangeData);
            view.DisplayContent();
        }

        private void ReportReservation(object sender, ReservationRequestEventArgs requestData)
        {
            try
            {
                model.ReportReservation(requestData);
                model.UpdateReservations();
                view.SetReservationsDataSource(model.Reservations);
            }
            catch(FacilityNotChoosenException ex)
            {
                MessageBox.Show("Musisz wybrać obiekt na którym będą odbywały się zajęcia!");
            }
        }


    }
}
