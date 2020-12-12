namespace BookManagement
{
    partial class frmLoanBook
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
            this.btnAllSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpBookList = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAllSearch
            // 
            this.btnAllSearch.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAllSearch.Location = new System.Drawing.Point(439, 71);
            this.btnAllSearch.Name = "btnAllSearch";
            this.btnAllSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAllSearch.TabIndex = 11;
            this.btnAllSearch.Text = "전체검색";
            this.btnAllSearch.UseVisualStyleBackColor = true;
            this.btnAllSearch.Click += new System.EventHandler(this.btnAllSearch_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(235, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "대출";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpBookList
            // 
            this.tlpBookList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpBookList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpBookList.ColumnCount = 2;
            this.tlpBookList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpBookList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBookList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlpBookList.Location = new System.Drawing.Point(136, 101);
            this.tlpBookList.Name = "tlpBookList";
            this.tlpBookList.RowCount = 15;
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBookList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBookList.Size = new System.Drawing.Size(305, 260);
            this.tlpBookList.TabIndex = 9;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchBook.Location = new System.Drawing.Point(358, 71);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBook.TabIndex = 8;
            this.btnSearchBook.Text = "도서검색";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(133, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "도서명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbookName
            // 
            this.txtbookName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbookName.Location = new System.Drawing.Point(190, 73);
            this.txtbookName.Name = "txtbookName";
            this.txtbookName.Size = new System.Drawing.Size(160, 21);
            this.txtbookName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(328, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "회원아이디";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(413, 42);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 21);
            this.txtUserID.TabIndex = 13;
            // 
            // frmLoanBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 376);
            this.ControlBox = false;
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAllSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tlpBookList);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbookName);
            this.Name = "frmLoanBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlpBookList;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
    }
}