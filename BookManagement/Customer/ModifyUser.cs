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
    public partial class frmModifyUser : Form
    {
        public frmModifyUser()
        {
            InitializeComponent();
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            List<UserInfo> list = new List<UserInfo>();
            tlpMemberList.Controls.Clear();
            for (int i = 0; i < User.database.Count; i++)
            {
                if (txtMemberName.Text.Equals("")) break;
                if (User.database[i].userName.IndexOf(txtMemberName.Text) != -1)
                {
                    list.Add(User.database[i]);
                    AddMemberName(User.database[i].userName, list.Count - 1);
                    AddMemberInfoButton(User.database[i], list.Count - 1);
                }
            }
        }

        void AddMemberName(string text, int row)
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = text;
            label.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            tlpMemberList.Controls.Add(label, 0, row);
        }

        void AddMemberInfoButton(UserInfo userInfo, int row)
        {
            Button button = new Button();
            button.Text = "회원수정";
            button.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            button.Click += new EventHandler(delegate
            {
                frmUserModifyWindow frmUserModify = new frmUserModifyWindow(userInfo);
                frmUserModify.ShowDialog();
            });
            tlpMemberList.Controls.Add(button, 1, row);
        }

        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            tlpMemberList.Controls.Clear();
            for (int i = 0; i < User.database.Count; i++)
            {
                AddMemberName(User.database[i].userName, i);
                AddMemberInfoButton(User.database[i], i);
            }
        }
    }
}
