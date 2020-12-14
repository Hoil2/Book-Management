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
    public partial class frmLoanExtension : Form
    {
        public frmLoanExtension()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            List<BookInfo> list = new List<BookInfo>();
            tlpBookList.Controls.Clear();
            for (int i = 0; i < Book.database.Count; i++)
            {
                if (txtbookName.Text.Equals("")) break;
                if (Book.database[i].bookName.IndexOf(txtbookName.Text) != -1)
                {
                    list.Add(Book.database[i]);
                    AddBookName(Book.database[i].bookName, list.Count - 1);
                    AddBookInfoButton(Book.database[i], list.Count - 1);
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

        void AddBookInfoButton(BookInfo bookInfo, int row)
        {
            Button button = new Button();
            if (bookInfo.bookStatus.Equals("대출중"))
            {
                button.Text = "연장";
            }
            else
            {
                button.Text = "연장불가";
                button.Enabled = false;
            }
            button.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            button.Click += new EventHandler(delegate
            {
                button.Text = "연장완료";
                button.Enabled = false;

                foreach(var item in Loan.database)
                {
                    if(item.bookNumber.Equals(bookInfo.bookNumber))
                    {
                        DateTime beforeDate = Convert.ToDateTime(item.returnDate);
                        DateTime afterDate = DateTime.Now.AddDays(7);
                        item.returnDate = afterDate.ToString("yyyy-MM-dd");
                        MessageBox.Show(beforeDate.ToString("yyyy-MM-dd") + " -> " + afterDate.ToString("yyyy-MM-dd") +
                            Environment.NewLine + "으로 연장 완료");
                        Loan.LoanSave();
                        break;
                    }
                }
            });
            tlpBookList.Controls.Add(button, 1, row);
        }

        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            tlpBookList.Controls.Clear();
            for (int i = 0; i < Book.database.Count; i++)
            {
                AddBookName(Book.database[i].bookName, i);
                AddBookInfoButton(Book.database[i], i);
            }
        }
    }
}
