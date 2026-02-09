namespace QuanLyTourDuLich.Forms
{
    partial class frmNhanVien
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
            txtDiaChi = new TextBox();
            lbDiaChi = new Label();
            gioiTinhNu = new CheckBox();
            gioiTinhNam = new CheckBox();
            lbGioiTinh = new Label();
            lbNgaySinh = new Label();
            txtSoDienThoai = new TextBox();
            ngSinh = new DateTimePicker();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            lbTenNV = new Label();
            lbSoDienThoaiKH = new Label();
            lbMaNV = new Label();
            grbChuyenDi = new GroupBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            DSChuyenDi = new DataGridView();
            grbDanhSachChuyenDi = new GroupBox();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            MakH = new DataGridViewTextBoxColumn();
            grbChuyenDi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DSChuyenDi).BeginInit();
            grbDanhSachChuyenDi.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Location = new Point(729, 95);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(202, 24);
            txtDiaChi.TabIndex = 20;
            // 
            // lbDiaChi
            // 
            lbDiaChi.Location = new Point(597, 95);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(95, 31);
            lbDiaChi.TabIndex = 19;
            lbDiaChi.Text = "Địa chỉ";
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
            // lbGioiTinh
            // 
            lbGioiTinh.Location = new Point(281, 95);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(102, 31);
            lbGioiTinh.TabIndex = 16;
            lbGioiTinh.Text = "Giới tính";
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.Location = new Point(6, 95);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(143, 31);
            lbNgaySinh.TabIndex = 15;
            lbNgaySinh.Text = "Ngày sinh";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.None;
            txtSoDienThoai.Location = new Point(729, 43);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(202, 24);
            txtSoDienThoai.TabIndex = 14;
            // 
            // ngSinh
            // 
            ngSinh.Format = DateTimePickerFormat.Short;
            ngSinh.Location = new Point(155, 95);
            ngSinh.Name = "ngSinh";
            ngSinh.Size = new Size(118, 31);
            ngSinh.TabIndex = 13;
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
            // lbTenNV
            // 
            lbTenNV.Location = new Point(281, 43);
            lbTenNV.Name = "lbTenNV";
            lbTenNV.Size = new Size(137, 31);
            lbTenNV.TabIndex = 6;
            lbTenNV.Text = "Tên nhân viên";
            // 
            // lbSoDienThoaiKH
            // 
            lbSoDienThoaiKH.Location = new Point(597, 43);
            lbSoDienThoaiKH.Name = "lbSoDienThoaiKH";
            lbSoDienThoaiKH.Size = new Size(142, 31);
            lbSoDienThoaiKH.TabIndex = 5;
            lbSoDienThoaiKH.Text = "Số điện thoại";
            // 
            // lbMaNV
            // 
            lbMaNV.Location = new Point(6, 43);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(143, 31);
            lbMaNV.TabIndex = 4;
            lbMaNV.Text = "Mã nhân viên";
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
            grbChuyenDi.Controls.Add(lbTenNV);
            grbChuyenDi.Controls.Add(lbSoDienThoaiKH);
            grbChuyenDi.Controls.Add(lbMaNV);
            grbChuyenDi.Controls.Add(txtTenNV);
            grbChuyenDi.Controls.Add(txtMaNV);
            grbChuyenDi.Location = new Point(19, 21);
            grbChuyenDi.Name = "grbChuyenDi";
            grbChuyenDi.Size = new Size(941, 194);
            grbChuyenDi.TabIndex = 6;
            grbChuyenDi.TabStop = false;
            grbChuyenDi.Text = "Quản Lý Khách Hàng";
            // 
            // txtTenNV
            // 
            txtTenNV.BorderStyle = BorderStyle.None;
            txtTenNV.Location = new Point(415, 43);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(202, 24);
            txtTenNV.TabIndex = 3;
            // 
            // txtMaNV
            // 
            txtMaNV.BorderStyle = BorderStyle.None;
            txtMaNV.Location = new Point(155, 43);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(118, 24);
            txtMaNV.TabIndex = 0;
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
            // grbDanhSachChuyenDi
            // 
            grbDanhSachChuyenDi.Controls.Add(DSChuyenDi);
            grbDanhSachChuyenDi.Location = new Point(21, 230);
            grbDanhSachChuyenDi.Name = "grbDanhSachChuyenDi";
            grbDanhSachChuyenDi.Size = new Size(939, 343);
            grbDanhSachChuyenDi.TabIndex = 7;
            grbDanhSachChuyenDi.TabStop = false;
            grbDanhSachChuyenDi.Text = "Danh Sách Khách Hàng";
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 8;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 8;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 8;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // TenKH
            // 
            TenKH.HeaderText = "Họ tên";
            TenKH.MinimumWidth = 8;
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            // 
            // MakH
            // 
            MakH.HeaderText = "Mã khách hàng";
            MakH.MinimumWidth = 8;
            MakH.Name = "MakH";
            MakH.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 594);
            Controls.Add(grbChuyenDi);
            Controls.Add(grbDanhSachChuyenDi);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ Nhân Viên";
            grbChuyenDi.ResumeLayout(false);
            grbChuyenDi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DSChuyenDi).EndInit();
            grbDanhSachChuyenDi.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDiaChi;
        private Label lbDiaChi;
        private CheckBox gioiTinhNu;
        private CheckBox gioiTinhNam;
        private Label lbGioiTinh;
        private Label lbNgaySinh;
        private TextBox txtSoDienThoai;
        private DateTimePicker ngSinh;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnThem;
        private Label lbTenNV;
        private Label lbSoDienThoaiKH;
        private Label lbMaNV;
        private GroupBox grbChuyenDi;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private DataGridView DSChuyenDi;
        private GroupBox grbDanhSachChuyenDi;
        private DataGridViewTextBoxColumn MakH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
    }
}