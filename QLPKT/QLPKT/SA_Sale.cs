﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLPKT
{
    public partial class SA_Sale : Form
    {
       DataTable dt;

        public SA_Sale(DataTable dt1)
        {
            InitializeComponent();
            dt = dt1;
        }

        private void SA_Sale_Load(object sender, EventArgs e)
        {
            databuy.DataSource = dt.DefaultView;
            databuy.RowHeadersVisible = false;
        }

        public double get()
        {
            object sum = dt.Compute("sum(ThanhTien)", "SLBan>0");
            return double.Parse(sum.ToString());
        }
    }
}
