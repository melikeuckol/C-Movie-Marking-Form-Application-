using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Visual_Programming_Project
{

    public partial class MainForm : Form

    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=login;uid=root;password=1621;");
        public void tolistmovies()
        {

            if (connection.State != ConnectionState.Open)
            {
                try
                {

                    connection.Open();

                    string query = @"
                 SELECT 
                 m.movie_id AS 'MOVIE ID',
                 m.movie_name AS 'MOVIE NAME',
                 m.movie_type AS 'MOVIE TYPE',
                 m.movie_year AS 'MOVIE YEAR',
                 m.movie_mark AS 'MOVIE MARK',
                 a.username AS 'USER NAME'

                 FROM movies m
                 LEFT JOIN admin a ON m.user_name =a.username;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);

              
                        dataGridView1.DataSource = null; // Eski veriyi temizle
                        dataGridView1.DataSource = table; // Yeni tabloyu bağla
                        dataGridView1.Refresh(); // DataGridView'i manuel olarak yenile
                       
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.AllowUserToAddRows = false;
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        public MainForm()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.SelectedItem == null || numericUpDown1.Value <= 1800 || numericUpDown2.Value <= 1)
            {
                MessageBox.Show("Please fill all the blank fields.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {

                    try
                    {
                        connection.Open();
                        String checkMovie = "SELECT * FROM movies WHERE movie_name= @movie_name";
                        using (MySqlCommand check = new MySqlCommand(checkMovie, connection))
                        {
                            check.Parameters.AddWithValue("@movie_name", textBox1.Text);
                            MySqlDataAdapter adapter = new MySqlDataAdapter(check);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("This film is already exist!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                String insertdata = "INSERT INTO movies (movie_name,movie_type,movie_year,movie_mark,user_name)" +
                                    "VALUES (@movie_name,@movie_type,@movie_year,@movie_mark,@user_name)";
                                using (MySqlCommand insert = new MySqlCommand(insertdata, connection))
                                {
                                    string username = GlobalData.Username;

                                    insert.Parameters.AddWithValue("@movie_name", textBox1.Text);
                                    insert.Parameters.AddWithValue("@movie_type", comboBox1.SelectedItem.ToString());
                                    insert.Parameters.AddWithValue("@movie_year", numericUpDown1.Value);
                                    insert.Parameters.AddWithValue("@movie_mark", numericUpDown2.Value);
                                    insert.Parameters.AddWithValue("@user_name", username);
                                   
                                    int result = insert.ExecuteNonQuery();//eklenen satır sayısını gösterir
                                    if (result > 0)
                                    {
                                        MessageBox.Show("Movie added successfully.", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        tolistmovies();  // Film ekledikten sonra DataGridView'i güncelle
                                        MessageBox.Show("Movies list updated!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to add movie.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting database" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connection.Close(); }
                }
            }

        }
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Loading movie list...");
                tolistmovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}


