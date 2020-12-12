using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.Customer
{
    public partial class frmUserInfoWindow : Form
    {
        public frmUserInfoWindow(UserInfo userInfo)
        {
            InitializeComponent();
            lblUserID.Text = userInfo.userID;
            lblUserName.Text = userInfo.userName;
            lblBirthday.Text = userInfo.userBirth;
            lblPhoneNumber.Text = userInfo.userPhone1 + "-" + userInfo.userPhone2 + "-" + userInfo.userPhone3;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
