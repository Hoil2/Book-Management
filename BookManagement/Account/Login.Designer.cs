namespace BookManagement
{
    partial class frmLogin
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.findIDbtn = new System.Windows.Forms.Button();
            this.findPwdbtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(81, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(81, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("굴림", 10F);
            this.textID.Location = new System.Drawing.Point(154, 87);
            this.textID.MaxLength = 12;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 23);
            this.textID.TabIndex = 3;
            this.textID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textID_KeyDown);
            // 
            // textPwd
            // 
            this.textPwd.Font = new System.Drawing.Font("굴림", 10F);
            this.textPwd.Location = new System.Drawing.Point(154, 142);
            this.textPwd.MaxLength = 12;
            this.textPwd.Name = "textPwd";
            this.textPwd.PasswordChar = '●';
            this.textPwd.Size = new System.Drawing.Size(100, 23);
            this.textPwd.TabIndex = 4;
            this.textPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPwd_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("굴림", 10F);
            this.btnLogin.Location = new System.Drawing.Point(279, 103);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 55);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // findIDbtn
            // 
            this.findIDbtn.Font = new System.Drawing.Font("굴림", 10F);
            this.findIDbtn.Location = new System.Drawing.Point(25, 239);
            this.findIDbtn.Name = "findIDbtn";
            this.findIDbtn.Size = new System.Drawing.Size(90, 42);
            this.findIDbtn.TabIndex = 6;
            this.findIDbtn.Text = "아이디 찾기";
            this.findIDbtn.UseVisualStyleBackColor = true;
            this.findIDbtn.Click += new System.EventHandler(this.findIDbtn_Click);
            // 
            // findPwdbtn
            // 
            this.findPwdbtn.Font = new System.Drawing.Font("굴림", 10F);
            this.findPwdbtn.Location = new System.Drawing.Point(139, 239);
            this.findPwdbtn.Name = "findPwdbtn";
            this.findPwdbtn.Size = new System.Drawing.Size(104, 42);
            this.findPwdbtn.TabIndex = 7;
            this.findPwdbtn.Text = "비밀번호 찾기";
            this.findPwdbtn.UseVisualStyleBackColor = true;
            this.findPwdbtn.Click += new System.EventHandler(this.findPwdbtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.Font = new System.Drawing.Font("굴림", 10F);
            this.newbtn.Location = new System.Drawing.Point(264, 239);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(90, 42);
            this.newbtn.TabIndex = 8;
            this.newbtn.Text = "회원가입";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.findPwdbtn);
            this.Controls.Add(this.findIDbtn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmLogin";
            this.Text = "로그인창";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button findIDbtn;
        private System.Windows.Forms.Button findPwdbtn;
        private System.Windows.Forms.Button newbtn;
    }
}

