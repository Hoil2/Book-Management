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
    public partial class frmBookModifyWindow : Form
    {
        string bookNumber;
        public frmBookModifyWindow(BookInfo bookInfo)
        {
            InitializeComponent();
            txtAuthor.Text = bookInfo.author;
            txtBookName.Text = bookInfo.bookName;
            txtPublisher.Text = bookInfo.publisher;
            txtPublicationYear.Text = bookInfo.publicationYear;
            txtBookStatus.Text = bookInfo.bookStatus;
            bookNumber = bookInfo.bookNumber;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < Book.database.Count; i++)
                {
                    if (Book.database[i].bookNumber.Equals(bookNumber))
                    {
                        Book.database.RemoveAt(i);
                        Book.BookSave();
                        MessageBox.Show("삭제 완료");
                        Close();
                        break;
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            BookInfo book = Book.database.Find(x => x.bookNumber.Equals(bookNumber));
            book.bookName = txtBookName.Text;
            book.author = txtAuthor.Text;
            book.publisher = txtPublisher.Text;
            book.publicationYear = txtPublicationYear.Text;
            book.bookStatus = txtBookStatus.Text;

            Book.BookSave();

            MessageBox.Show("수정 완료");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
