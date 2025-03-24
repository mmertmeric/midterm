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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTextEditor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 text = new Form2();
            text.Show();
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 todoSchool = new Form3();
            todoSchool.Show();
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 background = new Form4();
            background.Show();
        }
    }
}
