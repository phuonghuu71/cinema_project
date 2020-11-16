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
        public frmShowtimeManaging()
        {
            InitializeComponent();
            dtpShowtime.Format = DateTimePickerFormat.Custom;
            dtpShowtime.CustomFormat = "HH:MM";
            dtpShowtime.ShowUpDown = true;
        }
    }
}

















