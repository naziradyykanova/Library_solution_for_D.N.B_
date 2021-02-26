using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lib.Forms
{
    public partial class BookEdit : Form
    {
        int IdBook = 0;
        public BookEdit()
        {
            InitializeComponent();
        }

        private void информация_о_книгеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.информация_о_книгеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.библиотекаDataSet);

        }

        private void BookEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'библиотекаDataSet.Информация_о_книге' table. You can move, or remove it, as needed.
            this.информация_о_книгеTableAdapter.Fill(this.библиотекаDataSet.Информация_о_книге);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int _Шифр_книги = Convert.ToInt32(BookID.Text);
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=.\MS_SQL_SERVER; Database=Библиотека; Initial Catalog=Библиотека;Integrated Security=SSPI;"))
            {
                int txtBookCategorys = Convert.ToInt16(txtBookCategory.Text);
                sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("BookAddOrEdit", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Шифр_книги", Convert.ToInt32(BookID.Text));
                sqlCmd.Parameters.AddWithValue("@Название", txtBookName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Код_издательства",  Convert.ToInt32(txtBookPublisher.Text));
                sqlCmd.Parameters.AddWithValue("@Год_издания ", DTPpublishing.Value);
                sqlCmd.Parameters.AddWithValue("@Объем_книги ", Convert.ToInt32(txtBookVolume.Text));
                sqlCmd.Parameters.AddWithValue("@Цена",  Convert.ToInt32(txtBookPrice.Text));
                sqlCmd.Parameters.AddWithValue("@Количество", Convert.ToInt32(txtBookQuentity.Text));
                sqlCmd.Parameters.AddWithValue("@Код_раздела", txtBookCategorys);
                _Шифр_книги = Convert.ToInt32(sqlCmd.ExecuteScalar());
               // int a = Convert.ToInt16(txtBookCategory);
                sqlCmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("done");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
