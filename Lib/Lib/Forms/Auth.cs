using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Lib
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("s");
                btnAuth.PerformClick();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
                   SqlConnection sqlconn = new SqlConnection(@"Data Source=.\MS_SQL_SERVER; Database=Библиотека; Initial Catalog=Библиотека;Integrated Security=SSPI;");
            string query = "Select * from [User] WHERE name ='" + txtLogin.Text.Trim() + "'and password = '" + txtPswd.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
            DataTable dtb = new DataTable();
            try
            {
                sda.Fill(dtb);
                if (dtb.Rows.Count == 1)
                {
                    this.Hide();
                    Forms.Menu menu = new Forms.Menu();
                    menu.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Неверный логин или пароль";
                }
            }
            catch
            {
                MessageBox.Show("error connet");
            }

        }

        private void Auth_Load(object sender, EventArgs e)
        {
            string curtime = DateTime.Now.ToString("HH");
            int time = Int16.Parse(curtime);
            if (time <= 00)
            {
                lblTime.Text = "Доброй ночи";

            }
            else if (time <= 06)
            {
                lblTime.Text = "Доброе утро";
            }
            else { 
                lblTime.Text = "Добрый день";
            }
        }
    }
}

