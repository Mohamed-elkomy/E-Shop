﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "admin" && bunifuTextBox2.Text == "password")
            {
                this.Hide();
                var form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

