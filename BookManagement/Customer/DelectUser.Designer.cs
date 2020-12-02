namespace BookManagement.Customer
{
    partial class DelectUser
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.textFindID = new System.Windows.Forms.TextBox();
            this.btnDelect = new System.Windows.Forms.Button();
            this.textShowID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 12F);
            this.btnSearch.Location = new System.Drawing.Point(253, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "회원검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textFindID
            // 
            this.textFindID.Location = new System.Drawing.Point(47, 22);
            this.textFindID.Name = "textFindID";
            this.textFindID.Size = new System.Drawing.Size(200, 21);
            this.textFindID.TabIndex = 2;
            // 
            // btnDelect
            // 
            this.btnDelect.Font = new System.Drawing.Font("굴림", 12F);
            this.btnDelect.Location = new System.Drawing.Point(151, 217);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(86, 32);
            this.btnDelect.TabIndex = 4;
            this.btnDelect.Text = "회원삭제";
            this.btnDelect.UseVisualStyleBackColor = true;
            this.btnDelect.Click += new System.EventHandler(this.btnDelect_Click);
            // 
            // textShowID
            // 
            this.textShowID.Location = new System.Drawing.Point(47, 49);
            this.textShowID.Multiline = true;
            this.textShowID.Name = "textShowID";
            this.textShowID.Size = new System.Drawing.Size(292, 162);
            this.textShowID.TabIndex = 5;
            // 
            // DelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.textShowID);
            this.Controls.Add(this.btnDelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textFindID);
            this.Name = "DelectUser";
            this.Text = "회원삭제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textFindID;
        private System.Windows.Forms.Button btnDelect;
        private System.Windows.Forms.TextBox textShowID;
    }
}