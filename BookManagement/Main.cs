using BookManagement.Customer;
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
    public partial class Main : Form
    {
        frmLogin _frmLogin;
        frmSearchBook frmSearchBook = null;
        frmModifyBook frmModifyBook = null;

        frmSearchUser frmSearchUser = null;
        frmModifyUser frmModifyUser = null;

        frmLoanBook frmLoanBook = null;
        frmLoanExtension frmLoanExtension = null;
        frmReturnBook frmReturnBook = null;

        frmBookQ frmBookQ = null;
        frmMemberQ frmMemberQ = null;
        frmQandA frmQandA = null;

        public Main()
        {
            InitializeComponent();
            _frmLogin = new frmLogin();
            _frmLogin.FormClosed += new FormClosedEventHandler(LoginFail);
            Book.database = new List<BookInfo>(); // 도서 파일 초기화
        }

        void LoginFail(object sender, FormClosedEventArgs e)
        {
            if (!_frmLogin.successLogin && _frmLogin.close)
                Close();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (_frmLogin.close) return;
            if (!_frmLogin.successLogin)
            {
                _frmLogin.ShowDialog();
            }
        }

        private void menuAddBook_Click(object sender, EventArgs e)
        {
            new AddBook().ShowDialog();
        }

        private void menuSearchBook_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if(ActiveMdiChild != frmSearchBook)
                {
                    ActiveMdiChild.Close();
                }
            }
            frmSearchBook = new frmSearchBook();
            frmSearchBook.MdiParent = this;
            frmSearchBook.WindowState = FormWindowState.Maximized;
            frmSearchBook.Show();
        }

        private void menuModifyBook_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild != frmModifyBook)
                {
                    ActiveMdiChild.Close();
                }
            }
            frmModifyBook = new frmModifyBook();
            frmModifyBook.MdiParent = this;
            frmModifyBook.WindowState = FormWindowState.Maximized;
            frmModifyBook.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            User.UserLoad();
        }

        private void menuSearchUser_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild != frmSearchUser)
                {
                    ActiveMdiChild.Close();
                }
            }
            frmSearchUser = new frmSearchUser();
            frmSearchUser.MdiParent = this;
            frmSearchUser.WindowState = FormWindowState.Maximized;
            frmSearchUser.Show();
        }

        private void menuModifyUser_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild != frmModifyUser)
                {
                    ActiveMdiChild.Close();
                }
            }
            frmModifyUser = new frmModifyUser();
            frmModifyUser.MdiParent = this;
            frmModifyUser.WindowState = FormWindowState.Maximized;
            frmModifyUser.Show();
        }

        private void menuLoanBook_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild != frmLoanBook)
                {
                    ActiveMdiChild.Close();
                }
            }
            frmLoanBook = new frmLoanBook();
            frmLoanBook.MdiParent = this;
            frmLoanBook.WindowState = FormWindowState.Maximized;
            frmLoanBook.Show();
        }

        private void menuLoanExtension_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild != frmLoanExtension)
                {
                    ActiveMdiChild.Close();
                }
            }
            frmLoanExtension = new frmLoanExtension();
            frmLoanExtension.MdiParent = this;
            frmLoanExtension.WindowState = FormWindowState.Maximized;
            frmLoanExtension.Show();
        }

        private void menuReturnBook_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild != frmReturnBook)
                {
                    ActiveMdiChild.Close();
                }
            }
            frmReturnBook = new frmReturnBook();
            frmReturnBook.MdiParent = this;
            frmReturnBook.WindowState = FormWindowState.Maximized;
            frmReturnBook.Show();
        }

        private void menuBookQ_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild != frmBookQ)
                {
                    ActiveMdiChild.Close();
                }
                frmBookQ = new frmBookQ();
                frmBookQ.MdiParent = this;
                frmBookQ.WindowState = FormWindowState.Maximized;
                frmBookQ.Show();
            }
        }

        private void menuMemberQ_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild != frmMemberQ)
                {
                    ActiveMdiChild.Close();
                }
                frmMemberQ = new frmMemberQ();
                frmMemberQ.MdiParent = this;
                frmMemberQ.WindowState = FormWindowState.Maximized;
                frmMemberQ.Show();
            }
        }

        private void menuQandA_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild != frmQandA)
                {
                    ActiveMdiChild.Close();
                }
                frmQandA = new frmQandA();
                frmQandA.MdiParent = this;
                frmQandA.WindowState = FormWindowState.Maximized;
                frmQandA.Show();
            }
        }
    }
}
