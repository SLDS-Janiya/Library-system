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
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True");

        //-------------------------------Button Exit--------------------------------------------//
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

        //-------------------------------Button clear--------------------------------------------//
        private void btncl_Click(object sender, EventArgs e)
        {
            txtMembername.Text = "";
            panel2.Visible = false;
            txtMembername.Focus();
        }

        //-------------------------------Button cancle--------------------------------------------//
        private void btncancle_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtMembername.Focus();
        }

        //-------------------------------from load--------------------------------------------//
        private void ViewMembers_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            if (loginForm.Utype == "User")
            {
                panel2.Visible = false;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Member_Dtl";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int mid;
        int rowid;
        //-------------------------------Button update--------------------------------------------//
        private void btnup_Click(object sender, EventArgs e)
        {
            try
            {
                String upque = "UPDATE Member_Dtl SET MemberName='" + txtMname.Text + "',Address='" + txtmaddres.Text + "',NIC='" + txtnic.Text + "',PhoneNo='" + txtphonno.Text + "',DOB='" + dtpdob.Text + "' WHERE Sid='" + rowid + "'";
                conn.Open();
                cmd = new SqlCommand(upque, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Member " + txtMname.Text + "\'s Details successfully UPDATED!", "UPDATED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel2.Visible = false;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
                SqlCommand cmdd = new SqlCommand();
                cmdd.Connection = con;

                cmdd.CommandText = "select * from Member_Dtl";
                SqlDataAdapter da = new SqlDataAdapter(cmdd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                panel2.Visible = false;
                txtMembername.Focus();
                txtMembername.Text = "";

            }
            catch (Exception mygs)
            {
                MessageBox.Show("Error while UPDATE..." + Environment.NewLine + mygs);
            }
        }

        //-------------------------------search txt --------------------------------------------//
        private void txtMembername_TextChanged(object sender, EventArgs e)
        {
            if (txtMembername.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Member_Dtl where MemberName LIKE '" + txtMembername.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Member_Dtl";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        //-------------------------------Button delete--------------------------------------------//
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult conDel = MessageBox.Show("Are you sure, You want toDelete Member Dtl: " + txtMname.Text + " from the Database??? ", "Confirm to Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conDel == DialogResult.Yes)
                {
                    String Delque = "DELETE FROM Member_Dtl WHERE Sid='" + rowid + "'";
                    conn.Open();
                    cmd = new SqlCommand(Delque, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("DeleteSuccessfully!", "DELETE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMembername.Focus();
                    panel2.Visible = false;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
                    SqlCommand cmddd = new SqlCommand();
                    cmddd.Connection = con;

                    cmddd.CommandText = "select * from Member_Dtl";
                    SqlDataAdapter da = new SqlDataAdapter(cmddd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];

                    panel2.Visible = false;
                    txtMembername.Focus();
                    txtMembername.Text = "";
                }
            }
            catch (Exception nnt)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + nnt);
            }
        }
        //-------------------------------dataGridview cell click--------------------------------------------//
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) /*(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)*/
            {
                mid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            if (loginForm.Utype == "User")
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Member_Dtl where Sid= " + mid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtMname.Text = ds.Tables[0].Rows[0][3].ToString();
            txtmaddres.Text = ds.Tables[0].Rows[0][4].ToString();
            txtnic.Text = ds.Tables[0].Rows[0][5].ToString();
            txtphonno.Text = ds.Tables[0].Rows[0][6].ToString();
            dtpdob.Text = ds.Tables[0].Rows[0][7].ToString();
        }
    }
}
