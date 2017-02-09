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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
            BindEvents();
        }

        public void BindEvents()
        {
            this.signButton.Click += OnSignButtonClick;
        }

        public void OnSignButtonClick(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            SignInRequest.Invoke(sender, new SignInRequestEventArgs(login, password));
        }


        public delegate void SignInRequestEventHandler(object sender, SignInRequestEventArgs e);
        public event SignInRequestEventHandler SignInRequest;
    }
}
