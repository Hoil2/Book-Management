using BookManagement.Customer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class frmSearchOverdueUser : Form
    {
        public frmSearchOverdueUser()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            tlpUserList.Controls.Clear();
            int cnt = 0;
            for (int i = 0; i < Loan.database.Count; i++)
            {
                if (txtUserName.Text.Equals("")) break;
                if (Loan.database[i].userName.IndexOf(txtUserName.Text) != -1)
                {
                    DateTime date = DateTime.Parse(Loan.database[i].returnDate);
                    if (date.Ticks - DateTime.Now.Ticks < 0) // 연체
                    {
                        TimeSpan timeSpan = DateTime.Now - DateTime.Parse(Loan.database[i].returnDate);

                        AddUserID(Loan.database[i].userID, cnt);
                        AddUserName(Loan.database[i].userName, cnt);
                        AddBookReturnDate(Loan.database[i].returnDate, cnt);
                        AddArrears((int)timeSpan.TotalDays, cnt);
                        AddUserInfoButton(User.FindUser(Loan.database[i].userID), cnt);
                        cnt++;
                    }
                    
                }
            }
        }

        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            tlpUserList.Controls.Clear();
            int cnt = 0;
            for (int i = 0; i < Loan.database.Count; i++)
            {
                DateTime date = DateTime.Parse(Loan.database[i].returnDate);
                
                if (date.Ticks - DateTime.Now.Ticks < 0) // 연체
                {
                    TimeSpan timeSpan = DateTime.Now - DateTime.Parse(Loan.database[i].returnDate);
                    AddUserID(Loan.database[i].userID, cnt);
                    AddUserName(Loan.database[i].userName, cnt);
                    AddBookReturnDate(Loan.database[i].returnDate, cnt);
                    AddArrears((int)timeSpan.TotalDays, cnt);
                    AddUserInfoButton(User.FindUser(Loan.database[i].userID), cnt);
                    cnt++;
                }

            }
        }

        void AddUserID(string id, int row)
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = id;
            label.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            tlpUserList.Controls.Add(label, 0, row);
        }
        void AddUserName(string text, int row)
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = text;
            label.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            tlpUserList.Controls.Add(label, 1, row);
        }

        void AddBookReturnDate(string bookLoanPeriod, int row)
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = bookLoanPeriod;
            label.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            tlpUserList.Controls.Add(label, 2, row);
        }

        void AddArrears(int overdue, int row)
        {
            int arrears;
            if(overdue <= 7)
                arrears = 1000;
            else if(overdue <= 14)
                arrears = 2000;
            else if(overdue <= 30)
                arrears = 3000;
            else arrears = 4000;

            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = arrears.ToString();
            label.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            tlpUserList.Controls.Add(label, 3, row);
        }

        void AddUserInfoButton(UserInfo userInfo, int row)
        {
            Button button = new Button();

            button.Text = "도서정보";

            button.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            button.Click += new EventHandler(delegate
            {
                frmUserInfoWindow frmUserInfo = new frmUserInfoWindow(userInfo);
                frmUserInfo.ShowDialog();
            });
            tlpUserList.Controls.Add(button, 4, row);
        }
    }
}
