using BookManagement.Customer;
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
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textShowID.Text = "";

            for(int i = 0;i < User.userdatabase.Count; i++)
            {
                if (textFindID.Text == "")
                {
                    textShowID.Text += User.userdatabase[i].userID + Environment.NewLine;
                    
                }
                else if (User.ExistsID(textFindID.Text))
                {
                    textShowID.Text = textFindID.Text;
                }
                else
                {
                    textShowID.Text = "해당하는 아이디가 없습니다";
                }
            }
        }
    }
}
