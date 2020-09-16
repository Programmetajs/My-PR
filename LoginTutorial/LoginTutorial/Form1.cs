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

namespace LoginTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Buttons
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       #region SQL DATABASE CONNECTION 
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection conection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DO NOT DELATE\DB\LogINDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqladapter = new SqlDataAdapter("Select count(*) From DBTable where Username ='" + txtUsername.Text +"' and Password = '"+ txtPassword.Text +"'",conection);
            DataTable dt = new DataTable();
            sqladapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Welcome");
                this.Hide();
                Menu main = new Menu();
                main.Show();
            }

            else
            {
                MessageBox.Show("Username or Password is incorrect. Please try again!");

            }
            #endregion
            
            
        }
        #endregion
    }

}
