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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (textID.Text == "17831068" && textPhone1.Text == "010" && textPhone2.Text == "1111" && textPhone3.Text == "2222")
            {
                MessageBox.Show("12345678", "비밀번호 찾기");
            }
            else
            {
                MessageBox.Show("올바른 아이디 또는 전화번호를 입력하세요", "비밀번호 찾기 실패");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
