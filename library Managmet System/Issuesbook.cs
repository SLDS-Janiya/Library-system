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
    public partial class Issuesbook : Form
    {
        public Issuesbook()
        {
            InitializeComponent();
        }
        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True");
        int count;

        //-------------------------------ereseMe--------------------------------------------//
        private void eraseMe()
        {
            txtsemid.Text = "";
            cmbbname.Text = "--SELET--";
            txtnic.Text = "";
            txtpho.Text = "";
            txtmname.Text = "";
            dtpissu.Text = "";
            txtsemid.Focus();
        }
        //-------------------------------Button clear--------------------------------------------//
        private void btncl_Click(object sender, EventArgs e)
        {
            eraseMe();
        }
        //-------------------------------Button exit--------------------------------------------//
        private void btnex_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure, You want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Dispose();

                Mainmenu frmM = new Mainmenu();
                frmM.Show();
                this.Hide();
                eraseMe();
            }
        }
        //-------------------------------form load--------------------------------------------//
        private void Issuesbook_Load(object sender, EventArgs e)
        {
            try
            {
                cmbbname.Text = "--SELET--";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd = new SqlCommand("SELECT BName FROM Book_Dtl", con);
                SqlDataReader Sdr = cmd.ExecuteReader();

                while (Sdr.Read())
                {
                    for (int i = 0; i < Sdr.FieldCount; i++)
                    {
                        cmbbname.Items.Add(Sdr.GetString(i));
                    }
                }
                Sdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Form Loading..." + Environment.NewLine + ex);
            }
        }
        //-------------------------------Button bookissuse--------------------------------------------//
        private void btnissu_Click(object sender, EventArgs e)
        {
            if ( txtnic.Text != "" && txtpho.Text != ""  && txtsemid.Text != "" && dtpissu.Text != "")
            {
                if (txtmname.Text != "")
                  {
                         try
                               {
                            String saveque = "INSERT INTO Issuesbook_Dtl (MID,MemberName,NIC,PhonNo,BName,Book_issues_date) VALUES('" + txtsemid.Text + "','" + txtmname.Text + "','" + txtnic.Text + "','" + txtpho.Text + "','" + cmbbname.Text + "','" + dtpissu.Text + "')";
                            conn.Open();
                            cmd = new SqlCommand(saveque, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Details of Member " + txtmname.Text + ",successfully save to the Database!", "SAVED!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            eraseMe();
                              }
                                catch (Exception MyError)
                               {
                                  MessageBox.Show("Error while Save..." + Environment.NewLine + MyError);
                               }
                    }               
                }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                eraseMe();
            }
        }
        //-------------------------------Button search--------------------------------------------//
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsemid.Text != "")
                {
                    String mid = txtsemid.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select * from Member_Dtl where MID = '" + mid + "'";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    if (DS.Tables[0].Rows.Count != 0)
                       {
                          txtmname.Text =DS.Tables[0].Rows[0][3].ToString();
                          txtnic.Text = DS.Tables[0].Rows[0][5].ToString();
                          txtpho.Text = DS.Tables[0].Rows[0][6].ToString();
                       }
                  else
                       {
                          txtsemid.Text = "";
                          txtnic.Text = "";
                          txtpho.Text = "";
                          txtmname.Text = "";
                          cmbbname.Text = "--SELET--";
                          txtsemid.Focus();
                          MessageBox.Show("Invalid Member ID !!", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Form Loading..." + Environment.NewLine + ex);
            }
        }
        private void ptbox_Click(object sender, EventArgs e)
        {
            }
        }
    }

