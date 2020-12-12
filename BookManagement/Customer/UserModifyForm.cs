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
    public partial class frmUserModifyWindow : Form
    {
        string userID;
        public frmUserModifyWindow(UserInfo userInfo)
        {
            InitializeComponent();
            lblUserID.Text = userInfo.userID;
            txtUserName.Text = userInfo.userName;
            txtBirthday.Text = userInfo.userBirth;
            txtPhone1.Text = userInfo.userPhone1;
            txtPhone2.Text = userInfo.userPhone2;
            txtPhone3.Text = userInfo.userPhone3;

            userID = userInfo.userID;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < User.database.Count; i++)
                {
                    if (User.database[i].userID.Equals(userID))
                    {
                        User.database.RemoveAt(i);
                        User.UserSave();
                        MessageBox.Show("삭제 완료");
                        Close();
                        break;
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            UserInfo user = User.database.Find(x => x.userID.Equals(userID));
            user.userName = txtUserName.Text;
            user.userBirth = txtBirthday.Text;
            user.userPhone1 = txtPhone1.Text;
            user.userPhone2 = txtPhone2.Text;
            user.userPhone3 = txtPhone3.Text;

            User.UserSave();

            MessageBox.Show("수정 완료");
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
