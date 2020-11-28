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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int number;
            if(textID.Text == "" || textName.Text == "" || textBirth.Text == "" || textPhone1.Text == ""
                && textPhone2.Text == "" || textPhone3.Text == "" || textAdress.Text == "")
            {
                MessageBox.Show("회원정보를 모두 입력해 주십시오", "회원가입실패");
            }
            else if (int.TryParse(textPhone1.Text, out number) == false || int.TryParse(textPhone2.Text, out number) == false || int.TryParse(textPhone3.Text, out number) == false)
            {
                MessageBox.Show("전화번호는 숫자만 입력해 주십시오", "전화번호 입력 실패");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(@"c:\test\newCus.txt"))
                {
                    writer.WriteLine(textID.Text);
                    writer.WriteLine(textName.Text);
                    writer.WriteLine(textBirth.Text);
                    writer.Write(textPhone1.Text + " - ");
                    writer.Write(textPhone2.Text + " - ");
                    writer.WriteLine(textPhone3.Text);
                    writer.WriteLine(textAdress.Text);
                }
                MessageBox.Show("회원가입에 성공하셨습니다", "회원가입");
                this.Close();
            }
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
