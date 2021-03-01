using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void учетТранспортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uchet uchet = new uchet();
            uchet.Show();
        }

        private void оформитьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zayavka zayavka = new zayavka();
            zayavka.Show();
        }

        private void текущиеЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void реестрПутевыхЛистовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lists lists = new lists();
            lists.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["Статус"], ListSortDirection.Ascending);
        }
    }
}
