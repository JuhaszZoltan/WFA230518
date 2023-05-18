namespace WFA230518
{
    partial class FrmLogIn
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
            lblUn = new Label();
            txtUserName = new TextBox();
            btnLogIn = new Button();
            lblPw = new Label();
            txtPassWord = new TextBox();
            SuspendLayout();
            // 
            // lblUn
            // 
            lblUn.AutoSize = true;
            lblUn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUn.Location = new Point(37, 15);
            lblUn.Name = "lblUn";
            lblUn.Size = new Size(104, 25);
            lblUn.TabIndex = 0;
            lblUn.Text = "username:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(147, 12);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(192, 32);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "diak171";
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.Location = new Point(12, 88);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(327, 42);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // lblPw
            // 
            lblPw.AutoSize = true;
            lblPw.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPw.Location = new Point(39, 53);
            lblPw.Name = "lblPw";
            lblPw.Size = new Size(102, 25);
            lblPw.TabIndex = 0;
            lblPw.Text = "password:";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(147, 50);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(192, 32);
            txtPassWord.TabIndex = 1;
            txtPassWord.Text = "ZDGE0W";
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 142);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassWord);
            Controls.Add(lblPw);
            Controls.Add(txtUserName);
            Controls.Add(lblUn);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "FrmLogIn";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUn;
        private TextBox txtUserName;
        private Button btnLogIn;
        private Label lblPw;
        private TextBox txtPassWord;
    }
}