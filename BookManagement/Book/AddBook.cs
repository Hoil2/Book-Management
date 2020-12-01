using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class AddBook : Form
    {
        MonthCalendar calendar;
        string bookDatabasePath = @"Book\BookDatabase.txt";
        public AddBook()
        {
            InitializeComponent();
            calendar = new MonthCalendar();
            calendar.Location = new Point(220, 100);
            calendar.DateSelected += new DateRangeEventHandler(DateSelected);
            calendar.Enabled = false;
            cboxBookStatus.SelectedIndex = 0;

        }

        private void DateSelected(object sender, DateRangeEventArgs e)
        {
            calendar.Enabled = false;
            lblPublicationYear.Text = calendar.SelectionRange.Start.ToString("yyyy-MM-dd");
            Controls.Remove(calendar);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if (!calendar.Enabled)
            {
                calendar.Enabled = true;
                Controls.Add(calendar);
                Controls.SetChildIndex(calendar, 0);
            }
            else
            {
                calendar.Enabled = false;
                Controls.Remove(calendar);
            }
        }

        private void lblPublicationYear_Click(object sender, EventArgs e)
        {
            btnCalendar_Click(sender, e); // 위와 같음
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "" || txtBookName.Text == "" || txtPublisher.Text == "" || lblPublicationYear.Text == "")
            {
                MessageBox.Show("빈 칸이 있습니다.");
                return;
            }

            DirectoryInfo di = new DirectoryInfo(@"Book");
            if (!di.Exists) di.Create();

            string _bookNumber = CreateRegistrationNumber(); // 등록번호 부여
            BookInfo bookInfo = new BookInfo()
            {
                bookNumber = _bookNumber,
                bookName = txtBookName.Text,
                author = txtAuthor.Text,
                publisher = txtPublisher.Text,
                publicationYear = lblPublicationYear.Text,
                bookStatus = cboxBookStatus.Text,
                bookLoanPeriod = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd")
            };
            Book.database.Add(bookInfo);
            Book.BookSave();
            Close();
            MessageBox.Show("추가 성공");
        }

        string CreateRegistrationNumber()
        {
            for (int i = 0; i < Book.database.Count; i++)
            {
                if(int.Parse(Book.database[i].bookNumber) != (i+1))
                {
                    return (i+1).ToString("00000000");
                }
            }
            return (Book.database.Count + 1).ToString("00000000");
        }


        private void AddBook_Click(object sender, EventArgs e)
        {
            calendar.Enabled = false;
            Controls.Remove(calendar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
