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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True");
        int SSerial = 0;

        //-------------------------------Button Exit--------------------------------------------//
        private void btnex_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure, You want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Dispose();

                Mainmenu frmM = new Mainmenu();
                frmM.Show();
                this.Hide();
            }
        }
        //-------------------------------erase--------------------------------------------//
        private void eraseMe()
        {
            txtmname.Text = "";
            txtnic.Text = "";
            txtphon.Text = "";
            txtaddress.Text = "";
            dtpdo.Text = "";
            txtmid.Focus();
        }
        //-------------------------------Button clear--------------------------------------------//
        private void btncl_Click(object sender, EventArgs e)
        {
            eraseMe();
        }
        //-------------------------------id Generator--------------------------------------------//
        private void idGenerator()
        {
            try
            {
                String checkID = "SELECT StSerial FROM Member_Dtl";
                conn.Open();
                SqlDa = new SqlDataAdapter(checkID, conn);
                DataTable Dt = new DataTable();
                SqlDa.Fill(Dt);
                conn.Close();
                if (Dt.Rows.Count > 0)
                {
                    String getMaxID = "SELECT MAX(StSerial) FROM Member_Dtl";
                    conn.Open();
                    cmd = new SqlCommand(getMaxID, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    while (R.Read())
                    {
                        SSerial = int.Parse(R.GetValue(0).ToString());
                    }
                    conn.Close();
                    SSerial = SSerial + 1;
                }
                else
                {
                    SSerial = 1;
                }
                txtmid.Text = "MPF-" + SSerial.ToString();
            }
            catch (Exception ts)
            {
                MessageBox.Show("Error while Loading ID..." + Environment.NewLine + ts);
            }
        }
        //-------------------------------Button save--------------------------------------------//
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtmname.Text != "" && txtnic.Text != "" && txtphon.Text != "" && txtaddress.Text != "" && dtpdo.Text != "" && txtmid.Text != "")
                try
                {
                    String saveque = "INSERT INTO Member_Dtl VALUES('" + SSerial + "','"+ txtmid.Text + "','"+ txtmname.Text + "','" + txtaddress.Text + "','" + txtnic.Text + "','" + txtphon.Text + "','"+ dtpdo.Text +  "')";
                    conn.Open();
                    cmd = new SqlCommand(saveque, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Details of Member " + txtmname.Text + " ,successfully save to the Database!", "SAVED!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    eraseMe();
                    idGenerator();
                }
                catch (Exception MyError)
                {
                    MessageBox.Show("Error while Save..." + Environment.NewLine + MyError);
                }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //-------------------------------from load--------------------------------------------//
        private void AddStudent_Load(object sender, EventArgs e)
        {
            idGenerator();
        }
        private void ptbox_Click(object sender, EventArgs e)
        {
           
        }
    }
}
