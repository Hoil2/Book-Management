﻿namespace BookManagement
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModifyUser = new System.Windows.Forms.ToolStripMenuItem();
            this.대출반납ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoanBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoanExtension = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.도서ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModifyBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.연체ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchOverdueBook = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearchOverdueUser = new System.Windows.Forms.ToolStripMenuItem();
            this.문의ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도서ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.이용자통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이용통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도서문의ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원문의ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자주하는질문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.대출반납ToolStripMenuItem,
            this.도서ToolStripMenuItem,
            this.연체ToolStripMenuItem,
            this.문의ToolStripMenuItem,
            this.이용통계ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.AutoSize = false;
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearchUser,
            this.menuModifyUser});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.파일ToolStripMenuItem.Text = "회원";
            // 
            // menuSearchUser
            // 
            this.menuSearchUser.Name = "menuSearchUser";
            this.menuSearchUser.Size = new System.Drawing.Size(122, 22);
            this.menuSearchUser.Text = "회원검색";
            this.menuSearchUser.Click += new System.EventHandler(this.menuSearchUser_Click);
            // 
            // menuModifyUser
            // 
            this.menuModifyUser.Name = "menuModifyUser";
            this.menuModifyUser.Size = new System.Drawing.Size(122, 22);
            this.menuModifyUser.Text = "회원수정";
            this.menuModifyUser.Click += new System.EventHandler(this.menuModifyUser_Click);
            // 
            // 대출반납ToolStripMenuItem
            // 
            this.대출반납ToolStripMenuItem.AutoSize = false;
            this.대출반납ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoanBook,
            this.menuLoanExtension,
            this.menuReturnBook});
            this.대출반납ToolStripMenuItem.Name = "대출반납ToolStripMenuItem";
            this.대출반납ToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.대출반납ToolStripMenuItem.Text = "대출/반납";
            // 
            // menuLoanBook
            // 
            this.menuLoanBook.Name = "menuLoanBook";
            this.menuLoanBook.Size = new System.Drawing.Size(122, 22);
            this.menuLoanBook.Text = "도서대출";
            this.menuLoanBook.Click += new System.EventHandler(this.menuLoanBook_Click);
            // 
            // menuLoanExtension
            // 
            this.menuLoanExtension.Name = "menuLoanExtension";
            this.menuLoanExtension.Size = new System.Drawing.Size(122, 22);
            this.menuLoanExtension.Text = "대출연장";
            this.menuLoanExtension.Click += new System.EventHandler(this.menuLoanExtension_Click);
            // 
            // menuReturnBook
            // 
            this.menuReturnBook.Name = "menuReturnBook";
            this.menuReturnBook.Size = new System.Drawing.Size(122, 22);
            this.menuReturnBook.Text = "도서반납";
            this.menuReturnBook.Click += new System.EventHandler(this.menuReturnBook_Click);
            // 
            // 도서ToolStripMenuItem
            // 
            this.도서ToolStripMenuItem.AutoSize = false;
            this.도서ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearchBook,
            this.menuModifyBook,
            this.menuAddBook});
            this.도서ToolStripMenuItem.Name = "도서ToolStripMenuItem";
            this.도서ToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.도서ToolStripMenuItem.Text = "도서";
            // 
            // menuSearchBook
            // 
            this.menuSearchBook.Name = "menuSearchBook";
            this.menuSearchBook.Size = new System.Drawing.Size(180, 22);
            this.menuSearchBook.Text = "도서검색";
            this.menuSearchBook.Click += new System.EventHandler(this.menuSearchBook_Click);
            // 
            // menuModifyBook
            // 
            this.menuModifyBook.Name = "menuModifyBook";
            this.menuModifyBook.Size = new System.Drawing.Size(180, 22);
            this.menuModifyBook.Text = "도서수정";
            this.menuModifyBook.Click += new System.EventHandler(this.menuModifyBook_Click);
            // 
            // menuAddBook
            // 
            this.menuAddBook.Name = "menuAddBook";
            this.menuAddBook.Size = new System.Drawing.Size(180, 22);
            this.menuAddBook.Text = "도서추가";
            this.menuAddBook.Click += new System.EventHandler(this.menuAddBook_Click);
            // 
            // 연체ToolStripMenuItem
            // 
            this.연체ToolStripMenuItem.AutoSize = false;
            this.연체ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearchOverdueBook,
            this.menuSearchOverdueUser});
            this.연체ToolStripMenuItem.Name = "연체ToolStripMenuItem";
            this.연체ToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.연체ToolStripMenuItem.Text = "연체";
            // 
            // menuSearchOverdueBook
            // 
            this.menuSearchOverdueBook.Name = "menuSearchOverdueBook";
            this.menuSearchOverdueBook.Size = new System.Drawing.Size(180, 22);
            this.menuSearchOverdueBook.Text = "연체도서검색";
            this.menuSearchOverdueBook.Click += new System.EventHandler(this.menuSearchOverdueBook_Click);
            // 
            // menuSearchOverdueUser
            // 
            this.menuSearchOverdueUser.Name = "menuSearchOverdueUser";
            this.menuSearchOverdueUser.Size = new System.Drawing.Size(180, 22);
            this.menuSearchOverdueUser.Text = "연체이용자검색";
            this.menuSearchOverdueUser.Click += new System.EventHandler(this.menuSearchOverdueUser_Click);
            // 
            // 문의ToolStripMenuItem
            // 
            this.문의ToolStripMenuItem.AutoSize = false;
            this.문의ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도서ToolStripMenuItem1,
            this.이용자통계ToolStripMenuItem});
            this.문의ToolStripMenuItem.Name = "문의ToolStripMenuItem";
            this.문의ToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.문의ToolStripMenuItem.Text = "이용통계";
            // 
            // 도서ToolStripMenuItem1
            // 
            this.도서ToolStripMenuItem1.Name = "도서ToolStripMenuItem1";
            this.도서ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.도서ToolStripMenuItem1.Text = "도서대출통계";
            // 
            // 이용자통계ToolStripMenuItem
            // 
            this.이용자통계ToolStripMenuItem.Name = "이용자통계ToolStripMenuItem";
            this.이용자통계ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.이용자통계ToolStripMenuItem.Text = "이용자통계";
            // 
            // 이용통계ToolStripMenuItem
            // 
            this.이용통계ToolStripMenuItem.AutoSize = false;
            this.이용통계ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도서문의ToolStripMenuItem,
            this.회원문의ToolStripMenuItem,
            this.자주하는질문ToolStripMenuItem});
            this.이용통계ToolStripMenuItem.Name = "이용통계ToolStripMenuItem";
            this.이용통계ToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.이용통계ToolStripMenuItem.Text = "문의";
            // 
            // 도서문의ToolStripMenuItem
            // 
            this.도서문의ToolStripMenuItem.Name = "도서문의ToolStripMenuItem";
            this.도서문의ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.도서문의ToolStripMenuItem.Text = "도서문의";
            // 
            // 회원문의ToolStripMenuItem
            // 
            this.회원문의ToolStripMenuItem.Name = "회원문의ToolStripMenuItem";
            this.회원문의ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회원문의ToolStripMenuItem.Text = "회원문의";
            // 
            // 자주하는질문ToolStripMenuItem
            // 
            this.자주하는질문ToolStripMenuItem.Name = "자주하는질문ToolStripMenuItem";
            this.자주하는질문ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.자주하는질문ToolStripMenuItem.Text = "자주하는 질문";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(564, 376);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 대출반납ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도서ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 연체ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 문의ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이용통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSearchUser;
        private System.Windows.Forms.ToolStripMenuItem menuModifyUser;
        private System.Windows.Forms.ToolStripMenuItem menuLoanBook;
        private System.Windows.Forms.ToolStripMenuItem menuReturnBook;
        private System.Windows.Forms.ToolStripMenuItem menuSearchBook;
        private System.Windows.Forms.ToolStripMenuItem menuModifyBook;
        private System.Windows.Forms.ToolStripMenuItem menuAddBook;
        private System.Windows.Forms.ToolStripMenuItem menuSearchOverdueBook;
        private System.Windows.Forms.ToolStripMenuItem menuSearchOverdueUser;
        private System.Windows.Forms.ToolStripMenuItem 도서ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 이용자통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도서문의ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원문의ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자주하는질문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLoanExtension;
    }
}