using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    public class DataGridRowsBuilder
    {
        public virtual IList<DataGridRow> LoadFromDatabase(DatabaseConnection context, int? creatorId = null)
        {
            IList<DataGridRow> rowsList = new List<DataGridRow>();
            var reservationList = context.reservations.Where(i => (creatorId != null) ? i.CREATOR_ID == creatorId : true).ToList();
            foreach (reservations reservation in reservationList)
            {
                trainings training = context.trainings.Where(i => i.ID == reservation.TRAINING_ID).FirstOrDefault();
                facilities facility = context.facilities.Where(i => i.ID == reservation.FACILITY_ID).FirstOrDefault();
                DataGridRow row = new DataGridRow(id: reservation.ID, facilityName: facility?.NAME, trainingName: training?.NAME, accepted: reservation.ACCEPTED, start: reservation.START, end: reservation.END);
                rowsList.Add(row);
            }
            return rowsList;
        }
    }
}
