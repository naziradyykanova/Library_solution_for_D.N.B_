using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lib.Forms
{
    public partial class MemberSearch : Form
    {
        public MemberSearch()
        {
            InitializeComponent();
        }

        private void информация_о_читателеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.информация_о_читателеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void MemberSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'библиотекаDataSet.Информация_о_читателе' table. You can move, or remove it, as needed.
            this.информация_о_читателеTableAdapter.Fill(this.библиотекаDataSet.Информация_о_читателе);

        }
    }
}
