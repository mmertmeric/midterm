using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void UpdateColor()
        {
            int r = trackBar1.Value;
            int g = hScrollBar1.Value;
            int b = vScrollBar1.Value;

            lblColor.BackColor = Color.FromArgb(r, g, b);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }
    }
}
