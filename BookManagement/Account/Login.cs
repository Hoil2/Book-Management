using BookManagement.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        // 로그인버튼 클릭시
        private void textID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        private void textPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        // 회원 정보 찾기
        
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

        // 회원가입
        private void newbtn_Click(object sender, EventArgs e)
        {
            SignUp FormNew = new SignUp();
            FormNew.ShowDialog();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            close = true;
        }

        void Login()
        {
            if (User.ExistsID(textID.Text))
            {
                if (User.ComparePW(textID.Text, textPwd.Text))
                {
                    successLogin = true;
                    Book.BookLoad(); // 도서들 파일에서 불러오기

                    DirectoryInfo di = new DirectoryInfo(@"Loan"); // 대출 폴더 없으면 만들기
                    if (!di.Exists) di.Create();

                    Loan.LoanLoad(); // 대출 파일에서 불러오기
                    //Loan.database[0].returnDate = "2020-12-13";
                    //Loan.LoanSave();
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

        
    }
}
