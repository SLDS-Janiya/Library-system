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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True");

        //-------------------------------ereseMe--------------------------------------------//
        private void eraseMe()
        {
            txtuname.Text = "";
            txtrealname.Text = "";
            txtpassword.Text = "";
            cmbutype.Text = "--SELET--";
            btndelete.Visible = false;
            btnupdate.Visible = false;
            cmbseusname.Visible = false;
            txtuname.Focus();
        }

        //-------------------------------Button update--------------------------------------------//
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                String upque = "UPDATE UserDtl SET UserRealName='" + txtrealname.Text + "',Password='" + txtpassword.Text + "',UserType='" +cmbutype.Text +"' WHERE Username='" + cmbseusname.Text + "'";
                conn.Open();
                cmd = new SqlCommand(upque, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User " + txtuname.Text +"\'s Details Updated Successfully!", "UPDATE " + txtuname.Text +"!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                eraseMe();
            }
            catch (Exception extp)
            {
                MessageBox.Show("Error while Update Data..." + Environment.NewLine + extp);
            }
        }

        //-------------------------------Button save--------------------------------------------//
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtuname.Text != "" && txtpassword.Text != "" && cmbutype.Text != "" && txtrealname.Text != "")
            {
                try
                {
                    if (loginForm.Utype == "User")
                    {
                        {
                            String saveque = "INSERT INTO UserDtl VALUES('" + txtuname.Text + "','" + txtpassword.Text + "','" + txtuuname.Text + "','" + txtrealname.Text + "')";
                            conn.Open();
                            cmd = new SqlCommand(saveque, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("User " + txtuname.Text + "\'s details successfully SAVE to the DATABASE with User Name:" + txtuname.Text + "!", "SAVE Success-" + txtrealname.Text + "!!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            eraseMe();
                        }
                    }
                    else
                    {
                        {
                            String saveque = "INSERT INTO UserDtl VALUES('" + txtuname.Text + "','" + txtpassword.Text + "','" + cmbutype.Text + "','" + txtrealname.Text + "')";
                            conn.Open();
                            cmd = new SqlCommand(saveque, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("User " + txtuname.Text + "\'s details successfully SAVE to the DATABASE with User Name:" + txtuname.Text + "!", "SAVE Success-" + txtrealname.Text + "!!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            eraseMe();
                        }
                    }
                }
                catch (Exception cake)
                {
                    MessageBox.Show("Error while Save Data..." + Environment.NewLine + cake);
                }
            }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //-------------------------------Button exit--------------------------------------------//
        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure, You want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Dispose();

                btndelete.Visible = false;
                btnupdate.Visible = false;
                cmbseusname.Visible = false;


                Mainmenu frm = new Mainmenu();
                frm.Show();
            }
        }

        //-------------------------------Button clear--------------------------------------------//
        private void btnclear_Click(object sender, EventArgs e)
        {
            eraseMe();
        }

        //-------------------------------Button delete--------------------------------------------//
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resdel = MessageBox.Show("Are you sure, You want to DELETE User Name:" +cmbseusname.Text + " details from the Database?", "Delete to Confirm!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resdel == DialogResult.Yes)
                {
                    String delque = "DELETE FROM UserDtl WHERE Username='" + cmbseusname.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(delque, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Details of " + txtuname.Text +" successfully Deleted from the Database!", "DELETED!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eraseMe();
                }
            }
            catch (Exception tsw)
            {
                MessageBox.Show("Error while Deleting..." + Environment.NewLine + tsw);
            }
        }

        //-------------------------------Button search--------------------------------------------//
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (loginForm.Utype == "User")
            {
                btnsearch.Visible = false;
            }
            else
            {
                btnsearch.Visible = true;
            }
            btndelete.Visible = true;
            btnupdate.Visible = true;
            cmbseusname.Visible = true;

            try
            {
                String getName = "SELECT Username FROM UserDtl";
                conn.Open();
                SqlDa = new SqlDataAdapter(getName, conn);
                DataTable myDt = new DataTable();
                SqlDa.Fill(myDt);
                conn.Close();
                cmbseusname.Items.Clear();
                cmbseusname.Items.Add("--SELECT--");
                foreach (DataRow row in myDt.Rows)
                {
                    cmbseusname.Items.Add(row["Username"]);
                }
                cmbseusname.SelectedIndex = 0;

            }
            catch (Exception myhon)
            {
                MessageBox.Show("Error while getting User Names.." + Environment.NewLine + myhon);
            }
        }

        //-------------------------------cmbseusname--------------------------------------------//
        private void cmbseusname_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbseusname.SelectedIndex != 0)
                {
                    String getStDtls = "SELECT * FROM UserDtl WHERE Username='" + cmbseusname.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getStDtls, conn);
                    SqlDataReader R = cmd.ExecuteReader();
                    while (R.Read())
                    {

                        txtpassword.Text = R.GetValue(1).ToString();
                        cmbutype.Text = R.GetValue(2).ToString();
                        txtrealname.Text = R.GetValue(3).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    txtuname.Text = "";
                    txtpassword.Text = "";
                    cmbseusname.Text = "--SELECT--";
                    txtrealname.Text = "";
                }
            }
            catch (Exception myhf)
            {
                MessageBox.Show("Error while Select all User details.." + Environment.NewLine + myhf);
            }
        }

        //-------------------------------from load--------------------------------------------//
        private void User_Load(object sender, EventArgs e)
        {
            if (loginForm.Utype == "User")
            {
                btnsearch.Visible = false;
                txtuuname.Visible = true;
            }
        }
        private void ptbox_Click(object sender, EventArgs e)
        {
         
        }
    }
}
