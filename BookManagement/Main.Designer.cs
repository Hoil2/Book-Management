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
            this.연체도서검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연체이용자검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.문의ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도서ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.이용자통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이용통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBookQ = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMemberQ = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQandA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.대출반납ToolStripMenuItem,
            this.도서ToolStripMenuItem,
            this.연체ToolStripMenuItem,
            this.문의ToolStripMenuItem,
            this.이용통계ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(645, 30);
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
            this.menuSearchUser.Size = new System.Drawing.Size(152, 26);
            this.menuSearchUser.Text = "회원검색";
            this.menuSearchUser.Click += new System.EventHandler(this.menuSearchUser_Click);
            // 
            // menuModifyUser
            // 
            this.menuModifyUser.Name = "menuModifyUser";
            this.menuModifyUser.Size = new System.Drawing.Size(152, 26);
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
            this.menuLoanBook.Size = new System.Drawing.Size(224, 26);
            this.menuLoanBook.Text = "도서대출";
            this.menuLoanBook.Click += new System.EventHandler(this.menuLoanBook_Click);
            // 
            // menuLoanExtension
            // 
            this.menuLoanExtension.Name = "menuLoanExtension";
            this.menuLoanExtension.Size = new System.Drawing.Size(224, 26);
            this.menuLoanExtension.Text = "대출연장";
            this.menuLoanExtension.Click += new System.EventHandler(this.menuLoanExtension_Click);
            // 
            // menuReturnBook
            // 
            this.menuReturnBook.Name = "menuReturnBook";
            this.menuReturnBook.Size = new System.Drawing.Size(224, 26);
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
            this.menuSearchBook.Size = new System.Drawing.Size(152, 26);
            this.menuSearchBook.Text = "도서검색";
            this.menuSearchBook.Click += new System.EventHandler(this.menuSearchBook_Click);
            // 
            // menuModifyBook
            // 
            this.menuModifyBook.Name = "menuModifyBook";
            this.menuModifyBook.Size = new System.Drawing.Size(152, 26);
            this.menuModifyBook.Text = "도서수정";
            this.menuModifyBook.Click += new System.EventHandler(this.menuModifyBook_Click);
            // 
            // menuAddBook
            // 
            this.menuAddBook.Name = "menuAddBook";
            this.menuAddBook.Size = new System.Drawing.Size(152, 26);
            this.menuAddBook.Text = "도서추가";
            this.menuAddBook.Click += new System.EventHandler(this.menuAddBook_Click);
            // 
            // 연체ToolStripMenuItem
            // 
            this.연체ToolStripMenuItem.AutoSize = false;
            this.연체ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.연체도서검색ToolStripMenuItem,
            this.연체이용자검색ToolStripMenuItem});
            this.연체ToolStripMenuItem.Name = "연체ToolStripMenuItem";
            this.연체ToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.연체ToolStripMenuItem.Text = "연체";
            // 
            // 연체도서검색ToolStripMenuItem
            // 
            this.연체도서검색ToolStripMenuItem.Name = "연체도서검색ToolStripMenuItem";
            this.연체도서검색ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.연체도서검색ToolStripMenuItem.Text = "연체도서검색";
            // 
            // 연체이용자검색ToolStripMenuItem
            // 
            this.연체이용자검색ToolStripMenuItem.Name = "연체이용자검색ToolStripMenuItem";
            this.연체이용자검색ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.연체이용자검색ToolStripMenuItem.Text = "연체이용자검색";
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
            this.도서ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.도서ToolStripMenuItem1.Text = "도서대출통계";
            // 
            // 이용자통계ToolStripMenuItem
            // 
            this.이용자통계ToolStripMenuItem.Name = "이용자통계ToolStripMenuItem";
            this.이용자통계ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.이용자통계ToolStripMenuItem.Text = "이용자통계";
            // 
            // 이용통계ToolStripMenuItem
            // 
            this.이용통계ToolStripMenuItem.AutoSize = false;
            this.이용통계ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBookQ,
            this.menuMemberQ,
            this.menuQandA});
            this.이용통계ToolStripMenuItem.Name = "이용통계ToolStripMenuItem";
            this.이용통계ToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.이용통계ToolStripMenuItem.Text = "문의";
            // 
            // menuBookQ
            // 
            this.menuBookQ.Name = "menuBookQ";
            this.menuBookQ.Size = new System.Drawing.Size(224, 26);
            this.menuBookQ.Text = "도서문의";
            this.menuBookQ.Click += new System.EventHandler(this.menuBookQ_Click);
            // 
            // menuMemberQ
            // 
            this.menuMemberQ.Name = "menuMemberQ";
            this.menuMemberQ.Size = new System.Drawing.Size(224, 26);
            this.menuMemberQ.Text = "회원문의";
            this.menuMemberQ.Click += new System.EventHandler(this.menuMemberQ_Click);
            // 
            // menuQandA
            // 
            this.menuQandA.Name = "menuQandA";
            this.menuQandA.Size = new System.Drawing.Size(224, 26);
            this.menuQandA.Text = "자주하는 질문";
            this.menuQandA.Click += new System.EventHandler(this.menuQandA_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(645, 470);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ToolStripMenuItem 연체도서검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 연체이용자검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도서ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 이용자통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBookQ;
        private System.Windows.Forms.ToolStripMenuItem menuMemberQ;
        private System.Windows.Forms.ToolStripMenuItem menuQandA;
        private System.Windows.Forms.ToolStripMenuItem menuLoanExtension;
    }
}