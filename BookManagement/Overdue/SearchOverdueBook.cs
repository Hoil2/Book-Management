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
    public partial class frmSearchOverdueBook : Form
    {
        public frmSearchOverdueBook()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            tlpBookList.Controls.Clear();
            int cnt = 0;
            for (int i = 0; i < Book.database.Count; i++)
            {
                if (txtbookName.Text.Equals("")) break;
                if (Book.database[i].bookName.IndexOf(txtbookName.Text) != -1)
                {
                    if (Book.database[i].bookStatus.Equals("대출중")) // 대출중일 때
                    {
                        DateTime date = DateTime.Parse(Loan.FindReturnDate(Book.database[i].bookNumber));
                        if (date.Ticks - DateTime.Now.Ticks < 0) // 연체
                        {
                            AddBookName(Book.database[i].bookName, cnt);
                            AddBookOverdueYear(Loan.FindReturnDate(Book.database[i].bookNumber), cnt);
                            AddBookInfoButton(Book.database[i], cnt);
                            cnt++;
                        }
                    }
                }
            }
        }


        void AddBookName(string text, int row)
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = text;
            label.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            tlpBookList.Controls.Add(label, 0, row);
        }

        void AddBookOverdueYear(string bookLoanPeriod, int row) 
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = bookLoanPeriod;
            label.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            tlpBookList.Controls.Add(label, 1, row);
        }



        void AddBookInfoButton(BookInfo bookInfo, int row)
        {
            Button button = new Button();

            button.Text = "도서정보";

            button.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            button.Click += new EventHandler(delegate
            {
                frmBookInfoWindow frmBookInfo = new frmBookInfoWindow(bookInfo);
                frmBookInfo.ShowDialog();
            });
            tlpBookList.Controls.Add(button, 2, row);
        }

        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            tlpBookList.Controls.Clear();
            int cnt = 0;
            for (int i = 0; i < Book.database.Count; i++)
            { 
                if (Book.database[i].bookStatus.Equals("대출중")) // 대출중일 때
                {
                    DateTime date = DateTime.Parse(Loan.FindReturnDate(Book.database[i].bookNumber));
                    if (date.Ticks - DateTime.Now.Ticks < 0) // 연체
                    {
                        AddBookName(Book.database[i].bookName, cnt);
                        AddBookOverdueYear(Loan.FindReturnDate(Book.database[i].bookNumber), cnt);
                        AddBookInfoButton(Book.database[i], cnt);
                        cnt++;
                    }
                }
            }
        }
    }
}
