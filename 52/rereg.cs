using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _52
{
    public partial class rereg : Form
    {
        private string _login;

        // Конструктор, принимающий логин
        public rereg(string login)
        {
            InitializeComponent();
            _login = login; // Сохраняем логин для использования
            labelWelcome.Text = $"Добро пожаловать, {_login}!"; // Предположим, у вас есть метка для отображения логина
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainPass = mainpass.Text; // Получаем пароль из текстового поля mainpass
            string newPass = newpass.Text; // Получаем новый пароль из текстового поля newpass
            string newNewPass = newnewpass.Text; // Получаем подтверждение нового пароля из текстового поля newnewpass

            // Проверяем совпадение нового пароля и подтверждения
            if (newPass != newNewPass)
            {
                MessageBox.Show("Новый пароль и подтверждение нового пароля не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Здесь вам нужно указать строку подключения к вашей базе данных
            using (SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;"))

           
            {
                cn.Open();
                // Проверяем, правильный ли пароль
                string query = "SELECT COUNT(*) FROM pol WHERE Logi = @login AND Pass = @password";
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@login", _login);
                    command.Parameters.AddWithValue("@password", mainPass);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        // Пароль верный, меняем его на новый
                        string updateQuery = "UPDATE pol SET Pass = @newPassword WHERE Logi= @login";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, cn))
                        {
                            updateCommand.Parameters.AddWithValue("@newPassword", newPass);
                            updateCommand.Parameters.AddWithValue("@login", _login);
                            updateCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Пароль успешно изменен!");
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль.");
                    }
                }
            }
        }
    }
}
