﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGame
{
    public partial class Rules : Form
    {//JM
        public Rules()
        {
            InitializeComponent();
        }

        private void butCloseRules_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
            /*
            Form1 f1 = new Form1();
            f1.Show();
            */
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//JM