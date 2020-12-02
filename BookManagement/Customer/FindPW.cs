using BookManagement.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class FindPW : Form
    {
        public bool CheckPwd()
        {
            int i = 0;
            bool flag = true;

            while (i < User.userdatabase.Count)
            {
                if (textID.Text == User.userdatabase[i].userID && 
                    textPhone1.Text == User.userdatabase[i].userPhone1 && textPhone2.Text == User.userdatabase[i].userPhone2 && textPhone2.Text == User.userdatabase[i].userPhone3)
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
                i++;
            }
            return flag;
        }

        public FindPW()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(i < User.userdatabase.Count)
            {
                if (User.CompareFindPW(textID.Text, textPhone1.Text, textPhone2.Text, textPhone3.Text))
                {
                    MessageBox.Show(User.userdatabase[i].userPwd, "");
                }
                i++;
            }
            
            /*int i = 0;

            while(i < User.userdatabase.Count)
            {
                if (CheckPwd() == true)
                {
                    MessageBox.Show(User.userdatabase[0].userPwd, "비밀번호 찾기");
                }
                else
                {
                    MessageBox.Show("못찾아", "비밀번호 찾기 실패");
                }
                i++;
            }*/
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
