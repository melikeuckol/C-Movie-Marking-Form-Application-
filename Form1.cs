using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Visual_Programming_Project
{

    public partial class Form1 : Form
        
    {
        MySqlConnection conn=new MySqlConnection("server=localhost;database=login;uid=root;password=1621;");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void login_registerHere_Click(object sender, EventArgs e)
        {
            Signup sForm=new Signup();
            sForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPsw_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPsw.Checked)
            {
                login_psw.PasswordChar = '\0';
            }
            else
            {
                login_psw.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text=="" || login_psw.Text=="")
            {
                MessageBox.Show("Please fill all the blank fields.","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error); 

            }
            else
            {
                if(conn.State!=ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        String selectData = "SELECT *FROM admin WHERE username=@username AND password=@password";
                        using (MySqlCommand cmd = new MySqlCommand(selectData, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            GlobalData.Username = login_username.Text;
                            cmd.Parameters.AddWithValue("@password", login_psw.Text);
                            MySqlDataAdapter dataAdapter= new MySqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            if (dataTable.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged in successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm mainForm=new MainForm();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show("Error connecting: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
        }
    }
}
