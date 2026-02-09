namespace QuanLyTourDuLich.Forms
{
    partial class frmTrangChuDangNhap
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
            lbUser = new Label();
            lbPassWord = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            grbLogin = new GroupBox();
            show = new CheckBox();
            btnLogin = new Button();
            btnCancel = new Button();
            grbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(101, 145);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(47, 25);
            lbUser.TabIndex = 0;
            lbUser.Text = "User";
            // 
            // lbPassWord
            // 
            lbPassWord.AutoSize = true;
            lbPassWord.Location = new Point(101, 222);
            lbPassWord.Name = "lbPassWord";
            lbPassWord.Size = new Size(87, 25);
            lbPassWord.TabIndex = 1;
            lbPassWord.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Location = new Point(215, 139);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(298, 31);
            txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(215, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(298, 31);
            txtPassword.TabIndex = 3;
            // 
            // grbLogin
            // 
            grbLogin.Controls.Add(btnCancel);
            grbLogin.Controls.Add(btnLogin);
            grbLogin.Controls.Add(show);
            grbLogin.Controls.Add(txtPassword);
            grbLogin.Controls.Add(txtUser);
            grbLogin.Controls.Add(lbPassWord);
            grbLogin.Controls.Add(lbUser);
            grbLogin.Location = new Point(160, 51);
            grbLogin.Name = "grbLogin";
            grbLogin.Size = new Size(671, 442);
            grbLogin.TabIndex = 4;
            grbLogin.TabStop = false;
            grbLogin.Text = "Login";
            // 
            // show
            // 
            show.AutoSize = true;
            show.Location = new Point(215, 289);
            show.Name = "show";
            show.Size = new Size(164, 29);
            show.TabIndex = 4;
            show.Text = "Show password";
            show.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(215, 351);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(395, 351);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 39);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmTrangChuDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 594);
            Controls.Add(grbLogin);
            Name = "frmTrangChuDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý đăng nhập";
            grbLogin.ResumeLayout(false);
            grbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbUser;
        private Label lbPassWord;
        private TextBox txtUser;
        private TextBox txtPassword;
        private GroupBox grbLogin;
        private Button btnLogin;
        private CheckBox show;
        private Button btnCancel;
    }
}