using System.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _52
{
    public partial class adm : Form
    {
        public adm()
        {
            InitializeComponent();
            LoadPolData(); // Загружаем данные из таблицы пользователей при загрузке формы
        }

        private void LoadPolData()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;"))
                {
                    cn.Open();
                    string query = "SELECT * FROM pol"; // Запрос для таблицы пользователей
                    using (SqlCommand command = new SqlCommand(query, cn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewPol.DataSource = dataTable; // Привязываем данные к DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Изменение данных в базе данных
            if (dataGridViewPol.SelectedRows.Count > 0)
            {
                try
                {
                    // Получаем выбранную строку
                    DataGridViewRow selectedRow = dataGridViewPol.SelectedRows[0];
                    string id = selectedRow.Cells["id"].Value.ToString(); // Используем id из столбца

                    // Получаем измененные значения
                    var newValue1 = selectedRow.Cells["logi"].Value.ToString(); // Логин
                    var newValue2 = selectedRow.Cells["pass"].Value.ToString(); // Пароль
                    var newValue3 = selectedRow.Cells["ban"].Value.ToString(); // Бан

                    using (SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;"))
                    {
                        cn.Open();
                        string query = "UPDATE pol SET logi = @newValue1, pass = @newValue2, ban = @newValue3 WHERE id = @id"; // Обновление данных
                        using (SqlCommand command = new SqlCommand(query, cn))
                        {
                            command.Parameters.AddWithValue("@newValue1", newValue1);
                            command.Parameters.AddWithValue("@newValue2", newValue2);
                            command.Parameters.AddWithValue("@newValue3", newValue3);
                            command.Parameters.AddWithValue("@id", id);

                            int rowsAffected = command.ExecuteNonQuery(); // Получаем количество затронутых строк
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Данные успешно обновлены.");
                            }
                            else
                            {
                                MessageBox.Show("Данные не обновлены. Возможно, логин не найден.");
                            }
                        }
                    }

                    // Обновляем DataGridView
                    LoadPolData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при изменении данных: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для изменения.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Удаление выбранной строки из базы данных
            if (dataGridViewPol.SelectedRows.Count > 0)
            {
                try
                {
                    // Получаем выбранную строку
                    DataGridViewRow selectedRow = dataGridViewPol.SelectedRows[0];
                    string id = selectedRow.Cells["id"].Value.ToString(); // Используем id из столбца

                    using (SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;"))
                    {
                        cn.Open();
                        string query = "DELETE FROM pol WHERE id = @id"; // Удаление записи
                        using (SqlCommand command = new SqlCommand(query, cn))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Обновляем DataGridView
                    LoadPolData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении данных: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Добавление нового пользователя
            try
            {
                // Получаем данные для нового пользователя из текстовых полей
                string newLogin = txtLogin.Text; // Логин
                string newPass = txtPass.Text; // Пароль
                string newBan = txtBan.Text; // Статус бана (можно оставить пустым для админа)

                // Проверка на уникальность логина
                using (SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;"))
                {
                    cn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM pol WHERE logi = @login";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, cn))
                    {
                        checkCommand.Parameters.AddWithValue("@login", newLogin);
                        int count = (int)checkCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существует.");
                            return;
                        }
                    }

                    // Добавление нового пользователя
                    string insertQuery = "INSERT INTO pol (logi, pass, ban) VALUES (@newLogin, @newPass, @newBan)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, cn))
                    {
                        insertCommand.Parameters.AddWithValue("@newLogin", newLogin);
                        insertCommand.Parameters.AddWithValue("@newPass", newPass);
                        insertCommand.Parameters.AddWithValue("@newBan", newBan);
                        insertCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Новый пользователь успешно добавлен.");
                LoadPolData(); // Обновляем DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении пользователя: " + ex.Message);
            }
        }
    }
}
