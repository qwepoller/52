using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; // ��������� ��� ������ � Windows Forms
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _52
{
    public partial class areg : Form
    {
        public areg()
        {
            InitializeComponent();
        }

        private static int ban = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string logi = log.Text.Trim(); // �������� ����� �� ���������� ����
            string pass = pas.Text.Trim();

            if (!string.IsNullOrWhiteSpace(logi) && !string.IsNullOrWhiteSpace(pass))
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;"))
                {
                    try
                    {
                        cn.Open();

                        // �������� �� ������������� ������������ � ����������
                        SqlCommand cmdUsers = new SqlCommand("SELECT ban FROM pol WHERE logi = @logi AND pass = @pass;", cn);
                        cmdUsers.Parameters.AddWithValue("@logi", logi);
                        cmdUsers.Parameters.AddWithValue("@pass", pass);
                        SqlCommand cmdAdmin = new SqlCommand("SELECT COUNT(*) FROM adm WHERE logi = @logi AND pass = @pass;", cn);
                        cmdAdmin.Parameters.AddWithValue("@logi", logi);
                        cmdAdmin.Parameters.AddWithValue("@pass", pass);
                        int adminCount = (int)cmdAdmin.ExecuteScalar();

                        

                        using (SqlDataReader reader = cmdUsers.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string banStatusString = reader.IsDBNull(0) ? "0" : reader.GetString(0);
                                int banStatus = int.Parse(banStatusString);

                                if (banStatus == 1)
                                {
                                    MessageBox.Show("�� �������������!!!", "����������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                else
                                {
                                    // �������� ����� �� ������ �����
                                    rereg re = new rereg(logi);
                                    re.Show();
                                    this.Hide();
                                }
                            }
                            else if (adminCount > 0)
                                {
                                    // ���� ������������ ������ � ������� admins
                                    adm admForm = new adm();
                                    admForm.Show();
                                    this.Hide();
                                }
                            else
                            {
                                MessageBox.Show("�������� ����� ��� ������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("����������, ��������� ��� ����: ����� � ������.", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}