using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenterManager
{

    class LoginWindowController : Controller
    {
        public LoginWindow View { get; }
        private accounts account = null;
        private bool switchToAdminPanel = false;
        private bool switchToCoachPanel = false;

        public LoginWindowController()
        {
            View = new LoginWindow();
            SubscribeWindowEvents();
        }

        private void SubscribeWindowEvents()
        {
            View.SignInRequest += OnSignInRequest;
        }

        private bool IsCoachAccount(int employeeId, DatabaseConnection context)
        {
            var coachesIdList = context.coaches.Where(i => i.EMPLOYEE_ID == employeeId).Select(i => i.ID);
            return (coachesIdList.Count() > 0) ? true : false;
        }

        private bool IsAdminAccount(int employeeId, DatabaseConnection context)
        {
            var adminsIdList = context.admins.Where(i => i.EMPLOYEE_ID == employeeId).Select(i => i.ID);
            return (adminsIdList.Count() > 0) ? true : false;
        }

        private bool IsPasswordValid(accounts account, string password, DatabaseConnection context)
        {
            return (account.PASSWORD == password) ? true : false;
        }

        private void SwitchController()
        {
            Controller newController = null;

            if (switchToCoachPanel)
            {
                newController = new CoachWindowController(account);
            }
            else if (switchToAdminPanel)
            {
                throw new NotImplementedException();
                //TODO: switch to admin panel
            }

            newController.ShowView();
            newController.ReturnControlRequest += OnReturnControl;

            switchToAdminPanel = false;
            switchToCoachPanel = false;
            account = null;
        }

        private void OnReturnControl(object sender, EventArgs e)
        {
            View.Visible = true; //Login window is active again
        }

        private void OnSignInRequest(object sender, SignInRequestEventArgs e)
        {
            if(IsAccountValid(e.Login, e.Password))
            {
                View.Visible = false;
                SwitchController();
            }
        }

        public override void CloseView()
        {
            View.Close();
        }

        public override void ShowView()
        {
            View.Show();
        }

        private bool IsAccountValid(string login, string password)
        {
            try
            {
                using (var context = new DatabaseConnection())
                {
                    accounts account = context.accounts.Where(i => (i.LOGIN == login)).ToList().First();
                    if (IsPasswordValid(account, password, context))
                    {
                        employees employee = context.employees.Find(account.ID);
                        if (employee != null) // Employee found
                        {
                            this.account = account;
                            switchToAdminPanel = IsAdminAccount(employee.ID, context);
                            switchToCoachPanel = IsCoachAccount(employee.ID, context);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Account not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return switchToAdminPanel || switchToCoachPanel;
        }
    }
}
