﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resturant
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string order { get; set; }


        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            lblval.Text = order;
        }

        private void lblval_Click(object sender, EventArgs e)
        {

        }
    }
}