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

            model.UpdateDataGrid();
            view.SetDataGridsDataSource(model.DataGridItems);
            view.DisplayContent();
            SubscribeWindowEvents();
        }

        private void SubscribeWindowEvents()
        {
            view.ReservationRequest += ReportReservation;
            view.WeekScheduleChange += ChangeWeekSchedule;
            view.LogOutRequest += LogOut;
        }

        private void ChangeWeekSchedule(object sender, WeekScheduleChangedEventArgs weekScheduleChangeData)
        {
            try
            {
                model.ChangeWeekSchedule(weekScheduleChangeData);
            }
            catch (InvalidTimePeriodException ex)
            {
                MessageBox.Show("Proszę wybrać poprawny przedział czasu!");
            }
            finally
            {
                view.DisplayContent();
            }
        }

        private void LogOut(object sender, EventArgs eventArgs)
        {
            MessageBox.Show("qwqwq");
        }

        private void ReportReservation(object sender, ReservationRequestEventArgs requestData)
        {
            try
            {
                model.ReportReservation(requestData);
                model.UpdateDataGrid();
                view.SetDataGridsDataSource(model.DataGridItems);
            }
            catch (FacilityNotChoosenException ex)
            {
                MessageBox.Show("Musisz wybrać obiekt na którym będą odbywały się zajęcia!");
            }
            catch (InvalidTimePeriodException ex)
            {
                MessageBox.Show("Proszę wybrać poprawny przedział czasu!");
            }
        }


    }
}
