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
    class CoachWindowController : Controller
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

        public CoachWindowController(accounts account)
        {
            model = new CoachWindowModel();
            view = new CoachWindow(model);

            model.Account = account;
            model.UpdateDataGrid();
            view.SetDataGridsDataSource(model.DataGridItems);
            view.DisplayContent();
            SubscribeWindowEvents();
        }

        private void SubscribeWindowEvents()
        {
            view.ReservationRequest += ReportReservation;
            view.WeekScheduleChange += ChangeWeekSchedule;
            view.FormClosed += ReturnControl;
            view.LogOutRequest += (object sender, EventArgs e) => { CloseView(); ReturnControl(sender, e); };
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

        public override void ShowView()
        {
            View.Show();
        }

        public override void CloseView()
        {
            View.Close();
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
