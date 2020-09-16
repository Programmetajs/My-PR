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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        dbcontrol sql = new dbcontrol();

        void register()
        {
            sql.Param("@Username", txtREGusername.Text);
            sql.Param("@Password", txtREGpassword.Text);
            sql.Param("@First name", txtREGfirst_name.Text);
            sql.Param("@Middle name", txtREGmiddle_name.Text);
            sql.Param("@Last name", txtREGlast_name.Text);
            sql.query("insert into tbluser (Username,Password,First name,Middle name,Last name) values(@Username,@Password,@First name,@Middle name,@Last name)");
            if (sql.Check4error(true))
            {
                return;
            }
            MessageBox.Show("Registred!", "Sourcess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Registr_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
                if (frm is Form1) 
                {
                    frm.Show();
                
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            register();
        }
    }
}
