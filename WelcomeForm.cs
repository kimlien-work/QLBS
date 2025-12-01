using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBS
{
    public partial class WelcomeForm : Form
    {
        private string _loggedInUser;

        public WelcomeForm()
        {
            InitializeComponent();
        }

        // Constructor MỚI: Nhận tên người dùng khi Form được tạo
        public WelcomeForm(string username)
        {
            InitializeComponent();
            _loggedInUser = username;

            lblWelcomeMessage.Text = $"Đăng nhập thành công!\nXin chào, {username}!";

            tmrClose.Start();
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            tmrClose.Stop();
            this.Close();
        }
    }
}
