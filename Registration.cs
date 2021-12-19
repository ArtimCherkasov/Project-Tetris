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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`id`, `login`, `pass`, `name`, `povtpass`) VALUES (NULL, @login, @pass, @name, @PovtPass)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = TextBoxLog.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPass.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TextBoxName.Text;
            command.Parameters.Add("@PovtPass", MySqlDbType.VarChar).Value = TextBoxPassReplay.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                Authorization frmMain = new Authorization();
                frmMain.Show();
                this.Hide();
                MessageBox.Show("Аккаунт был зарегистрирован");

            }
            else
                MessageBox.Show("Что-то пошло не так");
            db.closeConnection();
        }

        private void LabelAut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authorization frmAut = new Authorization();
            frmAut.Show();
            this.Hide();
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "")
                MessageBox.Show("Введите имя пользователя");
        }

        private void TextBoxLog_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxLog.Text == "")
                MessageBox.Show("Введите логин");
        }

        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxPass.Text == "")
                MessageBox.Show("Введите пароль");
        }

        private void TextBoxPassReplay_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxPassReplay.Text == "")
                MessageBox.Show("Введите пароль повторно");
        }

        private void CheckBoxCoditions_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxCoditions.Text == "")
                MessageBox.Show("Примите условия обработки данных");
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
