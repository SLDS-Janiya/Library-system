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
    public partial class Retern_Book : Form
    {
        public Retern_Book()
        {
            InitializeComponent();
        }
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True");

        int rowid;
        String bname;
        String bdate;

        //-------------------------------button exit--------------------------------------------//
        private void btnexit_Click(object sender, EventArgs e)
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

        //-------------------------------button clear--------------------------------------------//
        private void btncl_Click(object sender, EventArgs e)
        {
            txtmid.Text = "";
            panel2.Visible = false;
            txtmid.Focus();
        }
        //-------------------------------button retern--------------------------------------------//
        private void btnretern_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "update Issuesbook_Dtl set Book_retern_date = '"+dtprent.Text+"' where MID = '"+txtmid.Text+"' and id = "+rowid+"";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Return Succesful !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmid.Focus();
                txtmid.Text = "";

                Retern_Book_Load(this, null);
            }
            catch (Exception mygs)
            {
                MessageBox.Show("Error while Return Book..." + Environment.NewLine + mygs);
            }
        }

        //-------------------------------button search--------------------------------------------//
        private void btnse_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Issuesbook_Dtl where MID = '" + txtmid.Text + "' and Book_retern_date is null";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);


            if (DS.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or Book Issued !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmid.Text = "";
                panel2.Visible = false;
                txtmid.Focus();
            }
        }

        //-------------------------------form load--------------------------------------------//
        private void Retern_Book_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtmid.Clear();
            if (loginForm.Utype == "User")
            {
                panel2.Visible = false;
            }
        }

        //-------------------------------dataGridView1_CellClick--------------------------------------------//
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtbname.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtbissdate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
              private void ptbox_Click(object sender, EventArgs e)
        {
           
        }
    }
}
