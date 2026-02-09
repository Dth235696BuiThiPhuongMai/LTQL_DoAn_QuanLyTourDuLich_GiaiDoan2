namespace QuanLyTourDuLich.Forms
{
    partial class frmChuyenDi
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
            DSChuyenDi = new DataGridView();
            IDChuyen = new DataGridViewTextBoxColumn();
            IDTuyen = new DataGridViewTextBoxColumn();
            TGKhoiHanh = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            lbMaTuyen = new Label();
            lbTGKH = new Label();
            lbMaChuyen = new Label();
            txtMaTuyen = new TextBox();
            txtMaChuyenDi = new TextBox();
            grbDanhSachChuyenDi = new GroupBox();
            grbChuyenDi = new GroupBox();
            TgKH = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DSChuyenDi).BeginInit();
            grbDanhSachChuyenDi.SuspendLayout();
            grbChuyenDi.SuspendLayout();
            SuspendLayout();
            // 
            // DSChuyenDi
            // 
            DSChuyenDi.AllowUserToAddRows = false;
            DSChuyenDi.AllowUserToDeleteRows = false;
            DSChuyenDi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DSChuyenDi.BackgroundColor = Color.White;
            DSChuyenDi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DSChuyenDi.Columns.AddRange(new DataGridViewColumn[] { IDChuyen, IDTuyen, TGKhoiHanh });
            DSChuyenDi.Location = new Point(21, 34);
            DSChuyenDi.Name = "DSChuyenDi";
            DSChuyenDi.ReadOnly = true;
            DSChuyenDi.RowHeadersVisible = false;
            DSChuyenDi.RowHeadersWidth = 62;
            DSChuyenDi.Size = new Size(908, 346);
            DSChuyenDi.TabIndex = 0;
            // 
            // IDChuyen
            // 
            IDChuyen.HeaderText = "Mã Chuyến";
            IDChuyen.MinimumWidth = 8;
            IDChuyen.Name = "IDChuyen";
            IDChuyen.ReadOnly = true;
            // 
            // IDTuyen
            // 
            IDTuyen.HeaderText = "Mã Tuyến";
            IDTuyen.MinimumWidth = 8;
            IDTuyen.Name = "IDTuyen";
            IDTuyen.ReadOnly = true;
            // 
            // TGKhoiHanh
            // 
            TGKhoiHanh.HeaderText = "Thời gian khởi hành";
            TGKhoiHanh.MinimumWidth = 8;
            TGKhoiHanh.Name = "TGKhoiHanh";
            TGKhoiHanh.ReadOnly = true;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Location = new Point(251, 91);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 41);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Location = new Point(371, 91);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 41);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Popup;
            btnLuu.Location = new Point(491, 91);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(95, 41);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.FlatStyle = FlatStyle.Popup;
            btnHuy.Location = new Point(611, 91);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(95, 41);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Location = new Point(731, 91);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 41);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Location = new Point(136, 91);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 41);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lbMaTuyen
            // 
            lbMaTuyen.Location = new Point(281, 43);
            lbMaTuyen.Name = "lbMaTuyen";
            lbMaTuyen.Size = new Size(115, 31);
            lbMaTuyen.TabIndex = 6;
            lbMaTuyen.Text = "Mã Tuyến";
            // 
            // lbTGKH
            // 
            lbTGKH.Location = new Point(597, 43);
            lbTGKH.Name = "lbTGKH";
            lbTGKH.Size = new Size(187, 31);
            lbTGKH.TabIndex = 5;
            lbTGKH.Text = "Thời Gian Khởi Hành";
            // 
            // lbMaChuyen
            // 
            lbMaChuyen.Location = new Point(6, 43);
            lbMaChuyen.Name = "lbMaChuyen";
            lbMaChuyen.Size = new Size(128, 31);
            lbMaChuyen.TabIndex = 4;
            lbMaChuyen.Text = "Mã Chuyến Đi";
            // 
            // txtMaTuyen
            // 
            txtMaTuyen.BorderStyle = BorderStyle.None;
            txtMaTuyen.Location = new Point(389, 43);
            txtMaTuyen.Name = "txtMaTuyen";
            txtMaTuyen.Size = new Size(202, 24);
            txtMaTuyen.TabIndex = 3;
            // 
            // txtMaChuyenDi
            // 
            txtMaChuyenDi.BorderStyle = BorderStyle.None;
            txtMaChuyenDi.Location = new Point(137, 43);
            txtMaChuyenDi.Name = "txtMaChuyenDi";
            txtMaChuyenDi.Size = new Size(118, 24);
            txtMaChuyenDi.TabIndex = 0;
            // 
            // grbDanhSachChuyenDi
            // 
            grbDanhSachChuyenDi.Controls.Add(DSChuyenDi);
            grbDanhSachChuyenDi.Location = new Point(21, 182);
            grbDanhSachChuyenDi.Name = "grbDanhSachChuyenDi";
            grbDanhSachChuyenDi.Size = new Size(939, 391);
            grbDanhSachChuyenDi.TabIndex = 3;
            grbDanhSachChuyenDi.TabStop = false;
            grbDanhSachChuyenDi.Text = "Danh Sách Chuyến Đi";
            // 
            // grbChuyenDi
            // 
            grbChuyenDi.Controls.Add(TgKH);
            grbChuyenDi.Controls.Add(btnXoa);
            grbChuyenDi.Controls.Add(btnSua);
            grbChuyenDi.Controls.Add(btnLuu);
            grbChuyenDi.Controls.Add(btnHuy);
            grbChuyenDi.Controls.Add(btnThoat);
            grbChuyenDi.Controls.Add(btnThem);
            grbChuyenDi.Controls.Add(lbMaTuyen);
            grbChuyenDi.Controls.Add(lbTGKH);
            grbChuyenDi.Controls.Add(lbMaChuyen);
            grbChuyenDi.Controls.Add(txtMaTuyen);
            grbChuyenDi.Controls.Add(txtMaChuyenDi);
            grbChuyenDi.Location = new Point(19, 21);
            grbChuyenDi.Name = "grbChuyenDi";
            grbChuyenDi.Size = new Size(941, 155);
            grbChuyenDi.TabIndex = 2;
            grbChuyenDi.TabStop = false;
            grbChuyenDi.Text = "Quản Lý Chuyến Đi";
            // 
            // TgKH
            // 
            TgKH.Format = DateTimePickerFormat.Short;
            TgKH.Location = new Point(769, 43);
            TgKH.Name = "TgKH";
            TgKH.Size = new Size(162, 31);
            TgKH.TabIndex = 13;
            // 
            // frmChuyenDi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 594);
            Controls.Add(grbDanhSachChuyenDi);
            Controls.Add(grbChuyenDi);
            Name = "frmChuyenDi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ Chuyến Đi";
            ((System.ComponentModel.ISupportInitialize)DSChuyenDi).EndInit();
            grbDanhSachChuyenDi.ResumeLayout(false);
            grbChuyenDi.ResumeLayout(false);
            grbChuyenDi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView DSChuyenDi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnThem;
        private Label lbMaTuyen;
        private Label lbTGKH;
        private Label lbMaChuyen;
        private TextBox txtMaTuyen;
        private TextBox txtMaChuyenDi;
        private GroupBox grbDanhSachChuyenDi;
        private GroupBox grbChuyenDi;
        private DateTimePicker TgKH;
        private DataGridViewTextBoxColumn IDChuyen;
        private DataGridViewTextBoxColumn IDTuyen;
        private DataGridViewTextBoxColumn TGKhoiHanh;
    }
}