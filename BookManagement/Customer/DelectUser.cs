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
    public partial class DelectUser : Form
    {
        public DelectUser()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            textShowID.Text = "";

            if (User.ExistsID(textFindID.Text))
            {
                textShowID.Text = textFindID.Text;
            }
        }

        private void btnDelect_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < User.userdatabase.Count;i++)
            {
                if (textFindID.Text.Equals(User.userdatabase[i].userID))
                {
                    textShowID.Text = textFindID.Text;

                    DelectUserInputPW delectUserInputPW = new DelectUserInputPW(User.userdatabase[i]);
                    delectUserInputPW.ShowDialog();
                }
            }
        }
    }
}
