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
            using (StreamReader reader = new StreamReader(@"D:\test\CusFindId.txt"))
            {
                string findId;

                while ((findId = reader.ReadLine()) != null)
                {
                    if (textName.Text == findId)
                    {
                        findId = reader.ReadLine();
                        if (textPhone1.Text + " - " + textPhone2.Text + " - " + textPhone3.Text == findId)
                        {
                            MessageBox.Show("아이디는 " + "앙기모리" + "입니다", "아이디 찾기");
                        }
                        else
                        {
                            MessageBox.Show("해당 정보와 일치하는 아이디가 없습니다", "아이디 찾기 실패");
                        }
                    }
                    else
                    {
                        try
                        {
                            MessageBox.Show("해당 정보와 일치하는 아이디가 없습니다", "아이디 찾기 실패");
                            reader.Close();

                        }
                        catch (IOException)
                        {

                        }
                    }
                }
            }

            //textName.Text != null && textPhone1.Text != null && textPhone2.Text != null && textPhone3.Text != null
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
