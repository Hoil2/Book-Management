namespace BookManagement.Customer
{
    partial class SearchUser
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
            this.textFindID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textShowID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textFindID
            // 
            this.textFindID.Location = new System.Drawing.Point(51, 21);
            this.textFindID.Name = "textFindID";
            this.textFindID.Size = new System.Drawing.Size(200, 21);
            this.textFindID.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F);
            this.button1.Location = new System.Drawing.Point(257, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "회원검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textShowID
            // 
            this.textShowID.Location = new System.Drawing.Point(51, 49);
            this.textShowID.Multiline = true;
            this.textShowID.Name = "textShowID";
            this.textShowID.Size = new System.Drawing.Size(292, 200);
            this.textShowID.TabIndex = 2;
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.textShowID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textFindID);
            this.Name = "SearchUser";
            this.Text = "회원검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFindID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textShowID;
    }
}