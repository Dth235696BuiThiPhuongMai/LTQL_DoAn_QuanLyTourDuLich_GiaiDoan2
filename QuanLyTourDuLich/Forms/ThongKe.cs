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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {

            InitializeComponent();
           
        }
        private void panelChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int[] values = { 3, 5, 7, 4 };
            string[] labels = { "T1", "T2", "T3", "T4" };

            int barWidth = 40;
            int spacing = 30;
            int startX = 50;
            int baseY = panelChart.Height - 50;

            Brush barBrush = Brushes.SteelBlue;
            Font font = new Font("Arial", 10);

            for (int i = 0; i < values.Length; i++)
            {
                int barHeight = values[i] * 20;

                g.FillRectangle(
                    barBrush,
                    startX + i * (barWidth + spacing),
                    baseY - barHeight,
                    barWidth,
                    barHeight
                );

                g.DrawString(
                    labels[i],
                    font,
                    Brushes.Black,
                    startX + i * (barWidth + spacing),
                    baseY + 5
                );
            }
        }


    }

}
