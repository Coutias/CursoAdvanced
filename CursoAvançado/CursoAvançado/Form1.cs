﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoAvançado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {

                progressBar1.Value = progressBar1.Value + 2;

            }

            else
            {

                timer1.Enabled = false;
                F_Login frl = new F_Login();
                frl.Show();
                this.Visible = false;

            }

        }
    }
}
