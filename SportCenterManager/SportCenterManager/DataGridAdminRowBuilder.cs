using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    class DataGridAdminRowBuilder : DataGridRowsBuilder
    {
        public IList<DataGridAdminRow> LoadFromDatabase(DatabaseConnection context, int? creatorId = default(int?))
        {
            IList<DataGridAdminRow> rowsList = new List<DataGridAdminRow>();
            var reservationList = context.reservations.ToList();
            foreach (reservations reservation in reservationList)
            {
                string type;
                string name;
                if(reservation.TRAINING_ID == null)
                {
                    events event_ = context.events.Where(i => i.ID == reservation.EVENT_ID).FirstOrDefault();
                    type = "event";
                    name = event_.NAME;
                } else
                {
                    trainings training = context.trainings.Where(i => i.ID == reservation.TRAINING_ID).FirstOrDefault();
                    type = "training";
                    name = training.NAME;
                }
                facilities facility = context.facilities.Where(i => i.ID == reservation.FACILITY_ID).FirstOrDefault();
                DataGridAdminRow row = new DataGridAdminRow(id: reservation.ID, type: type, facilityName: facility?.NAME, trainingName: name, accepted: reservation.ACCEPTED, start: reservation.START, end: reservation.END);
                rowsList.Add(row);
            }
            return rowsList;
        }
    }
}
