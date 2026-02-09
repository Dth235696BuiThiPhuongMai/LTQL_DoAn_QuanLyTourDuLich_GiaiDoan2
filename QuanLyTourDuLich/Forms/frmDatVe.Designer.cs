namespace QuanLyTourDuLich.Forms
{
    partial class frmDatVe
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TgKH = new DateTimePicker();
            grbDanhSachDatVe = new GroupBox();
            DSDatVe = new DataGridView();
            grbDatVe = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            lbMaKhachHang = new Label();
            lbNgayDat = new Label();
            lbMaChuyen = new Label();
            lbGiaVe = new Label();
            lbTrangThai = new Label();
            lbSoLuong = new Label();
            soLuongVe = new NumericUpDown();
            txtGiaVe = new TextBox();
            cboTrangThai = new ComboBox();
            MaVe = new DataGridViewTextBoxColumn();
            MaCD = new DataGridViewTextBoxColumn();
            MaKH = new DataGridViewTextBoxColumn();
            NgayDat = new DataGridViewTextBoxColumn();
            GiaVe = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            TongThanhToan = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            lbMaVe = new Label();
            txtmaVe = new TextBox();
            cboMaKH = new ComboBox();
            cboMaCD = new ComboBox();
            grbDanhSachDatVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DSDatVe).BeginInit();
            grbDatVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soLuongVe).BeginInit();
            SuspendLayout();
            // 
            // TgKH
            // 
            TgKH.Format = DateTimePickerFormat.Short;
            TgKH.Location = new Point(666, 91);
            TgKH.Name = "TgKH";
            TgKH.Size = new Size(139, 31);
            TgKH.TabIndex = 13;
            // 
            // grbDanhSachDatVe
            // 
            grbDanhSachDatVe.Controls.Add(DSDatVe);
            grbDanhSachDatVe.Location = new Point(19, 269);
            grbDanhSachDatVe.Name = "grbDanhSachDatVe";
            grbDanhSachDatVe.Size = new Size(941, 304);
            grbDanhSachDatVe.TabIndex = 5;
            grbDanhSachDatVe.TabStop = false;
            grbDanhSachDatVe.Text = "Danh Sách Vé";
            // 
            // DSDatVe
            // 
            DSDatVe.AllowUserToAddRows = false;
            DSDatVe.AllowUserToDeleteRows = false;
            DSDatVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DSDatVe.BackgroundColor = Color.White;
            DSDatVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DSDatVe.Columns.AddRange(new DataGridViewColumn[] { MaVe, MaCD, MaKH, NgayDat, GiaVe, SoLuong, TongThanhToan, TrangThai });
            DSDatVe.Location = new Point(21, 34);
            DSDatVe.Name = "DSDatVe";
            DSDatVe.ReadOnly = true;
            DSDatVe.RowHeadersVisible = false;
            DSDatVe.RowHeadersWidth = 62;
            DSDatVe.Size = new Size(908, 270);
            DSDatVe.TabIndex = 0;
            // 
            // grbDatVe
            // 
            grbDatVe.Controls.Add(cboMaCD);
            grbDatVe.Controls.Add(cboMaKH);
            grbDatVe.Controls.Add(txtmaVe);
            grbDatVe.Controls.Add(lbMaVe);
            grbDatVe.Controls.Add(cboTrangThai);
            grbDatVe.Controls.Add(txtGiaVe);
            grbDatVe.Controls.Add(soLuongVe);
            grbDatVe.Controls.Add(lbSoLuong);
            grbDatVe.Controls.Add(lbTrangThai);
            grbDatVe.Controls.Add(lbGiaVe);
            grbDatVe.Controls.Add(TgKH);
            grbDatVe.Controls.Add(btnXoa);
            grbDatVe.Controls.Add(btnSua);
            grbDatVe.Controls.Add(btnLuu);
            grbDatVe.Controls.Add(btnHuy);
            grbDatVe.Controls.Add(btnThoat);
            grbDatVe.Controls.Add(btnThem);
            grbDatVe.Controls.Add(lbMaKhachHang);
            grbDatVe.Controls.Add(lbNgayDat);
            grbDatVe.Controls.Add(lbMaChuyen);
            grbDatVe.Location = new Point(19, 21);
            grbDatVe.Name = "grbDatVe";
            grbDatVe.Size = new Size(941, 242);
            grbDatVe.TabIndex = 4;
            grbDatVe.TabStop = false;
            grbDatVe.Text = "Quản Lý Đặt Vé";
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Location = new Point(252, 168);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 41);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Location = new Point(372, 168);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 41);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Popup;
            btnLuu.Location = new Point(492, 168);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(95, 41);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.FlatStyle = FlatStyle.Popup;
            btnHuy.Location = new Point(612, 168);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(95, 41);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Location = new Point(732, 168);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 41);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Location = new Point(137, 168);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 41);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lbMaKhachHang
            // 
            lbMaKhachHang.Location = new Point(492, 52);
            lbMaKhachHang.Name = "lbMaKhachHang";
            lbMaKhachHang.Size = new Size(149, 31);
            lbMaKhachHang.TabIndex = 6;
            lbMaKhachHang.Text = "Mã khách hàng";
            // 
            // lbNgayDat
            // 
            lbNgayDat.Location = new Point(551, 95);
            lbNgayDat.Name = "lbNgayDat";
            lbNgayDat.Size = new Size(109, 31);
            lbNgayDat.TabIndex = 5;
            lbNgayDat.Text = "Ngày đặt";
            // 
            // lbMaChuyen
            // 
            lbMaChuyen.Location = new Point(205, 50);
            lbMaChuyen.Name = "lbMaChuyen";
            lbMaChuyen.Size = new Size(128, 31);
            lbMaChuyen.TabIndex = 4;
            lbMaChuyen.Text = "Mã Chuyến Đi";
            // 
            // lbGiaVe
            // 
            lbGiaVe.AutoSize = true;
            lbGiaVe.Location = new Point(33, 95);
            lbGiaVe.Name = "lbGiaVe";
            lbGiaVe.Size = new Size(60, 25);
            lbGiaVe.TabIndex = 14;
            lbGiaVe.Text = "Giá vé";
            // 
            // lbTrangThai
            // 
            lbTrangThai.AutoSize = true;
            lbTrangThai.Location = new Point(244, 96);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(89, 25);
            lbTrangThai.TabIndex = 15;
            lbTrangThai.Text = "Trạng thái";
            // 
            // lbSoLuong
            // 
            lbSoLuong.AutoSize = true;
            lbSoLuong.Location = new Point(780, 53);
            lbSoLuong.Name = "lbSoLuong";
            lbSoLuong.Size = new Size(85, 25);
            lbSoLuong.TabIndex = 16;
            lbSoLuong.Text = "Số lượng";
            // 
            // soLuongVe
            // 
            soLuongVe.Location = new Point(875, 53);
            soLuongVe.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            soLuongVe.Name = "soLuongVe";
            soLuongVe.Size = new Size(72, 31);
            soLuongVe.TabIndex = 17;
            // 
            // txtGiaVe
            // 
            txtGiaVe.BorderStyle = BorderStyle.None;
            txtGiaVe.Location = new Point(99, 96);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(118, 24);
            txtGiaVe.TabIndex = 18;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(352, 92);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(182, 33);
            cboTrangThai.TabIndex = 19;
            // 
            // MaVe
            // 
            MaVe.HeaderText = "Mã vé";
            MaVe.MinimumWidth = 8;
            MaVe.Name = "MaVe";
            MaVe.ReadOnly = true;
            // 
            // MaCD
            // 
            MaCD.HeaderText = "Mã chuyến đi";
            MaCD.MinimumWidth = 8;
            MaCD.Name = "MaCD";
            MaCD.ReadOnly = true;
            // 
            // MaKH
            // 
            MaKH.HeaderText = "Mã khách hàng";
            MaKH.MinimumWidth = 8;
            MaKH.Name = "MaKH";
            MaKH.ReadOnly = true;
            // 
            // NgayDat
            // 
            NgayDat.HeaderText = "Ngày đặt";
            NgayDat.MinimumWidth = 8;
            NgayDat.Name = "NgayDat";
            NgayDat.ReadOnly = true;
            // 
            // GiaVe
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            GiaVe.DefaultCellStyle = dataGridViewCellStyle1;
            GiaVe.HeaderText = "Giá vé";
            GiaVe.MinimumWidth = 8;
            GiaVe.Name = "GiaVe";
            GiaVe.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // TongThanhToan
            // 
            TongThanhToan.HeaderText = "Tổng";
            TongThanhToan.MinimumWidth = 8;
            TongThanhToan.Name = "TongThanhToan";
            TongThanhToan.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 8;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // lbMaVe
            // 
            lbMaVe.Location = new Point(35, 50);
            lbMaVe.Name = "lbMaVe";
            lbMaVe.Size = new Size(82, 31);
            lbMaVe.TabIndex = 20;
            lbMaVe.Text = "Mã vé";
            // 
            // txtmaVe
            // 
            txtmaVe.BorderStyle = BorderStyle.None;
            txtmaVe.Location = new Point(99, 50);
            txtmaVe.Name = "txtmaVe";
            txtmaVe.Size = new Size(100, 24);
            txtmaVe.TabIndex = 21;
            txtmaVe.TextChanged += txtmaVe_TextChanged;
            // 
            // cboMaKH
            // 
            cboMaKH.FormattingEnabled = true;
            cboMaKH.Location = new Point(635, 50);
            cboMaKH.Name = "cboMaKH";
            cboMaKH.Size = new Size(139, 33);
            cboMaKH.TabIndex = 22;
            // 
            // cboMaCD
            // 
            cboMaCD.FormattingEnabled = true;
            cboMaCD.Location = new Point(339, 50);
            cboMaCD.Name = "cboMaCD";
            cboMaCD.Size = new Size(140, 33);
            cboMaCD.TabIndex = 23;
            // 
            // frmDatVe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 594);
            Controls.Add(grbDanhSachDatVe);
            Controls.Add(grbDatVe);
            Name = "frmDatVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ Đặt Vé";
            grbDanhSachDatVe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DSDatVe).EndInit();
            grbDatVe.ResumeLayout(false);
            grbDatVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soLuongVe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker TgKH;
        private GroupBox grbDanhSachDatVe;
        private DataGridView DSDatVe;
        private GroupBox grbDatVe;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnThem;
        private Label lbMaKhachHang;
        private Label lbNgayDat;
        private Label lbMaChuyen;
        private Label lbGiaVe;
        private ComboBox cboTrangThai;
        private TextBox txtGiaVe;
        private NumericUpDown soLuongVe;
        private Label lbSoLuong;
        private Label lbTrangThai;
        private DataGridViewTextBoxColumn MaVe;
        private DataGridViewTextBoxColumn MaCD;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn NgayDat;
        private DataGridViewTextBoxColumn GiaVe;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn TongThanhToan;
        private DataGridViewTextBoxColumn TrangThai;
        private TextBox txtmaVe;
        private Label lbMaVe;
        private ComboBox cboMaCD;
        private ComboBox cboMaKH;
    }
}