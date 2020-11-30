﻿using System;
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
    }
}
