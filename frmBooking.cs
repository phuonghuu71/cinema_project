using CSMS.DAL;
using CSMS.DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;
using Image = System.Drawing.Image;

namespace CSMS
{
    public partial class frmBooking : Form
    {
        private int seatId;
        private int ticketId;
        private Decimal totalMoney;
        public frmBooking()
        {
            InitializeComponent();
        }


        private void frmBooking_Load(object sender, EventArgs e)
        {
            LoadCb();
        }

        #region seat
        public void LoadSeat(String ScreenName, String TheaterName)
        {
            //int showtimeId = ScreenDAL.Instance.getShowtimeIdByTimeBookingAndMovieBooking(cbTimeBooking.Text, cbMovieBooking.Text);
            flpSeat.Controls.Clear();
            List<ScreenAndSeat> screenList = ScreenDAL.Instance.getListSeat(ScreenName, TheaterName);
            String convert = "";
            foreach (ScreenAndSeat item in screenList)
            {
                Button btn = new Button() { Width = ScreenDAL.seatWidth, Height = ScreenDAL.seatHeight };
                switch (item.SoCot)
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
                }
                btn.Text = convert.ToString() + item.SoHang.ToString();
                btn.Tag = item;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += Btn_Click;

                btn.ImageAlign = ContentAlignment.TopCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;

                switch (ScreenDAL.Instance.seatExist(getShowtimeId(), item.MaGhe))
                {
                    case 1:
                        btn.BackColor = Color.Red;
                        btn.Image = Image.FromFile("couch-solid-yellow.png");
                        btn.Enter += Btn_Enter;
                        btn.Leave += Btn_Leave_exist;
                        break;
                    default:
                        btn.BackColor = Color.LightCyan;
                        btn.Image = Image.FromFile("couch-solid.png");
                        btn.Enter += Btn_Enter;
                        btn.Leave += Btn_Leave;
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
            LoadCbScreen();
            LoadCbMovie();
            LoadCbTimeBooking();
            LoadCbServices();
        }

        private void LoadCbTheater()
        {
            cbTheater.DataSource = TheaterDAL.Instance.getTheaterList();
            cbTheater.DisplayMember = "TENRAP";
        }

        private void cbTheater_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCbScreen();
            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;
            cbMovieBooking.Text = "";
            cbTimeBooking.Text = "";
            LoadCbMovie();
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
            string movieValue = cbMovieBooking.Text;
            cbMovieBooking.Text = "";
            cbTimeBooking.Text = "";
            LoadSeat(screenValue, theaterValue);
            LoadCbMovie();
        }

        private void LoadCbMovie()
        {
            try
            {
                string theaterValue = cbTheater.Text;
                string screenValue = cbScreen.Text;
                int screenId = ShowtimeDAL.Instance.getscreenIdByTheaterNameAndScreenName(theaterValue, screenValue);
                List<Movies> movies = MoviesDAL.Instance.GetMovieByScreenId(screenId);

                cbMovieBooking.DataSource = movies;
                cbMovieBooking.DisplayMember = "TENPHIM";
                LoadCbTimeBooking();
            }
            catch { }

        }

        private void cbMovieBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;
            string movieValue = cbMovieBooking.Text;
            LoadCbTimeBooking();
        }

        private void LoadCbTimeBooking()
        {
            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;
            string movieValue = cbMovieBooking.Text;

            List<Showtime> showtimes = ShowtimeDAL.Instance.getShowtimeByTheaterNameScreenNameMovieName(theaterValue, screenValue, movieValue);
            cbTimeBooking.DataSource = showtimes;
            cbTimeBooking.DisplayMember = "GIOCHIEU";
        }

