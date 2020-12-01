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
    public partial class frmSearchBook : Form
    {
        public frmSearchBook()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            List<BookInfo> list = new List<BookInfo>();
            tlpBookList.Controls.Clear();
            for (int i = 0; i < Book.database.Count; i++) {
                if (txtbookName.Text.Equals("")) break;
                if(Book.database[i].bookName.IndexOf(txtbookName.Text) != -1)
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
            button.Text = "도서정보";
            button.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            button.Click += new EventHandler(delegate 
            {
                frmBookInfoWindow frmBookInfo = new frmBookInfoWindow(bookInfo);
                frmBookInfo.ShowDialog();
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
