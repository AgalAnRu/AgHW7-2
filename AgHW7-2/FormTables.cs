using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgHW7_2
{
    public partial class FormTables : Form
    {
        public FormTables()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics gr = e.Graphics)
            {
                Pen p = new Pen(Color.Gray, 1);// цвет линии и ширина
                Point p1 = new Point(0, 200);// первая точка
                Point p2 = new Point(200, 200);// вторая точка
                gr.DrawLine(p, p1, p2);// рисуем линию
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
