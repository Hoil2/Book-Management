namespace BookManagement
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPhone3 = new System.Windows.Forms.TextBox();
            this.textPhone2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPhone1 = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(230, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(157, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "-";
            // 
            // textPhone3
            // 
            this.textPhone3.Location = new System.Drawing.Point(251, 132);
            this.textPhone3.MaxLength = 4;
            this.textPhone3.Name = "textPhone3";
            this.textPhone3.Size = new System.Drawing.Size(50, 21);
            this.textPhone3.TabIndex = 14;
            this.textPhone3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPhone2
            // 
            this.textPhone2.Location = new System.Drawing.Point(174, 132);
            this.textPhone2.MaxLength = 4;
            this.textPhone2.Name = "textPhone2";
            this.textPhone2.Size = new System.Drawing.Size(50, 21);
            this.textPhone2.TabIndex = 13;
            this.textPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(35, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(49, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "아이디";
            // 
            // textPhone1
            // 
            this.textPhone1.Location = new System.Drawing.Point(104, 132);
            this.textPhone1.MaxLength = 3;
            this.textPhone1.Name = "textPhone1";
            this.textPhone1.Size = new System.Drawing.Size(50, 21);
            this.textPhone1.TabIndex = 10;
            this.textPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(104, 73);
            this.textID.MaxLength = 12;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(120, 21);
            this.textID.TabIndex = 9;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("굴림", 10F);
            this.btnCancle.Location = new System.Drawing.Point(203, 189);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(80, 40);
            this.btnCancle.TabIndex = 18;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("굴림", 10F);
            this.btnInput.Location = new System.Drawing.Point(86, 189);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(80, 40);
            this.btnInput.TabIndex = 17;
            this.btnInput.Text = "입력";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPhone3);
            this.Controls.Add(this.textPhone2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPhone1);
            this.Controls.Add(this.textID);
            this.Name = "Form3";
            this.Text = "비밀번호 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPhone3;
        private System.Windows.Forms.TextBox textPhone2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPhone1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnInput;
    }
}