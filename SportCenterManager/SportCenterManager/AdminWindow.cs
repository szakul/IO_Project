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
        public AdminWindow()
        {
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
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int currentAccountId = 1; //Admin with this id MUST exist in db.
            try
            {
                events newEvent = new events();
                reservations newReservation = new reservations();
                newEvent.NAME = textBoxEventName.Text;
                newEvent.DESCRIPTION = textBoxEventDescription.Text;
                newEvent.CREATOR_ID = currentAccountId;

                newReservation.CREATOR_ID = currentAccountId;
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
    }
}
