namespace QuanLyTourDuLich.Forms
{
    partial class frmKhachHang
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
            ngSinh = new DateTimePicker();
            grbDanhSachChuyenDi = new GroupBox();
            DSChuyenDi = new DataGridView();
            grbChuyenDi = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            lbTenKH = new Label();
            lbSoDienThoaiKH = new Label();
            lbMaKH = new Label();
            txtMaTuyen = new TextBox();
            txtMaKH = new TextBox();
            txtSoDienThoai = new TextBox();
            lbNgaySinh = new Label();
            lbGioiTinh = new Label();
            gioiTinhNam = new CheckBox();
            gioiTinhNu = new CheckBox();
            lbDiaChi = new Label();
            txtDiaChi = new TextBox();
            MakH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            grbDanhSachChuyenDi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DSChuyenDi).BeginInit();
            grbChuyenDi.SuspendLayout();
            SuspendLayout();
            // 
            // ngSinh
            // 
            ngSinh.Format = DateTimePickerFormat.Short;
            ngSinh.Location = new Point(155, 95);
            ngSinh.Name = "ngSinh";
            ngSinh.Size = new Size(118, 31);
            ngSinh.TabIndex = 13;
            // 
            // grbDanhSachChuyenDi
            // 
            grbDanhSachChuyenDi.Controls.Add(DSChuyenDi);
            grbDanhSachChuyenDi.Location = new Point(21, 230);
            grbDanhSachChuyenDi.Name = "grbDanhSachChuyenDi";
            grbDanhSachChuyenDi.Size = new Size(939, 343);
            grbDanhSachChuyenDi.TabIndex = 5;
            grbDanhSachChuyenDi.TabStop = false;
            grbDanhSachChuyenDi.Text = "Danh Sách Khách Hàng";
            // 
            // DSChuyenDi
            // 
            DSChuyenDi.AllowUserToAddRows = false;
            DSChuyenDi.AllowUserToDeleteRows = false;
            DSChuyenDi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DSChuyenDi.BackgroundColor = Color.White;
            DSChuyenDi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DSChuyenDi.Columns.AddRange(new DataGridViewColumn[] { MakH, TenKH, NgaySinh, GioiTinh, SoDienThoai, DiaChi });
            DSChuyenDi.Location = new Point(21, 34);
            DSChuyenDi.Name = "DSChuyenDi";
            DSChuyenDi.ReadOnly = true;
            DSChuyenDi.RowHeadersVisible = false;
            DSChuyenDi.RowHeadersWidth = 62;
            DSChuyenDi.Size = new Size(908, 309);
            DSChuyenDi.TabIndex = 0;
            // 
            // grbChuyenDi
            // 
            grbChuyenDi.Controls.Add(txtDiaChi);
            grbChuyenDi.Controls.Add(lbDiaChi);
            grbChuyenDi.Controls.Add(gioiTinhNu);
            grbChuyenDi.Controls.Add(gioiTinhNam);
            grbChuyenDi.Controls.Add(lbGioiTinh);
            grbChuyenDi.Controls.Add(lbNgaySinh);
            grbChuyenDi.Controls.Add(txtSoDienThoai);
            grbChuyenDi.Controls.Add(ngSinh);
            grbChuyenDi.Controls.Add(btnXoa);
            grbChuyenDi.Controls.Add(btnSua);
            grbChuyenDi.Controls.Add(btnLuu);
            grbChuyenDi.Controls.Add(btnHuy);
            grbChuyenDi.Controls.Add(btnThoat);
            grbChuyenDi.Controls.Add(btnThem);
            grbChuyenDi.Controls.Add(lbTenKH);
            grbChuyenDi.Controls.Add(lbSoDienThoaiKH);
            grbChuyenDi.Controls.Add(lbMaKH);
            grbChuyenDi.Controls.Add(txtMaTuyen);
            grbChuyenDi.Controls.Add(txtMaKH);
            grbChuyenDi.Location = new Point(19, 21);
            grbChuyenDi.Name = "grbChuyenDi";
            grbChuyenDi.Size = new Size(941, 194);
            grbChuyenDi.TabIndex = 4;
            grbChuyenDi.TabStop = false;
            grbChuyenDi.Text = "Quản Lý Khách Hàng";
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Location = new Point(254, 147);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 41);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Location = new Point(374, 147);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 41);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Popup;
            btnLuu.Location = new Point(494, 147);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(95, 41);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.FlatStyle = FlatStyle.Popup;
            btnHuy.Location = new Point(614, 147);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(95, 41);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Location = new Point(734, 147);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 41);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Location = new Point(139, 147);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 41);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lbTenKH
            // 
            lbTenKH.Location = new Point(281, 43);
            lbTenKH.Name = "lbTenKH";
            lbTenKH.Size = new Size(137, 31);
            lbTenKH.TabIndex = 6;
            lbTenKH.Text = "Tên khách hàng";
            // 
            // lbSoDienThoaiKH
            // 
            lbSoDienThoaiKH.Location = new Point(597, 43);
            lbSoDienThoaiKH.Name = "lbSoDienThoaiKH";
            lbSoDienThoaiKH.Size = new Size(142, 31);
            lbSoDienThoaiKH.TabIndex = 5;
            lbSoDienThoaiKH.Text = "Số điện thoại";
            // 
            // lbMaKH
            // 
            lbMaKH.Location = new Point(6, 43);
            lbMaKH.Name = "lbMaKH";
            lbMaKH.Size = new Size(143, 31);
            lbMaKH.TabIndex = 4;
            lbMaKH.Text = "Mã khách hàng";
            // 
            // txtMaTuyen
            // 
            txtMaTuyen.BorderStyle = BorderStyle.None;
            txtMaTuyen.Location = new Point(415, 43);
            txtMaTuyen.Name = "txtMaTuyen";
            txtMaTuyen.Size = new Size(202, 24);
            txtMaTuyen.TabIndex = 3;
            // 
            // txtMaKH
            // 
            txtMaKH.BorderStyle = BorderStyle.None;
            txtMaKH.Location = new Point(155, 43);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(118, 24);
            txtMaKH.TabIndex = 0;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.None;
            txtSoDienThoai.Location = new Point(729, 43);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(202, 24);
            txtSoDienThoai.TabIndex = 14;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.Location = new Point(6, 95);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(143, 31);
            lbNgaySinh.TabIndex = 15;
            lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.Location = new Point(281, 95);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(102, 31);
            lbGioiTinh.TabIndex = 16;
            lbGioiTinh.Text = "Giới tính";
            // 
            // gioiTinhNam
            // 
            gioiTinhNam.AutoSize = true;
            gioiTinhNam.Location = new Point(415, 95);
            gioiTinhNam.Name = "gioiTinhNam";
            gioiTinhNam.Size = new Size(76, 29);
            gioiTinhNam.TabIndex = 17;
            gioiTinhNam.Text = "Nam";
            gioiTinhNam.UseVisualStyleBackColor = true;
            // 
            // gioiTinhNu
            // 
            gioiTinhNu.AutoSize = true;
            gioiTinhNu.Location = new Point(507, 95);
            gioiTinhNu.Name = "gioiTinhNu";
            gioiTinhNu.Size = new Size(62, 29);
            gioiTinhNu.TabIndex = 18;
            gioiTinhNu.Text = "Nữ";
            gioiTinhNu.UseVisualStyleBackColor = true;
            // 
            // lbDiaChi
            // 
            lbDiaChi.Location = new Point(597, 95);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(95, 31);
            lbDiaChi.TabIndex = 19;
            lbDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Location = new Point(729, 95);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(202, 24);
            txtDiaChi.TabIndex = 20;
            // 
            // MakH
            // 
            MakH.HeaderText = "Mã khách hàng";
            MakH.MinimumWidth = 8;
            MakH.Name = "MakH";
            MakH.ReadOnly = true;
            // 
            // TenKH
            // 
            TenKH.HeaderText = "Họ tên";
            TenKH.MinimumWidth = 8;
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 8;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 8;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 8;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 594);
            Controls.Add(grbDanhSachChuyenDi);
            Controls.Add(grbChuyenDi);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ Khách Hàng";
            grbDanhSachChuyenDi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DSChuyenDi).EndInit();
            grbChuyenDi.ResumeLayout(false);
            grbChuyenDi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker ngSinh;
        private GroupBox grbDanhSachChuyenDi;
        private DataGridView DSChuyenDi;
        private GroupBox grbChuyenDi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnThem;
        private Label lbTenKH;
        private Label lbSoDienThoaiKH;
        private Label lbMaKH;
        private TextBox txtMaTuyen;
        private TextBox txtMaKH;
        private Label lbNgaySinh;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private Label lbDiaChi;
        private CheckBox gioiTinhNu;
        private CheckBox gioiTinhNam;
        private Label lbGioiTinh;
        private DataGridViewTextBoxColumn MakH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
    }
}