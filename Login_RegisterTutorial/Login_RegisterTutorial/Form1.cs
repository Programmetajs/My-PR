using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_RegisterTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dbcontrol sql = new dbcontrol();
        #region IGNORE
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        bool Login()
        {
            sql.Param("@Username", txtUsername.Text);
            sql.Param("@Password", txtPassword.Text);
            sql.query("select count(*) from tbluser where Username=@Username and Password=@Password");
            if ((int)sql.dt.Rows[0][0] ==1)
            {

                return true;

            }
            MessageBox.Show("Incorrect Username or Password","Incorrect",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            return false;
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {

            if (Login() == true)
            {

                Main mf = new Main();
                Hide();
                mf.ShowDialog();

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {


            Registr rf = new Registr();
            Hide();
            rf.ShowDialog();
        }
    }
}
