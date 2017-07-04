using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mysqlconnectionforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //create a connection string
            string connectionstring = "datasource=localhost;database=csc311;username=root;password=''";
            //create a connection object and pass the connection string
            MySqlConnection con = new MySqlConnection(connectionstring);
            //create the insertion query
            string q = "INSERT INTO user(username,password) VALUES('" + txtUserName.Text + "','" + txtPassword.Text + "')";

            //create command to handle the connection object and the connection string
            MySqlCommand cmd = new MySqlCommand(q, con);
            //declare the data reader
            MySqlDataReader reader;
            //create the connection through a try and catch block
            

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                MessageBox.Show("Data Saved");
                txtUserName.Text = "";
                txtPassword.Text = "";

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //close the connection
            con.Close();
        }
    }
}
