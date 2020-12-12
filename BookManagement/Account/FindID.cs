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
    public partial class FindID : Form
    {
        public FindID()
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
            string id = User.FindID(textName.Text, textPhone1.Text, textPhone2.Text, textPhone3.Text);
            if (id != "")
            {
                MessageBox.Show("아이디는 " + id + "입니다", "아이디 찾기 성공");
            }
            else
            {
                MessageBox.Show("아이디를 찾는데 실패하였습니다", "아이디 찾기 실패");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
