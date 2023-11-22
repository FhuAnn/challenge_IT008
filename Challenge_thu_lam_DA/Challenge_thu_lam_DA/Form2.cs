using Challenge_thu_lam_DA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_thu_lam_DA
{
    public partial class frmDashboard : Form
    {
        public frmDashboard(User user)
        {
            InitializeComponent();
            lb_name.Text = user.name;
            lb_email.Text = user.email;
            lb_name.TextAlign = ContentAlignment.MiddleCenter;
            lb_email.TextAlign = ContentAlignment.MiddleCenter;
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void bunifuPanel5_Click(object sender, EventArgs e)
        {

        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void btn_finance_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);

        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);

        }

        private void btn_presciption_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(4);

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(5);

        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(6);
        }
    }
}
