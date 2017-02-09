using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCenterManager
{
    public partial class CoachWindow : Form
    {
        private CoachWindowData data;


        public CoachWindow(CoachWindowData data)
        {
            this.data = data;
            InitializeComponent();
        }

        public void displayFacilities()
        {
            foreach (facilities facility in data.Facilities)
            {
                this.facilityComboBox.Items.Add(facility.NAME);
            }
            test();
        }

        private void BindEvents()
        {
            
        }

        private void test()
        {
            IEnumerable<CheckBox> a = (IEnumerable<CheckBox>)weekDayPanel.Controls;
            ;
            ;

             
        }


        private void OnReservationRequest()
        {
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            int facilityListIndex = facilityComboBox.SelectedIndex;
            DateTime start = fromDatePicker.Value;
            DateTime end = toDatePicker.Value;
            ReservationRequestEventArgs e = new ReservationRequestEventArgs(name, description, facilityListIndex, start, end);
        }

        public delegate void ReservationRequestEventHandler(object sender, ReservationRequestEventArgs e);
        public event ReservationRequestEventHandler ReservationRequested;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
