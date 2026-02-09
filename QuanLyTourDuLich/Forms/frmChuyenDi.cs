using QuanLyTourDuLich.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTourDuLich.Forms
{
    public partial class frmChuyenDi : Form
    {
        QuanLyTourDbContext context = new QuanLyTourDbContext();
        bool xuLyThem = false;
        int id;
        public frmChuyenDi()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtMaChuyenDi.Enabled = giaTri;
            txtMaTuyen.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri; 
            btnXoa.Enabled = !giaTri;
        }
        private void LoadChuyenDi()
        {
            var list = context.ChuyenDi.ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = list;

            txtMaChuyenDi.DataBindings.Clear();
            txtMaTuyen.DataBindings.Clear();
            TgKH.DataBindings.Clear();

            txtMaChuyenDi.DataBindings.Add("Text", bs, "ID");
            txtMaTuyen.DataBindings.Add("Text", bs, "TuyenDuLichID");
            TgKH.DataBindings.Add("Value", bs, "GioKhoiHanh");

            DSChuyenDi.DataSource = bs;
        }
        private void frmChuyenDi_Load(object sender, EventArgs e)
        {

            BatTatChucNang(false);
            LoadChuyenDi();
        }
        private void DSChuyenDi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(
                    DSChuyenDi.Rows[e.RowIndex].Cells["IdChuyenDi"].Value
                );
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            id = 0;

            BatTatChucNang(true);
            txtMaChuyenDi.Clear();
            txtMaTuyen.Clear();
            TgKH.Value = DateTime.Now;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            
            txtMaChuyenDi.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var cd = context.ChuyenDi.Find(id);
                if (cd != null)
                {
                    context.ChuyenDi.Remove(cd);
                    context.SaveChanges();
                    LoadChuyenDi();
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaChuyenDi.Text) ||
                string.IsNullOrWhiteSpace(txtMaTuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (xuLyThem)
            {
                QuanLyChuyenDi cd = new QuanLyChuyenDi();
                cd.ID = int.Parse(txtMaChuyenDi.Text);
                cd.TuyenDuLichID = int.Parse(txtMaTuyen.Text);
                cd.GioKhoiHanh = TgKH.Value;

                context.ChuyenDi.Add(cd);
            }
            else
            {
                var cd = context.ChuyenDi.Find(id);
                if (cd != null)
                {
                    cd.TuyenDuLichID = int.Parse(txtMaTuyen.Text);
                    cd.GioKhoiHanh = TgKH.Value;
                }
            }

            context.SaveChanges();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmChuyenDi_Load(sender, e);
            BatTatChucNang(false);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
