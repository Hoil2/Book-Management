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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public bool CheckID()
        {
            int i = 0;
            bool flag = true;

            while (i < User.userdatabase.Count)
            {
                if (textID.Text.Equals(User.userdatabase[i].userID))
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
                i++;
            }
            return flag;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int number;

            if(textID.Text == "" || textName.Text == "" || textBirth.Text == "" ||
                textPhone1.Text == "" && textPhone2.Text == "" || textPhone3.Text == "" || textPwd.Text == "")
            {
                MessageBox.Show("회원정보를 모두 입력해 주십시오", "회원가입실패");
                return;
            }
            else if (int.TryParse(textPhone1.Text, out number) == false || int.TryParse(textPhone2.Text, out number) == false || int.TryParse(textPhone3.Text, out number) == false)
            {
                MessageBox.Show("전화번호는 숫자만 입력해 주십시오", "전화번호 기입 오류");
                return;
            }
            else if(textPhone1.TextLength != 3 || textPhone2.TextLength != 4 || textPhone3.TextLength !=4)
            {
                MessageBox.Show("올바른 전화번호를 입력해 주십시오", "전화번호 기입 오류");
                return;
            }
            else if(int.TryParse(textBirth.Text, out number) == false)
            {
                MessageBox.Show("연/월/일 순으로 숫자만 입력해 주십시오", "생년월일 기입 오류");
                return;
            }
            else if(User.ExistsID(textID.Text))
            {
                MessageBox.Show("다른 아이디를 사용해 주십시오");
                return;
            }
            DirectoryInfo di = new DirectoryInfo(@"Customer");
            if (!di.Exists) di.Create();

            UserInfo userInfo = new UserInfo()
            {
                userID = textID.Text,
                userName = textName.Text,
                userBirth = textBirth.Text,
                userPhone1 = textPhone1.Text,
                userPhone2 = textPhone2.Text,
                userPhone3 = textPhone3.Text,
                userPwd = textPwd.Text
            };
            User.userdatabase.Add(userInfo);
            User.UserSave();
            Close();
            MessageBox.Show("회원가입에 성공하셨습니다", "회원가입");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"Customer");
            if (!di.Exists)
            {
                MessageBox.Show("사용 가능한 아이디입니다", "아이디 확인"); return;
            }
            
            CheckID();

            bool flag = true;

            if(CheckID() == true)
            {
                MessageBox.Show("사용 가능한 아이디입니다", "아이디 확인");
                flag = true;
            }
            else
            {
                MessageBox.Show("이미 사용중인 아이디입니다", "아이디 중복");
                flag = false;
            }
           
            User.UserLoad();
        }
    }
}
