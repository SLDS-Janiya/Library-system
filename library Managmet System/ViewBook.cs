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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True");

        //-------------------------------from load--------------------------------------------//
        private void ViewBook_Load(object sender, EventArgs e)
        {
            if (loginForm.Utype == "User")
            {
               panel1.Visible = false;
            }
            panel1.Visible = false;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Book_Dtl";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        int bid;
        int rowid;
        //-------------------------------Button cancle--------------------------------------------//
        private void btncancle_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtBookname.Focus();
        }

        //-------------------------------txt search --------------------------------------------//
        private void txtBookname_TextChanged(object sender, EventArgs e)
        {
            if(txtBookname.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Book_Dtl where BName LIKE '"+txtBookname.Text+ "%'";
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

                cmd.CommandText = "select * from Book_Dtl";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        //-------------------------------ereseMe--------------------------------------------//
        private void eraseMe()
        {
            txtBookname.Text = "";
            panel1.Visible = false;
            txtBookname.Focus();
        }
        //-------------------------------Button clear--------------------------------------------//
        private void btncl_Click(object sender, EventArgs e)
        {
            eraseMe();
        }

        //-------------------------------Button update--------------------------------------------//
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                String upque = "UPDATE Book_Dtl SET BName='" + txtBname.Text + "',BAuthor='" + txtauthour.Text + "',BPubl='" + txtpb.Text + "',BQuan='" + txtqut.Text +  "' WHERE Bid='" + rowid + "'";
                conn.Open();
                cmd = new SqlCommand(upque, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Book " + txtBname.Text + "\'s Details successfully UPDATED!", "UPDATED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel1.Visible = false;
                txtBookname.Focus();

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
                SqlCommand cmdd = new SqlCommand();
                cmdd.Connection = con;

                cmdd.CommandText = "select * from Book_Dtl";
                SqlDataAdapter da = new SqlDataAdapter(cmdd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                txtBookname.Focus();
                eraseMe();

            }
            catch (Exception mygs)
            {
                MessageBox.Show("Error while UPDATE..." + Environment.NewLine + mygs);
            }

        }

        //-------------------------------Button delete--------------------------------------------//
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
               DialogResult conDel = MessageBox.Show("Are you sure, You want toDelete Book Dtl: " + txtBname.Text+ " from the Database??? ", "Confirm to Delete!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (conDel == DialogResult.Yes)
                {
                    String Delque = "DELETE FROM Book_Dtl WHERE Bid='" + rowid + "'";
                    conn.Open();
                    cmd = new SqlCommand(Delque, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("DeleteSuccessfully!", "DELETE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookname.Focus();
                    panel1.Visible = false;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
                    SqlCommand cmddd = new SqlCommand();
                    cmddd.Connection = con;

                    cmddd.CommandText = "select * from Book_Dtl";
                    SqlDataAdapter da = new SqlDataAdapter(cmddd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                    txtBookname.Focus();
                    eraseMe();

                }
            }
            catch (Exception nnt)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + nnt);
            }
        }

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
        //-------------------------------dataGridviiew cell --------------------------------------------//
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            if (loginForm.Utype == "User")
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Book_Dtl where Bid= " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtBname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtauthour.Text = ds.Tables[0].Rows[0][2].ToString();
            txtpb.Text = ds.Tables[0].Rows[0][3].ToString();
            txtqut.Text = ds.Tables[0].Rows[0][4].ToString();
        }
        private void ptbox_Click(object sender, EventArgs e)
        {
           
        }
    }
}
