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
    public partial class frmBookInfoWindow : Form
    {
        public frmBookInfoWindow(BookInfo bookInfo)
        {
            InitializeComponent();
            lblBookName.Text = bookInfo.bookName;
            lblAuthor.Text = bookInfo.author;
            lblPublisher.Text = bookInfo.publisher;
            lblPublicationYear.Text = bookInfo.publicationYear;
            lblBookStatus.Text = bookInfo.bookStatus;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
