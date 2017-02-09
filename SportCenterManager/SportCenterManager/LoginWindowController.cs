using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenterManager
{

    class LoginWindowController
    {
        public LoginWindow View { get; }
        private bool switchToAdminPanel = false;
        private bool switchToCoachPanel = false;

        public LoginWindowController()
        {
            View = new LoginWindow();
            SubscribeWindowEvents();
        }

        public void SubscribeWindowEvents()
        {
            View.SignInRequest += (object sender, SignInRequestEventArgs e) => { SignIn(e.Login, e.Password); SwitchController(); };
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
            if (switchToCoachPanel)
            {
                MessageBox.Show("swith to coach panel!");
                //TODO: swith to coach panel
            }
            else if (switchToAdminPanel)
            {
                MessageBox.Show(" switch to admin panel!");
                //TODO: switch to admin panel
            }

            switchToAdminPanel = false;
            switchToCoachPanel = false;
        }



        public void SignIn(string login, string password)
        {
            try
            {
                using (var context = new DatabaseConnection())
                {
                    accounts account = context.accounts.Where(i => (i.LOGIN == login)).First();
                    if (IsPasswordValid(account, password, context))
                    {
                        employees employee = context.employees.Find(account.ID);
                        if (employee != null) // Employee found
                        {
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
        }
    }
}
