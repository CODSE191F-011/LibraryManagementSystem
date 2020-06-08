using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new StartScreen());
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard da = new DashBoard();
            da.Show();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblforgot_click(object sender, EventArgs e)
        {
            UForgotSys fr= new UForgotSys();
            this.Hide();
            fr.Show();
        }
    }
}
