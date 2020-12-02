namespace BookManagement.Customer
{
    partial class DelectUserInputPW
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
            this.textDelectPW = new System.Windows.Forms.TextBox();
            this.btnDelectInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textDelectPW
            // 
            this.textDelectPW.Location = new System.Drawing.Point(71, 53);
            this.textDelectPW.Name = "textDelectPW";
            this.textDelectPW.PasswordChar = '●';
            this.textDelectPW.Size = new System.Drawing.Size(150, 21);
            this.textDelectPW.TabIndex = 0;
            // 
            // btnDelectInput
            // 
            this.btnDelectInput.Font = new System.Drawing.Font("굴림", 12F);
            this.btnDelectInput.Location = new System.Drawing.Point(101, 98);
            this.btnDelectInput.Name = "btnDelectInput";
            this.btnDelectInput.Size = new System.Drawing.Size(75, 34);
            this.btnDelectInput.TabIndex = 1;
            this.btnDelectInput.Text = "입력";
            this.btnDelectInput.UseVisualStyleBackColor = true;
            this.btnDelectInput.Click += new System.EventHandler(this.btnDelectInput_Click);
            // 
            // DelectUserInputPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnDelectInput);
            this.Controls.Add(this.textDelectPW);
            this.Name = "DelectUserInputPW";
            this.Text = "비밀번호 입력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDelectPW;
        private System.Windows.Forms.Button btnDelectInput;
    }
}