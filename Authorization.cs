using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тетрис
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void ButtonAut_Click(object sender, EventArgs e)
        {
            String loginUser = TextBoxLog.Text;
            String passUser = TextBoxPass.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Form1 frmMain = new Form1();
                frmMain.Show();
                this.Hide();
                MessageBox.Show("Вы успешно авторизовались");
            }
            else
                MessageBox.Show("Упс, что-то пошло не так!!!");       
        }

        private void LabelReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration frmReg = new Registration();
            frmReg.Show();
            this.Hide();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxLog_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxLog.Text == "")
                MessageBox.Show("Пожалуйста введите логин");
        }

        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxPass.Text == "")
                MessageBox.Show("Пожалуйста введите пароль");
        }
    }
}
