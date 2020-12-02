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

        private void 회원검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchUser searchUser = new SearchUser();
            searchUser.ShowDialog();
        }

        private void 회원수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 회원삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelectUser delectUser = new DelectUser();
            delectUser.ShowDialog();
        }
    }
}
