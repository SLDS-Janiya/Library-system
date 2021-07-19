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

namespace library_Managmet_System
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True");
        public static String Rname, Utype;
        String un, pw;

        private void cmbustype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                un = txtusername.Text;
                pw = txtpassword.Text;
                Utype = cmbustype.Text;
                String selDtl = "SELECT * FROM UserDtl WHERE Username ='" + un +"' AND Password = '" + pw +
                "' AND UserType = '" + Utype + "'";
                conn.Open();
                SqlDa = new SqlDataAdapter(selDtl, conn);
                DataTable DtLog = new DataTable();
                SqlDa.Fill(DtLog);
                conn.Close();
                if (DtLog.Rows.Count > 0)
                {
                   String getName = "SELECT UserRealName FROM UserDtl WHERE Username = '" + un + "'";
                    conn.Open();
                    cmd = new SqlCommand(getName, conn);
                    SqlDataReader myR = cmd.ExecuteReader();
                    while (myR.Read())
                    {
                        Rname = myR.GetValue(0).ToString();
                    }
                    Mainmenu frmM = new Mainmenu();
                    frmM.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unauthoried Access Denied!", "STOP!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    cmbustype.Text = "--SELECT--";
                    txtusername.Focus();
                }
            }
            catch (Exception mygh)
            {
                MessageBox.Show("Error while Login..." + Environment.NewLine + mygh);
            }

        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult resOut = MessageBox.Show("Are you sure, You want toCANCEL ??? ","Confirm to CANCEL!", 
            MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resOut == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
