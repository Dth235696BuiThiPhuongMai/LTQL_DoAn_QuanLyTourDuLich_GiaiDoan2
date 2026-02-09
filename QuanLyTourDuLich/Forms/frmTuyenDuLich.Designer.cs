namespace QuanLyTourDuLich.Forms
{
    partial class frmTuyenDuLich
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
            grbTuyenDuLich = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            lbDDi = new Label();
            lbDDen = new Label();
            lbMaTuyen = new Label();
            txtDDi = new TextBox();
            txtDDen = new TextBox();
            textBox1 = new TextBox();
            grbDanhSachTuyen = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            dataDDi = new DataGridViewTextBoxColumn();
            dataDDen = new DataGridViewTextBoxColumn();
            grbTuyenDuLich.SuspendLayout();
            grbDanhSachTuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grbTuyenDuLich
            // 
            grbTuyenDuLich.Controls.Add(btnXoa);
            grbTuyenDuLich.Controls.Add(btnSua);
            grbTuyenDuLich.Controls.Add(btnLuu);
            grbTuyenDuLich.Controls.Add(btnHuy);
            grbTuyenDuLich.Controls.Add(btnThoat);
            grbTuyenDuLich.Controls.Add(btnThem);
            grbTuyenDuLich.Controls.Add(lbDDi);
            grbTuyenDuLich.Controls.Add(lbDDen);
            grbTuyenDuLich.Controls.Add(lbMaTuyen);
            grbTuyenDuLich.Controls.Add(txtDDi);
            grbTuyenDuLich.Controls.Add(txtDDen);
            grbTuyenDuLich.Controls.Add(textBox1);
            grbTuyenDuLich.Location = new Point(24, 24);
            grbTuyenDuLich.Name = "grbTuyenDuLich";
            grbTuyenDuLich.Size = new Size(941, 155);
            grbTuyenDuLich.TabIndex = 0;
            grbTuyenDuLich.TabStop = false;
            grbTuyenDuLich.Text = "Quản Lý Tuyến Du Lịch";
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
            // lbDDi
            // 
            lbDDi.Location = new Point(281, 43);
            lbDDi.Name = "lbDDi";
            lbDDi.Size = new Size(115, 31);
            lbDDi.TabIndex = 6;
            lbDDi.Text = "Địa điểm đi";
            // 
            // lbDDen
            // 
            lbDDen.Location = new Point(597, 43);
            lbDDen.Name = "lbDDen";
            lbDDen.Size = new Size(127, 31);
            lbDDen.TabIndex = 5;
            lbDDen.Text = "Địa điểm đến";
            // 
            // lbMaTuyen
            // 
            lbMaTuyen.Location = new Point(36, 43);
            lbMaTuyen.Name = "lbMaTuyen";
            lbMaTuyen.Size = new Size(95, 31);
            lbMaTuyen.TabIndex = 4;
            lbMaTuyen.Text = "Mã tuyến";
            // 
            // txtDDi
            // 
            txtDDi.BorderStyle = BorderStyle.None;
            txtDDi.Location = new Point(389, 43);
            txtDDi.Name = "txtDDi";
            txtDDi.Size = new Size(202, 24);
            txtDDi.TabIndex = 3;
            // 
            // txtDDen
            // 
            txtDDen.BorderStyle = BorderStyle.None;
            txtDDen.Location = new Point(725, 43);
            txtDDen.Name = "txtDDen";
            txtDDen.Size = new Size(202, 24);
            txtDDen.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(137, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 24);
            textBox1.TabIndex = 0;
            // 
            // grbDanhSachTuyen
            // 
            grbDanhSachTuyen.Controls.Add(dataGridView1);
            grbDanhSachTuyen.Location = new Point(26, 185);
            grbDanhSachTuyen.Name = "grbDanhSachTuyen";
            grbDanhSachTuyen.Size = new Size(939, 391);
            grbDanhSachTuyen.TabIndex = 1;
            grbDanhSachTuyen.TabStop = false;
            grbDanhSachTuyen.Text = "Danh Sách Tuyến Du Lịch";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, dataDDi, dataDDen });
            dataGridView1.Location = new Point(21, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(908, 346);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // dataDDi
            // 
            dataDDi.HeaderText = "Địa điểm khởi hành";
            dataDDi.MinimumWidth = 8;
            dataDDi.Name = "dataDDi";
            dataDDi.ReadOnly = true;
            // 
            // dataDDen
            // 
            dataDDen.HeaderText = "Địa điểm kết thúc";
            dataDDen.MinimumWidth = 8;
            dataDDen.Name = "dataDDen";
            dataDDen.ReadOnly = true;
            // 
            // frmTuyenDuLich
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(978, 594);
            Controls.Add(grbDanhSachTuyen);
            Controls.Add(grbTuyenDuLich);
            Name = "frmTuyenDuLich";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tuyến Du Lịch";
            Load += frmTuyenDuLich_Load;
            grbTuyenDuLich.ResumeLayout(false);
            grbTuyenDuLich.PerformLayout();
            grbDanhSachTuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbTuyenDuLich;
        private GroupBox grbDanhSachTuyen;
        private Label lbDDi;
        private Label lbDDen;
        private Label lbMaTuyen;
        private TextBox txtDDi;
        private TextBox txtDDen;
        private TextBox textBox1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private Button btnThem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataDDi;
        private DataGridViewTextBoxColumn dataDDen;
    }
}