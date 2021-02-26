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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'библиотекаDataSet.Информация_о_книге' table. You can move, or remove it, as needed.
            this.информация_о_книгеTableAdapter.Fill(this.библиотекаDataSet.Информация_о_книге);

        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AddReader addreader = new AddReader();
            addreader.ShowDialog();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BookAdd addBook = new BookAdd();
            addBook.ShowDialog();
        }

        private void карточкаЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.MemberSearch MemberSearch = new MemberSearch();
            MemberSearch.ShowDialog();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
                    Forms.BookEdit addBook = new BookEdit();
                    addBook.ShowDialog();
            //}
            //catch { }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    try
                    {
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    catch {
                        MessageBox.Show("Нельзя удалить данное поле");
                    }
            }
            this.Validate();
            this.информация_о_книгеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }
    }
}
