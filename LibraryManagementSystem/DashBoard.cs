﻿using LibraryManagementSystem.Views;
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

        }

        private void formfade(object sender, EventArgs e)
        {
           
        }

        private void Mshow(object sender, EventArgs e)
        {

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
           // SidePanel.Height = btnSupp.Height;
            //SidePanel.Top = btnSupp.Top;
            showSubMenu(SubSupp);
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMem);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void supplier1_Load(object sender, EventArgs e)
        {

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
        // Region Books
        private void btnBook_Click(object sender, EventArgs e)
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
        //Region Supplier
        private void btnSup_Click(object sender, EventArgs e)
        {
            openChild1(new Supp());
            hideSubmenu();
            
        }

        private void btnPurch_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            showSubMenu(SubBoo);
        }

        private void SubSupp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBoo_Click(object sender, EventArgs e)
        {
            showSubMenu(SubBoo);
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            showSubMenu(SubSupp);
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void child1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
