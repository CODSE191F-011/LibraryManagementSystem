using LibraryManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            SidePanel.Height = btnSupplier.Height;
            SidePanel.Top = btnSupplier.Top;
            supplier1.BringToFront();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //FormFadeTransition1.HideAsyc(this, true);
        }

        private void btnSmenu_Click(object sender, EventArgs e)
        {
            //if(panelMenu.Visible)
            //{
             //   TransitionMenuHide.HideSync(panelMenu);
           // }
            //else
            //{
            //    TransitionMenu.ShowSync(panelMenu);
           // }
        }
        void showDrawer()
        {

        }
        void hideDrawer()
        {

        }

        private void formfade(object sender, EventArgs e)
        {
           
        }

        private void Mshow(object sender, EventArgs e)
        {

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSupplier.Height;
            SidePanel.Top = btnSupplier.Top;
            supplier1.BringToFront();
        }
    }
}
