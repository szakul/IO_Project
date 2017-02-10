using SportCenterManager;
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
            SubscribeWindowEvents();
            view.DisplayContent();
        }

        private void SubscribeWindowEvents()
        {
            view.ReservationRequested += ReportReservation;
            view.WeekScheduleChange += ChangeWeekSchedule;
        }



        private void ChangeWeekSchedule(object sender, WeekScheduleChangedEventArgs eventArgs)
        {
            model.ChangeWeekSchedule(eventArgs);
            view.DisplayWeekSchedule();
        }

       


        private void ReportReservation(object sender, ReservationRequestEventArgs requestData)
        {

        }


    }
}
