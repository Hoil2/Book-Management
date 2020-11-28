using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if(textName.Text == "홍길동" && textPhone1.Text == "010" && textPhone2.Text =="1111" && textPhone3.Text == "2222")
            {
                MessageBox.Show("17831068", "아이디 찾기");
            }
            else
            {
                MessageBox.Show("올바른 성명 또는 전화번호를 입력하세요", "아이디 찾기 실패");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
