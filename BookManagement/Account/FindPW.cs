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
        public bool FindPw()
        {
            int i = 0;
            bool flag = true;

            while (i < User.database.Count)
            {
                if (textID.Text.Equals(User.database[i].userID))
                {
                    if(textPhone1.Text.Equals(User.database[i].userPhone1))
                    {
                        if (textPhone2.Text.Equals(User.database[i].userPhone2))
                        {
                            if (textPhone3.Text.Equals(User.database[i].userPhone3))
                            {
                                flag = true;
                            }
                        }
                    }
                    
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
            int number;

            /*while(i < User.userdatabase.Count)
            {*/
                if(textID.Text == "" || textPhone1.Text == "" || textPhone2.Text == "" || textPhone3.Text == "")
                {
                    MessageBox.Show("아이디, 전화번호를 모두 입력해 주십시오", "비밀번호 찾기 실패");
                    return;
                }
                else if (int.TryParse(textPhone1.Text, out number) == false || int.TryParse(textPhone2.Text, out number) == false || int.TryParse(textPhone3.Text, out number) == false)
                {
                    MessageBox.Show("전화번호는 숫자만 입력해 주십시오", "전화번호 기입 오류");
                    return;
                }
                else if(textPhone1.TextLength != 3 || textPhone2.TextLength != 4 || textPhone3.TextLength != 4)
                {
                    MessageBox.Show("올바른 전화번호를 입력해 주십시오", "전화번호 기입 오류");
                }

            /*if(FindPw() == true)
            {
                MessageBox.Show(User.userdatabase[i].userPwd, "비밀번호 찾기 성공");
                break;
            }
            else
            {
                MessageBox.Show("올바른 정보를 입력해 주십시오", "비밀번호 찾기 실패");
            }
            i++;*/

            string pw = User.FindPW(textID.Text, textPhone1.Text, textPhone2.Text, textPhone3.Text);
            if (pw != "")
            {
                MessageBox.Show("비밀번호는 " + pw + "입니다", "비밀번호 찾기 성공");
            }
            else
            {
                MessageBox.Show("비밀번호를 찾는데 실패하였습니다", "비밀번호 찾기 실패");
            }
            /*}*/

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
