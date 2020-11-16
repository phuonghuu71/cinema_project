using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS
{
    public partial class frmMainInterface : Form
    {
        public frmMainInterface()
        {
            InitializeComponent();
            customizeDesign();
        }
        #region submenu_design

        //hide your sub menu
        private void customizeDesign()
        {
            panelStaffInfo.Visible = false;
            panelAdmin.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelStaffInfo.Visible == true)
                panelStaffInfo.Visible = false;
        }

        //show your sub menu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region show_subform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region admin
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdmin);
        }
        #endregion

        #region booking
        private void btnBooking_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBooking());
        }
        #endregion

        #region staff_info
        private void btnStaffInfo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStaffInfo);
        }
        #endregion

        #region change_information
        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region change_password
        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            openChildForm(new frmChangePwd());
        }
        #endregion

        #region movie_managing
        private void btnMovieManager_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMovieManaging());
        }
        #endregion

        #region exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region movie_list
        private void btnMovieList_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMovieList());
        }
        #endregion

        #region screen_managing
        private void btnScreenManaging_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSreenManaging());
        }

        #endregion

        #region theater_managing
        private void btnTheaterManaging_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTheaterManaging());
        }
        #endregion

        #region showtime_managing
        private void btnShowtimeManaging_Click(object sender, EventArgs e)
        {
            openChildForm(new frmShowtimeManaging());
        }
        #endregion
    }
}
