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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int currentAccountId = 1; //Admin with this id MUST exist in db.
        //    try
        //    {
        //        events newEvent = new events();
        //        //newEvent.ID = ; u dont have to specify it. It'll be incremented automaticly
        //        newEvent.NAME = textBoxEventName.Text;
        //        newEvent.DESCRIPTION = textBoxEventDescription.Text;
        //        newEvent.CREATOR_ID = currentAccountId;
        //        using (var context = new osrodeksportowydbEntities2())
        //        {
        //            context.events.Add(newEvent);
        //            context.SaveChanges();
        //        }
        //    }catch(DbUpdateException ex)
        //    {
        //        //shuold be checked for nulls. And there is probably a better way to get DB exception.
        //        MessageBox.Show(ex.Message + "\n" + ex.InnerException.InnerException.Message);
        //    }
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseConnection())
            {
                var t = context.trainings.Find(1);
                textBoxEventName.Text = t.ID + " " + t.NAME + " " + t.DESCRIPTION;
            }
        }


    }
}
