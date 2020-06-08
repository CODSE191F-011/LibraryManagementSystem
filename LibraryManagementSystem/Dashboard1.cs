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
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            SubMem.Visible = false;
            SubBoo.Visible = false;
            SubSupp.Visible = false;
        }
        private void hideSubmenu()
        {
            if (SubMem.Visible == true)
            {
                SubMem.Visible = false;
            }
            if (SubBoo.Visible == true)
            {
                SubBoo.Visible = false;
            }
            if (SubSupp.Visible == true)
            {
                SubSupp.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMem);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //Region Members
        private void btnMembers_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnMemManage_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        //Region Books
        private void btnBook_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            showSubMenu(SubSupp);
        }

        private void btnBoo_Click(object sender, EventArgs e)
        {
            showSubMenu(SubBoo);
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            openChild1(new Supp());
            hideSubmenu();
        }

        private void btnPurch_Click(object sender, EventArgs e)
        {
            //openChild1(new From());
            hideSubmenu();
        }
        private Form activeForm = null;
        private void openChild1(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            child1.Controls.Add(childForm);
            child1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