        private void cbTimeBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;
            LoadSeat(screenValue, theaterValue);
        }

        private void LoadCbServices()
        {
            List<Services> serviceList = ServicesDAL.Instance.GetServiceList();
            cbServices.DataSource = serviceList;
            cbServices.DisplayMember = "TENDV";
        }

        private void cbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Services> serviceList = ServicesDAL.Instance.GetServiceList();
            tbPrice.Text = serviceList[cbServices.SelectedIndex].GiaDV.ToString("#,### đồng", CultureInfo.GetCultureInfo("vi-VN").NumberFormat);
            
        }

        #endregion

        #region custom_btn

        private void Btn_Enter(object sender, System.EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightGreen;
        }

        private void Btn_Leave(object sender, System.EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
        }

        private void Btn_Leave_exist(object sender, System.EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            seatId = ((sender as Button).Tag as ScreenAndSeat).MaGhe;
            testbox.Text = seatId.ToString();
            lvBill.Tag = (sender as Button).Tag;

            int showtimeId = getShowtimeId();
            ticketId = TicketDAL.Instance.GetTicketIdByShowtimeIdAndSeatId(showtimeId, seatId);
            testbox.Text = ticketId.ToString();
            showBill(ticketId);
            loadMoney(ticketId);
            lvBill.Tag = ((sender as Button).Tag);

        }
        #endregion

        #region insert
        private void btnInsertSeat_Click(object sender, EventArgs e)
        {
            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;

            ScreenAndSeat seat = lvBill.Tag as ScreenAndSeat;

            if(ticketId == null || seat == null)
            {
                MessageBox.Show("Chưa chọn ghế", "Lỗi");
                return;
            }
            else
            {
                ticketId = TicketDAL.Instance.GetTicketIdByShowtimeIdAndSeatId(getShowtimeId(), seat.MaGhe);
                if (ticketId != 0)
                {
                    MessageBox.Show("Ghế đã có người đặt", "Lỗi");
                }
                else
                {
                    ScreenDAL.Instance.InsertSeat(getShowtimeId(), seat.MaGhe);
                }
                LoadSeat(screenValue, theaterValue);
                showBill(ticketId);
            }

        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            int showtimeId = getShowtimeId();
            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;

            ScreenAndSeat seat = lvBill.Tag as ScreenAndSeat;

            List<Ticket> getTicketAt = TicketDAL.Instance.GetTicketByTicketId(ticketId);

            if (seat == null || ticketId == null)
            {
                MessageBox.Show("Chưa chọn ghế", "Lỗi");
                return;
            }

            ticketId = TicketDAL.Instance.GetTicketIdByShowtimeIdAndSeatId(showtimeId, seat.MaGhe);

            if (ticketId == 0)
            {

                MessageBox.Show("Ghế chưa được đặt", "Lỗi");
                return;
            }

            Decimal getMoney = TicketDAL.Instance.GetMoneyByTicketId(ticketId);
            if (getMoney > 0)
            {
                MessageBox.Show("Vé đã đặt không thể thêm", "Lỗi");
                return;
            }

            if (ServicesDAL.Instance.ServiceExist(ticketId, (cbServices.SelectedItem as Services).MaDV) == 0)
            {
                TicketDAL.Instance.InsertService(ticketId, (cbServices.SelectedItem as Services).MaDV, 1);
            }
            else
            {
                int quantity = ServicesDAL.Instance.GetQuantityByTicketIdAndServiceId(ticketId, (cbServices.SelectedItem as Services).MaDV);
                 TicketDAL.Instance.UpdateService(ticketId, (cbServices.SelectedItem as Services).MaDV, quantity+1);
            }

            
            LoadSeat(screenValue, theaterValue);
            showBill(ticketId);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if(ticketId == null)
            {
                MessageBox.Show("Chưa chọn ghế", "Lỗi");
                return;
            }
            if(ticketId == 0)
            {
                MessageBox.Show("Ghế chưa được đặt", "Lỗi");
                return;

            }

            Decimal getMoney = TicketDAL.Instance.GetMoneyByTicketId(ticketId);
            if (getMoney > 0)
            {
                MessageBox.Show("Vé đã thanh toán, không thể đặt", "Lỗi");
                return;
            }

            TicketDAL.Instance.UpdateTicketMoney(totalMoney, ticketId);

            Document document = new Document(PageSize.SMALL_PAPERBACK);
            PdfWriter.GetInstance(document, new FileStream("bill.pdf", FileMode.Create));

            string vuArial = Path.Combine("fonts",
                                         "vuArial.ttf");

            BaseFont bf = BaseFont.CreateFont(vuArial, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            Font fontNormal = new Font(bf, 12);

            document.Open();

            Paragraph theaterName = new Paragraph { Font = fontNormal };
            theaterName.Add("Tên rạp: " + cbTheater.Text);
            document.Add(theaterName);

            Paragraph screenName = new Paragraph { Font = fontNormal };
            screenName.Add("Tên phòng chiếu: " + cbScreen.Text);
            document.Add(screenName);

            Paragraph movieName = new Paragraph { Font = fontNormal };
            movieName.Add("Tên phim: " + cbMovieBooking.Text);
            document.Add(movieName);

            Paragraph timeBooking = new Paragraph { Font = fontNormal };
            timeBooking.Add("Suất chiếu: " + cbTimeBooking.Text);
            document.Add(timeBooking);

            Paragraph getToday = new Paragraph { Font = fontNormal };
            getToday.Add("Ngày: " + DateTime.Now.ToString("dd-MM-yyyy"));
            document.Add(getToday);

            List<Ticket> getTicketAt = TicketDAL.Instance.GetTicketByTicketId(ticketId);
            Paragraph seatName = new Paragraph { Font = fontNormal };

            foreach (Ticket ticket in getTicketAt)
            {
                switch (ticket.SoCot)
                {
                    case 1:
                        seatName.Add("Tên ghế: A" + ticket.SoHang);
                        document.Add(seatName);
                        break;
                    case 2:
                        seatName.Add("Tên ghế: B" + ticket.SoHang);
                        document.Add(seatName);
                        break;
                    case 3:
                        seatName.Add("Tên ghế: C" + ticket.SoHang);
                        document.Add(seatName);
                        break;
                    case 4:
                        seatName.Add("Tên ghế: D" + ticket.SoHang);
                        document.Add(seatName);
                        break;

                }
                break;
            }

            Paragraph ticketPrice = new Paragraph { Font = fontNormal };
            ticketPrice.Add("Tiền vé: 55.000 đồng");
            document.Add(ticketPrice);

            Paragraph servicesTitle = new Paragraph { Font = fontNormal };
            servicesTitle.Add("Dịch vụ kèm theo (nếu có): " );
            document.Add(servicesTitle);


            foreach(Ticket ticket in getTicketAt)
            {
                Paragraph services = new Paragraph { Font = fontNormal };
                services.Add(ticket.TenDv+": "+ ticket.GiaDv.ToString("#,### đồng", CultureInfo.GetCultureInfo("vi-VN").NumberFormat)+" x "+ticket.SoLuong);
                document.Add(services);
            }


            Paragraph price = new Paragraph { Font = fontNormal };
            price.Add("Tổng tiền: " + tbPriceTotal.Text);
            document.Add(price);
            document.Close();

            String theaterName2 = cbTheater.Text;
            String screenName2 = cbScreen.Text;
            String showtimeDate = DateTime.Now.ToString("yyyy-M-dd");
            StatisticalDAL.Instance.insertStatistical(theaterName2, screenName2, showtimeDate, totalMoney);

            MessageBox.Show("Thêm vé thành công", "Thông báo");
        }

        private void btnDeleteSeat_Click(object sender, EventArgs e)
        {
            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;
            int showtimeId = getShowtimeId();

            if (ticketId == null)
            {
                MessageBox.Show("Chưa chọn ghế", "Lỗi");
                return;
            }

            if (ticketId == 0)
            {

                MessageBox.Show("Ghế chưa được đặt", "Lỗi");
                return;
            }

            
            Decimal getMoney = TicketDAL.Instance.GetMoneyByTicketId(ticketId);
            if (getMoney > 0)
            {
                MessageBox.Show("Vé đã đặt không thể xóa", "Lỗi");
                return;
            }
            

            TicketDAL.Instance.DeleteTicketByTicketId(ticketId, seatId, showtimeId);

            LoadSeat(screenValue, theaterValue);
            showBill(ticketId);
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                int showtimeId = getShowtimeId();
                string theaterValue = cbTheater.Text;
                string screenValue = cbScreen.Text;

                ScreenAndSeat seat = lvBill.Tag as ScreenAndSeat;

                List<Ticket> getTicketAt = TicketDAL.Instance.GetTicketByTicketId(ticketId);

                if (seat == null || ticketId == null)
                {
                    MessageBox.Show("Chưa chọn ghế", "Lỗi");
                    return;
                }

                ticketId = TicketDAL.Instance.GetTicketIdByShowtimeIdAndSeatId(showtimeId, seat.MaGhe);

                if (ticketId == 0)
                {

                    MessageBox.Show("Ghế chưa được đặt", "Lỗi");
                    return;
                }

                if (ServicesDAL.Instance.ServiceCount(ticketId, (cbServices.SelectedItem as Services).MaDV) == 1)
                {
                    ServicesDAL.Instance.DeleteDetailServiceByTicketdServiceId(ticketId, (cbServices.SelectedItem as Services).MaDV);
                }
                else
                {
                    int quantity = ServicesDAL.Instance.GetQuantityByTicketIdAndServiceId(ticketId, (cbServices.SelectedItem as Services).MaDV);
                    TicketDAL.Instance.UpdateService(ticketId, (cbServices.SelectedItem as Services).MaDV, quantity - 1);
                }


                LoadSeat(screenValue, theaterValue);
                showBill(ticketId);
            }
            catch { }
        }

        #endregion

        #region showBill
        private void showBill(int ticketId)
        {
            lvBill.Items.Clear();
            Decimal priceTotal = 55000;

            int showtimeId = getShowtimeId();

            ScreenAndSeat seat = lvBill.Tag as ScreenAndSeat;

            switch (ScreenDAL.Instance.seatExist(showtimeId, seat.MaGhe))
            {
                case 1:
                    priceTotal = 55000;
                    break;
                default:
                    priceTotal = 0;
                    break;
            }

            List<Ticket> getTicketAt = TicketDAL.Instance.GetTicketByTicketId(ticketId);
            foreach(Ticket item in getTicketAt)
            {
                /*
                ListViewItem lsvItem = new ListViewItem(item.TenPhim.ToString());
                lsvItem.SubItems.Add(item.GioChieu.ToString());
                switch(item.SoCot)
                {
                    case 1:
                        lsvItem.SubItems.Add("A" + item.SoHang.ToString());
                        break;
                    case 2:
                        lsvItem.SubItems.Add("B" + item.SoHang.ToString());
                        break;
                    case 3:
                        lsvItem.SubItems.Add("C" + item.SoHang.ToString());
                        break;
                    case 4:
                        lsvItem.SubItems.Add("D" + item.SoHang.ToString());
                        break;

                }
                */

                ListViewItem lsvItem = new ListViewItem(item.TenDv.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.GiaDv.ToString("#,### đồng", CultureInfo.GetCultureInfo("vi-VN").NumberFormat));
                priceTotal += item.GiaDv*item.SoLuong;
                lvBill.Items.Add(lsvItem);
            }
            totalMoney = priceTotal;
            tbPriceTotal.Text = priceTotal.ToString("#,### đồng", CultureInfo.GetCultureInfo("vi-VN").NumberFormat);
        }
        #endregion

        #region getShowtimeId() {
        private int getShowtimeId()
        {

            string theaterValue = cbTheater.Text;
            string screenValue = cbScreen.Text;
            string movieValue = cbMovieBooking.Text;
            string timeBookingValue = cbTimeBooking.Text;
            int showtimeId = ShowtimeDAL.Instance.getShowtimeIdByMovieNameAndTimeBookingAndScreenNameAndTheaterName(movieValue, timeBookingValue, screenValue, theaterValue);
            return showtimeId;
        }

        #endregion

        #region loadMoney
        private void loadMoney(int ticketId)
        {
            Decimal getMoney = TicketDAL.Instance.GetMoneyByTicketId(ticketId);
            if (getMoney > 0)
            {
                tbStatus.Text = "Đã thanh toán";
            }
            else
            {
                tbStatus.Text = "Chưa thanh toán";
            }
        }
        #endregion

    }
}
