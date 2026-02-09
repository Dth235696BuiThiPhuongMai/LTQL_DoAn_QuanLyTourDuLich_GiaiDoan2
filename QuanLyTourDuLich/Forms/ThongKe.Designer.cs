namespace QuanLyTourDuLich.Forms
{
    partial class frmThongKe
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
            grbDT = new GroupBox();
            DsDoanhThu = new DataGridView();
            IDChuyen = new DataGridViewTextBoxColumn();
            IDTuyen = new DataGridViewTextBoxColumn();
            TGKhoiHanh = new DataGridViewTextBoxColumn();
            grbDoanhThu = new GroupBox();
            btnXemDoanhThu = new Button();
            label2 = new Label();
            label1 = new Label();
            cboNam = new ComboBox();
            cboThang = new ComboBox();
            lbTongKH = new Label();
            lbSoTour = new Label();
            txtMaTuyen = new TextBox();
            txtTongTour = new TextBox();
            panelChart = new Panel();
            grbDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DsDoanhThu).BeginInit();
            grbDoanhThu.SuspendLayout();
            SuspendLayout();
            // 
            // grbDT
            // 
            grbDT.Controls.Add(DsDoanhThu);
            grbDT.Location = new Point(21, 182);
            grbDT.Name = "grbDT";
            grbDT.Size = new Size(620, 391);
            grbDT.TabIndex = 5;
            grbDT.TabStop = false;
            grbDT.Text = "Thống kê doanh thu";
            // 
            // DsDoanhThu
            // 
            DsDoanhThu.AllowUserToAddRows = false;
            DsDoanhThu.AllowUserToDeleteRows = false;
            DsDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DsDoanhThu.BackgroundColor = Color.White;
            DsDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DsDoanhThu.Columns.AddRange(new DataGridViewColumn[] { IDChuyen, IDTuyen, TGKhoiHanh });
            DsDoanhThu.Location = new Point(6, 39);
            DsDoanhThu.Name = "DsDoanhThu";
            DsDoanhThu.ReadOnly = true;
            DsDoanhThu.RowHeadersVisible = false;
            DsDoanhThu.RowHeadersWidth = 62;
            DsDoanhThu.Size = new Size(608, 346);
            DsDoanhThu.TabIndex = 0;
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
            // grbDoanhThu
            // 
            grbDoanhThu.Controls.Add(btnXemDoanhThu);
            grbDoanhThu.Controls.Add(label2);
            grbDoanhThu.Controls.Add(label1);
            grbDoanhThu.Controls.Add(cboNam);
            grbDoanhThu.Controls.Add(cboThang);
            grbDoanhThu.Controls.Add(lbTongKH);
            grbDoanhThu.Controls.Add(lbSoTour);
            grbDoanhThu.Controls.Add(txtMaTuyen);
            grbDoanhThu.Controls.Add(txtTongTour);
            grbDoanhThu.Location = new Point(19, 21);
            grbDoanhThu.Name = "grbDoanhThu";
            grbDoanhThu.Size = new Size(622, 155);
            grbDoanhThu.TabIndex = 4;
            grbDoanhThu.TabStop = false;
            grbDoanhThu.Text = "Quản lý doanh thu";
            // 
            // btnXemDoanhThu
            // 
            btnXemDoanhThu.FlatStyle = FlatStyle.Flat;
            btnXemDoanhThu.Location = new Point(418, 88);
            btnXemDoanhThu.Name = "btnXemDoanhThu";
            btnXemDoanhThu.Size = new Size(120, 44);
            btnXemDoanhThu.TabIndex = 11;
            btnXemDoanhThu.Text = "Xem ";
            btnXemDoanhThu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(6, 92);
            label2.Name = "label2";
            label2.Size = new Size(69, 31);
            label2.TabIndex = 10;
            label2.Text = "Tháng";
            // 
            // label1
            // 
            label1.Location = new Point(209, 97);
            label1.Name = "label1";
            label1.Size = new Size(59, 31);
            label1.TabIndex = 9;
            label1.Text = "Năm";
            // 
            // cboNam
            // 
            cboNam.FormattingEnabled = true;
            cboNam.Location = new Point(274, 99);
            cboNam.Name = "cboNam";
            cboNam.Size = new Size(118, 33);
            cboNam.TabIndex = 8;
            // 
            // cboThang
            // 
            cboThang.FormattingEnabled = true;
            cboThang.Location = new Point(75, 95);
            cboThang.Name = "cboThang";
            cboThang.Size = new Size(118, 33);
            cboThang.TabIndex = 7;
            // 
            // lbTongKH
            // 
            lbTongKH.Location = new Point(281, 50);
            lbTongKH.Name = "lbTongKH";
            lbTongKH.Size = new Size(154, 31);
            lbTongKH.TabIndex = 6;
            lbTongKH.Text = "Tổng khách hàng";
            // 
            // lbSoTour
            // 
            lbSoTour.Location = new Point(6, 50);
            lbSoTour.Name = "lbSoTour";
            lbSoTour.Size = new Size(128, 31);
            lbSoTour.TabIndex = 4;
            lbSoTour.Text = "Tổng số tour";
            // 
            // txtMaTuyen
            // 
            txtMaTuyen.BorderStyle = BorderStyle.None;
            txtMaTuyen.Location = new Point(441, 50);
            txtMaTuyen.Name = "txtMaTuyen";
            txtMaTuyen.Size = new Size(120, 24);
            txtMaTuyen.TabIndex = 3;
            // 
            // txtTongTour
            // 
            txtTongTour.BorderStyle = BorderStyle.None;
            txtTongTour.Location = new Point(140, 50);
            txtTongTour.Name = "txtTongTour";
            txtTongTour.Size = new Size(118, 24);
            txtTongTour.TabIndex = 0;
            // 
            // panelChart
            // 
            panelChart.Location = new Point(659, 38);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(307, 532);
            panelChart.TabIndex = 6;
            panelChart.Paint += panelChart_Paint;
            // 
            // frmThongKe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 594);
            Controls.Add(panelChart);
            Controls.Add(grbDT);
            Controls.Add(grbDoanhThu);
            Name = "frmThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            grbDT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DsDoanhThu).EndInit();
            grbDoanhThu.ResumeLayout(false);
            grbDoanhThu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grbDT;
        private DataGridView DsDoanhThu;
        private DataGridViewTextBoxColumn IDChuyen;
        private DataGridViewTextBoxColumn IDTuyen;
        private DataGridViewTextBoxColumn TGKhoiHanh;
        private GroupBox grbDoanhThu;
        private Label lbTongKH;
        private Label lbSoTour;
        private TextBox txtMaTuyen;
        private TextBox txtTongTour;
        private Button btnXemDoanhThu;
        private Label label2;
        private Label label1;
        private ComboBox cboNam;
        private ComboBox cboThang;
        private Panel panelChart;
    }
}