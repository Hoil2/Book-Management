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

            if(textID.Text == "" || textName.Text == "" || textBirth.Text == "" ||
                textPhone1.Text == "" && textPhone2.Text == "" || textPhone3.Text == "" || textAdress.Text == "")
            {
                MessageBox.Show("회원정보를 모두 입력해 주십시오", "회원가입실패");
            }
            else if (int.TryParse(textPhone1.Text, out number) == false || int.TryParse(textPhone2.Text, out number) == false || int.TryParse(textPhone3.Text, out number) == false)
            {
                MessageBox.Show("전화번호는 숫자만 입력해 주십시오", "전화번호 기입 오류");
            }
            else if(textPhone1.TextLength != 3 || textPhone2.TextLength != 4 || textPhone3.TextLength !=4)
            {
                MessageBox.Show("올바른 전화번호를 입력해 주십시오", "전화번호 기입 오류");
            }
            else if(int.TryParse(textBirth.Text, out number) == false)
            {
                MessageBox.Show("연/월/일 순으로 숫자만 입력해 주십시오", "생년월일 기입 오류");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(@"D:\test\newCus.txt"))
                {
                    writer.WriteLine(textID.Text);
                    writer.WriteLine(textName.Text);
                    writer.WriteLine(textBirth.Text);
                    writer.Write(textPhone1.Text + " - ");
                    writer.Write(textPhone2.Text + " - ");
                    writer.WriteLine(textPhone3.Text);
                    writer.WriteLine(textAdress.Text);
                    writer.WriteLine("---------------------");
                }
                using (StreamWriter writer = new StreamWriter(@"D:\test\CusId.txt"))
                {
                    writer.WriteLine(textID.Text);
                }
                using (StreamWriter writer = new StreamWriter(@"D:\test\CusFindId.txt"))
                {
                    writer.WriteLine(textName.Text);
                    writer.WriteLine(textPhone1.Text + " - " + textPhone2.Text + "-" + textPhone3.Text);
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
           

            using (StreamReader reader = new StreamReader(@"D:\test\CusId.txt"))
            {
                string id;

                while ((id = reader.ReadLine()) != null)
                {
                    if (textID.Text == id)
                    {
                        MessageBox.Show("이미 사용 중인 아이디입니다", "아이디 중복");
                    }
                    else
                    {
                        MessageBox.Show("사용 가능한 아이디입니다", "아이디 확인");
                    }
                }

                /*while (File.ReadAllText(@"c:\test\newCus.txt") != null)
                {
                    if (textID.Text == id)
                    {
                        MessageBox.Show("이미 사용 중인 아이디입니다", "아이디 중복");
                    }
                    else
                    {
                        MessageBox.Show("사용 가능한 아이디입니다", "아이디 확인");
                    }
                }*/
            }
        }
    }
}
