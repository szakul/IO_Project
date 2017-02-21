using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCenterManager
{
    public class AdminWindowControler : Controller
    {
        AdminWindow view;
        public override void CloseView()
        {
            view.Close();
        }

        public override void ShowView()
        {
            view.Visible = true;
        }
        public AdminWindowControler(accounts account)
        {
            view = new AdminWindow(account);
            view.FormClosed += ReturnControl;
            view.LogOutRequest += (object sender, EventArgs e) => { CloseView(); ReturnControl(sender, e); };
        }
    }
}
