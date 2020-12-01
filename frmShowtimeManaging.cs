using CSMS.DAL;
using CSMS.DTO;
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
    public partial class frmShowtimeManaging : Form
    {
        BindingSource showtimeList = new BindingSource();
        public frmShowtimeManaging()
        {
            InitializeComponent();
            dtpShowtime.Format = DateTimePickerFormat.Custom;
            dtpShowtime.CustomFormat = "HH:mm";
            dtpShowtime.ShowUpDown = true;
            dtpShowtimeDate.Format = DateTimePickerFormat.Custom;
            dtpShowtimeDate.CustomFormat = "dd-MM-yyyy";
            dtpShowtimeDate.ShowUpDown = true;
        }


        private void frmShowtimeManaging_Load(object sender, EventArgs e)
        {
            LoadCb();
            Loaddtgv();
            AddDataBinding();
            mummyTextbox.Visible = false;
        }


        #region dtgv
        public void Loaddtgv()
        {
            dtgvShowtime.DataSource = showtimeList;
            LoadListTheater();
        }

        public void AddDataBinding()
        {
            AddShowtimeBinding();
        }

        void AddShowtimeBinding()
        {
            cbTheater.DataBindings.Add(new Binding("Text", dtgvShowtime.DataSource, "TENRAP", true, DataSourceUpdateMode.Never));
            cbScreen.DataBindings.Add(new Binding("Text", dtgvShowtime.DataSource, "TENPHONGCHIEU", true, DataSourceUpdateMode.Never));
            cbMovie.DataBindings.Add(new Binding("Text", dtgvShowtime.DataSource, "TENPHIM", true, DataSourceUpdateMode.Never));
            dtpShowtime.DataBindings.Add(new Binding("Text", dtgvShowtime.DataSource, "GIOCHIEU", true, DataSourceUpdateMode.Never));
            dtpShowtimeDate.DataBindings.Add(new Binding("Text", dtgvShowtime.DataSource, "NGAYCHIEU", true, DataSourceUpdateMode.Never));
            mummyTextbox.DataBindings.Add(new Binding("Text", dtgvShowtime.DataSource, "MALICHCHIEU", true, DataSourceUpdateMode.Never));
        }

        void LoadListTheater()
        {
            showtimeList.DataSource = ShowtimeDAL.Instance.getShowtimeList();

            this.dtgvShowtime.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvShowtime.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvShowtime.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvShowtime.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvShowtime.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvShowtime.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dtgvShowtime.Columns[3].DefaultCellStyle.Format = "yyyy-M-dd";
            this.dtgvShowtime.Columns[4].DefaultCellStyle.Format = "HH:mm";

            this.dtgvShowtime.Columns[0].HeaderText = "TÊN PHIM";
            this.dtgvShowtime.Columns[1].HeaderText = "TÊN RẠP";
            this.dtgvShowtime.Columns[2].HeaderText = "TÊN PHÒNG CHIẾU";
            this.dtgvShowtime.Columns[3].HeaderText = "NGÀY CHIẾU";
            this.dtgvShowtime.Columns[4].HeaderText = "GIỜ CHIẾU";
            this.dtgvShowtime.Columns[5].Visible = false;

        }

        #endregion

        #region combobox
        private void LoadCb()
        {
            LoadCbTheater();
            LoadCbScreen();
            LoadCbMovie();
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
        }

        private void LoadCbScreenChanged()
        {
            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;
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
        }

        private void LoadCbMovie()
        {
            cbMovie.DataSource = MoviesDAL.Instance.getListMovies();
            cbMovie.DisplayMember = "TENPHIM";
        }



        #endregion

        #region button
        private void btnAddShowtime_Click(object sender, EventArgs e)
        {
            int movieId = MoviesDAL.Instance.getmovieIdByName(cbMovie.Text);
            int screenId = ShowtimeDAL.Instance.getscreenIdByTheaterNameAndScreenName(cbTheater.Text, cbScreen.Text);
            string get_date = dtpShowtimeDate.Value.ToString("yyyy-M-dd");
            string showtime_hour = dtpShowtime.Value.ToString("HH:mm");
            ShowtimeDAL.Instance.insertShowtime(get_date, showtime_hour, movieId, screenId);
            Loaddtgv();
        }

        private void btnDeleteShowtime_Click(object sender, EventArgs e)
        {

            int showtimeId = int.Parse(mummyTextbox.Text);
            List<int> getTicket = TicketDAL.Instance.GetTicketIdByShowtimeId(showtimeId);
            foreach (int ticket in getTicket)
            {
                ServicesDAL.Instance.DeleteDetailServiceByTicketd(ticket);
            }
            ShowtimeDAL.Instance.DeleteDetailShowtimeByShowtimeId(showtimeId);
            TicketDAL.Instance.DeleteTicketByShowtimeId(showtimeId);
            ShowtimeDAL.Instance.DeleteShowtimeByShowtimeId(showtimeId);
            Loaddtgv();

        }

        private void btnEditShowtime_Click(object sender, EventArgs e)
        {
            try
            {
                int showtimeId = int.Parse(mummyTextbox.Text);
                int movieId = MoviesDAL.Instance.getmovieIdByName(cbMovie.Text);
                int screenId = ShowtimeDAL.Instance.getscreenIdByTheaterNameAndScreenName(cbTheater.Text, cbScreen.Text);
                string showtime_date = dtpShowtimeDate.Value.ToString("yyyy-M-dd");
                string showtime_hour = dtpShowtime.Value.ToString("HH:mm");
                ShowtimeDAL.Instance.editShowtime(showtime_date, showtime_hour, movieId, screenId, showtimeId);
                Loaddtgv();
            }
            catch
            {
                MessageBox.Show("Có lỗi", "Lỗi");
            }
        }
        #endregion

    }




}

















