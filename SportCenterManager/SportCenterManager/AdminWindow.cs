using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenterManager
{
    public partial class AdminWindow : Form
    {
        accounts currentAccount;
        public AdminWindow(accounts account)
        {
            currentAccount = account;
            InitializeComponent();
            //loads facilities to comboBox
            List<string> facilitiesEssence = new List<string>();
            using (var context = new DatabaseConnection())
            {
                var reservableFacilities = (from f in context.facilities
                                            where f.RESERVABLE == true
                                            select f).ToArray();
                foreach (facilities facility in reservableFacilities)
                {
                    facilitiesEssence.Add(facility.ID + ". " + facility.NAME);
                }
                comboBoxEventFacility.Items.AddRange(facilitiesEssence.ToArray());
                DataGridAdminRowBuilder dgarb = new DataGridAdminRowBuilder();
                dataGridView1.DataSource = dgarb.LoadFromDatabase(context);
            }
            buttonLogOut.Click += OnLogOutRequest;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                events newEvent = new events();
                reservations newReservation = new reservations();
                newEvent.NAME = textBoxEventName.Text;
                newEvent.DESCRIPTION = textBoxEventDescription.Text;
                newEvent.CREATOR_ID = currentAccount.ID;

                newReservation.CREATOR_ID = currentAccount.ID;
                newReservation.FACILITY_ID = int.Parse(comboBoxEventFacility.SelectedItem.ToString().Split('.')[0]);
                DateTime tmpDate = dateTimePickerEventDate.Value;
                DateTime tmpStartTime = dateTimePickerEventStart.Value;
                DateTime tmpEndTime = dateTimePickerEventEnd.Value;
                newReservation.START = tmpDate.Date.Add(tmpStartTime.TimeOfDay);
                newReservation.END = tmpDate.Date.Add(tmpEndTime.TimeOfDay);

                using (var context = new DatabaseConnection())
                {
                    context.events.Add(newEvent);
                    context.SaveChanges();
                    newReservation.EVENT_ID = newEvent.ID;
                    context.reservations.Add(newReservation);
                    context.SaveChanges();
                    MessageBox.Show("Event added");
                    DataGridAdminRowBuilder dgarb = new DataGridAdminRowBuilder();
                    dataGridView1.DataSource = dgarb.LoadFromDatabase(context);
                }
            }
            catch (DbUpdateException ex)
            {
                //shuold be checked for nulls. And there is probably a better way to get DB exception.
                MessageBox.Show(ex.Message + "\n" + ex.InnerException.InnerException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<int> getCheckedIds()
        {
            List<int> reservationIdsToAccept = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[Chosen.Name].Value) == true)
                {
                    reservationIdsToAccept.Add(Convert.ToInt32(row.Cells[idDataGridViewTextBoxColumn.Name].Value));
                }
            }
            return reservationIdsToAccept;
        }
        private void updateReservations(bool decision)
        {
            using (var context = new DatabaseConnection())
            {
                foreach (int id in getCheckedIds())
                {
                    context.reservations.Find(id).ACCEPTED = decision;
                    context.reservations.Find(id).ACCEPTER_ID = currentAccount.ID;
                }
                context.SaveChanges();
                DataGridAdminRowBuilder dgarb = new DataGridAdminRowBuilder();
                dataGridView1.DataSource = dgarb.LoadFromDatabase(context);
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            updateReservations(true);
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            updateReservations(false);
        }
        private void OnLogOutRequest(object sender, EventArgs args)
        {
            LogOutRequest.Invoke(this, EventArgs.Empty);
        }
        public event EventHandler LogOutRequest;
    }
}
