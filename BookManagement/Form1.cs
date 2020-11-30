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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //로그인버튼 클릭시
        {
            if(textID.Text == "123" && textPwd.Text == "123")
            {
                MessageBox.Show("응", "로그인 성공");
            }
            else
            {
                MessageBox.Show("올바른 아이디 또는 패스워드를 입력하세요", "로그인 실패");
            }
        }

        private void findIDbtn_Click(object sender, EventArgs e)
        {
            Form2 FormID = new Form2();
            FormID.ShowDialog();
        }

        private void findPwdbtn_Click(object sender, EventArgs e)
        {
            Form3 FormPwd = new Form3();
            FormPwd.ShowDialog();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            Form4 FormNew = new Form4();
            FormNew.ShowDialog();
        }
    }
}
