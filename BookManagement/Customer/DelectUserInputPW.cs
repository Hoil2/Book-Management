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
    public partial class DelectUserInputPW : Form
    {
        UserInfo user;
        public DelectUserInputPW(UserInfo userInfo)
        {
            InitializeComponent();

            user = userInfo;
        }

        private void btnDelectInput_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(user.userPwd == textDelectPW.Text)
                {
                    User.database.Remove(user);
                    User.UserSave();
                    MessageBox.Show("회원 삭제에 성공하였습니다", "회원 삭제");
                    Close();
                }
            }
            else
            {
                Close();
            }
            
        }
    }
}
