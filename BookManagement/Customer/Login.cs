using BookManagement.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class frmLogin : Form
    {
        public bool successLogin;
        public bool close;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //로그인버튼 클릭시
        {
            if (User.ExistsID(textID.Text))
            {
                if (User.ComparePW(textID.Text, textPwd.Text))
                {
                    successLogin = true;
                    Book.BookLoad(); // 도서들 파일에서 불러오기
                    MessageBox.Show("로그인 성공", "로그인 성공");
                    Close();
                }
                else // 비밀번호 틀렸을 때
                {
                    successLogin = false;
                    MessageBox.Show("비밀번호 틀림", "로그인 실패");
                }
            }
            else  // 아이디 틀렸을 때
            {
                successLogin = false;
                MessageBox.Show("아이디 틀림", "로그인 실패");
            }
        }

        private void findIDbtn_Click(object sender, EventArgs e)
        {
            FindID FormID = new FindID();
            FormID.ShowDialog();
        }

        private void findPwdbtn_Click(object sender, EventArgs e)
        {
            FindPW FormPwd = new FindPW();
            FormPwd.ShowDialog();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            SignUp FormNew = new SignUp();
            FormNew.ShowDialog();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            close = true;
        }
    }
}
