using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Visual_Programming_Project
{
    public partial class Signup : Form
    {
        MySqlConnection connect = new MySqlConnection("server=localhost;database=login;uid=root;password=1621;");


        public Signup()
        {
            InitializeComponent();
        }

        private void signup_loginhere_Click(object sender, EventArgs e)
        {
            Form1 lForm=new Form1();
            lForm.Show();
            this.Hide();

        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(signup_email.Text=="" || signup_username.Text=="" || signup_psw.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields.","Error message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State!=ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username= '" + signup_username.Text.Trim() + "'";

                        using (MySqlCommand checkUser =new MySqlCommand(checkUsername, connect))
                        {
                            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            dataAdapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " is already exist ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email,username,password,date_created)" +
                                    "VALUES(@email,@username,@password,@date_created)";
                                DateTime date = DateTime.Today;

                                using (MySqlCommand cmd = new MySqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_psw.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date_created", date);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 lform = new Form1();
                                    lform.Show();
                                    this.Hide();

                                }
                            }

                        }
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void signup_showPsw_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPsw.Checked)
            {
                signup_psw.PasswordChar = '\0';
            }
            else
            {
                signup_psw.PasswordChar = '*';
            }
        }
    }
}
