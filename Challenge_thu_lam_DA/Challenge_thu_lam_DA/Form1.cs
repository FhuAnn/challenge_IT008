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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);

        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            ReFresh1();// gọi hàm sửa lỗi
        }
        public void ReFresh1()
        {
            tbx_username.Refresh();
            tbx_password.Refresh();
            tbx_email.Refresh();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
         
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
            
        }

    }
}
