using CSMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenAndSeat = CSMS.DTO.ScreenAndSeat;

namespace CSMS
{
    public partial class frmSreenManaging : Form
    {
        public frmSreenManaging()
        {
            InitializeComponent();
        }

        private void frmSreenManaging_Load(object sender, EventArgs e)
        {
            LoadCb();
        }

        #region seat
        public void LoadSeat(String ScreenName, String TheaterName)
        {
            flpSeat.Controls.Clear();
            List<ScreenAndSeat> screenList = ScreenDAL.Instance.getListSeat(ScreenName, TheaterName);
            String convert = "";
            foreach(ScreenAndSeat item in screenList)
            {
                Button btn = new Button() { Width = ScreenDAL.seatWidth, Height = ScreenDAL.seatHeight };
                switch(item.SoCot)
                {
                    case 1:
                        convert = "A";
                        break;
                    case 2:
                        convert = "B";
                        break;
                    case 3:
                        convert = "C";
                        break;
                    case 4:
                        convert = "D";
                        break;
                    case 5:
                        convert = "E";
                        break;
                    case 6:
                        convert = "F";
                        break;
                    case 7:
                        convert = "G";
                        break;
                    case 8:
                        convert = "H";
                        break;
                    case 9:
                        convert = "J";
                        break;
                    case 10:
                        convert = "K";
                        break;
                }
                btn.Text = convert.ToString() + item.SoHang.ToString();
                btn.Tag = item;
                btn.Image = Image.FromFile("F:\\Hoctap\\Cong nghe phan mem\\icon\\couch-solid.png");
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0; 

                btn.ImageAlign = ContentAlignment.TopCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;

                switch (item.TinhTrang)
                {
                    case 1:
                        btn.BackColor = Color.LightCyan;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        btn.Image = Image.FromFile("F:\\Hoctap\\Cong nghe phan mem\\icon\\couch-solid-yellow.png");
                        break;
                }
                flpSeat.Controls.Add(btn);
            }
            
        }
        #endregion

        #region combobox
        private void LoadCb()
        {
            LoadCbTheater();
            LoadCbScreenChanged();
        }

        private void LoadCbTheater()
        {
            cbTheater.DataSource = TheaterDAL.Instance.getTheaterList();
            cbTheater.DisplayMember = "TENRAP";
        }

        private void cbTheater_SelectedIndexChanged(object sender, EventArgs e)
        {

            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;
            cbScreen.DataSource = ScreenDAL.Instance.getListScreenByName(theaterValue);
            cbScreen.DisplayMember = "TENPHONGCHIEU";
            LoadSeat(screenValue, theaterValue);
        }

        private void LoadCbScreenChanged()
        {
            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;
            LoadSeat(screenValue, theaterValue);
        }

        private void LoadCbScreen()
        {
            string theaterValue = cbTheater.Text;
            cbScreen.DataSource = ScreenDAL.Instance.getListScreenByName(theaterValue);
            cbScreen.DisplayMember = "TENPHONGCHIEU";
        }

        private void cbScreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;
            LoadSeat(screenValue, theaterValue);
        }



        #endregion

        private void btnAddCinema_Click(object sender, EventArgs e)
        {
            string theaterName = cbTheater.Text;
            string screenInsertName = tbScreenInsertName.Text;
            int TheaterId = ScreenDAL.Instance.getTheaterIdByName(theaterName);
            ScreenDAL.Instance.screenInsert(screenInsertName, TheaterId);
            cbScreen.DataSource = ScreenDAL.Instance.getListScreenByName(theaterName);
            cbScreen.DisplayMember = "TENPHONGCHIEU";
        }

        private void btnSeatAdd_Click(object sender, EventArgs e)
        {
            string theaterName = cbTheater.Text;
            int TheaterId = ScreenDAL.Instance.getTheaterIdByName(theaterName);
            string screenName = cbScreen.Text;
            int screenId = ScreenDAL.Instance.getIdByScreenNameAndTheaterId(screenName, TheaterId);

            for (int i = 1; i <= 4; i++)
            {
                ScreenDAL.Instance.InsertScreenSeat(i, screenId);
            }
            LoadSeat(screenName, theaterName);
        }

        private void btnDeleteScreen_Click(object sender, EventArgs e)
        {
            string theaterName = cbTheater.Text;
            int TheaterId = ScreenDAL.Instance.getTheaterIdByName(theaterName);
            string screenName = cbScreen.Text;
            int screenId = ScreenDAL.Instance.getIdByScreenNameAndTheaterId(screenName, TheaterId);
            ScreenDAL.Instance.deleteScreenAndSeatById(screenId);
            LoadCbScreen();
        }
    }
}
