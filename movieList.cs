using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS
{
    public partial class movieList : UserControl
    {
        public movieList()
        {
            InitializeComponent();
        }

        private void movieList_Load(object sender, EventArgs e)
        {

        }

        #region Properties

        private String title;
        private String director;
        private String genre;
        private String time;
        private String language;
        private String rated;
        private String content;
        private String format;
        private DateTime start;
        private DateTime end;
        private Image poster;

        [Category("Custom Props")]
        public String Title
        {
            get { return title; }
            set { title = value; lbTitle.Text = value; }
        }

        [Category("Custom Props")]
        public Image Poster
        {
            get { return poster; }
            set { poster = value; pBPoster.Image = value; }
        }

        [Category("Custom Props")]
        public String Director
        {
            get { return director; }
            set { director = value; lbDirector.Text = value; }
        }

        [Category("Custom Props")]
        public String Genre
        {
            get { return genre; }
            set { genre = value; lbGenre.Text = value; }
        }

        [Category("Custom Props")]
        public String Time
        {
            get { return time; }
            set { time = value; lbTime.Text = value; }
        }

        [Category("Custom Props")]
        public String Language
        {
            get { return language; }
            set { language = value; lbLanguage.Text = value; }
        }

        [Category("Custom Props")]
        public String Rated
        {
            get { return rated; }
            set { rated = value; lbRated.Text = value; }
        }

        [Category("Custom Props")]
        public String Content
        {
            get { return content; }
            set { content = value; lbContent.Text = value; }
        }

        [Category("Custom Props")]
        public String Format
        {
            get { return format; }
            set { format = value; lbFormat.Text = value; }
        }

        [Category("Custom Props")]
        public DateTime Start
        {
            get { return start; }
            set { start = value; lbStart.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public DateTime End
        {
            get { return end; }
            set { end = value; lbEnd.Text = value.ToString(); }
        }

        #endregion
    }
}
