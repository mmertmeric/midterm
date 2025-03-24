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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();

            if (!string.IsNullOrEmpty(task))
            {
                listTasks.Items.Add(task);
                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedIndex != -1)
            {
                listTasks.Items.RemoveAt(listTasks.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a task to remove");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string from = comboBox1.SelectedItem.ToString();
            MessageBox.Show($"Your selected grade : {from}");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
