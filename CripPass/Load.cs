﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CripPass
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 4;
            if (progressBar1.Value == 100)
            {
                CripPass pa = new CripPass();
                pa.Show();
                this.Visible = false;
                timer1.Stop();
            }
        }

        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
