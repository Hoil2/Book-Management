namespace BookManagement
{
    partial class Form2
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textPhone1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.textPhone2 = new System.Windows.Forms.TextBox();
            this.textPhone3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(106, 76);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(120, 21);
            this.textName.TabIndex = 0;
            // 
            // textPhone1
            // 
            this.textPhone1.Location = new System.Drawing.Point(106, 135);
            this.textPhone1.Name = "textPhone1";
            this.textPhone1.Size = new System.Drawing.Size(50, 21);
            this.textPhone1.TabIndex = 1;
            this.textPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(65, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "성명";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(37, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "전화번호";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("굴림", 10F);
            this.btnInput.Location = new System.Drawing.Point(82, 192);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(80, 40);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "입력";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // textPhone2
            // 
            this.textPhone2.Location = new System.Drawing.Point(176, 135);
            this.textPhone2.Name = "textPhone2";
            this.textPhone2.Size = new System.Drawing.Size(50, 21);
            this.textPhone2.TabIndex = 5;
            this.textPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPhone3
            // 
            this.textPhone3.Location = new System.Drawing.Point(253, 135);
            this.textPhone3.Name = "textPhone3";
            this.textPhone3.Size = new System.Drawing.Size(50, 21);
            this.textPhone3.TabIndex = 6;
            this.textPhone3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(159, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(232, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "-";
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("굴림", 10F);
            this.btnCancle.Location = new System.Drawing.Point(199, 192);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(80, 40);
            this.btnCancle.TabIndex = 9;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPhone3);
            this.Controls.Add(this.textPhone2);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPhone1);
            this.Controls.Add(this.textName);
            this.Name = "Form2";
            this.Text = "아이디 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPhone1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox textPhone2;
        private System.Windows.Forms.TextBox textPhone3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancle;
    }
}