namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = SystemColors.HotTrack;
            lblAppName.Location = new Point(244, 36);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(155, 65);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            lblAppName.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(146, 153);
            txtID.Name = "txtID";
            txtID.Size = new Size(359, 43);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.TextChanged += textBox1_TextChanged;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(146, 215);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(359, 43);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(146, 320);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(359, 43);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(146, 270);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(242, 15);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 일치하지 않습니다.";
            lblErrorMsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 497);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            Load += ㅌ;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblErrorMsg;
    }
}
