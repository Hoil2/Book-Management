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
            if(textID.Text == "123" && textPwd.Text == "123")
            {
                successLogin = true;
                Close();
            }
            else
            {
                successLogin = false;
                MessageBox.Show("올바른 아이디 또는 패스워드를 입력하세요", "로그인 실패");
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
