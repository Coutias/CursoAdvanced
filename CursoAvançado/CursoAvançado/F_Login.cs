using System;
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
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tb_login.Text == "Coutias" && tb_senha.Text == "1101")
            {

                

            }

        }
    }
}
