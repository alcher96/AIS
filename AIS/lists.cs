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
    public partial class lists : Form
    {
        public lists()
        {
            InitializeComponent();
        }

        private void lists_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTT_dbDataSet5.lists". При необходимости она может быть перемещена или удалена.
            this.listsTableAdapter1.Fill(this.uTT_dbDataSet5.lists);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTT_dbDataSet4.lists". При необходимости она может быть перемещена или удалена.
            this.listsTableAdapter.Fill(this.uTT_dbDataSet4.lists);

        }
    }
}
