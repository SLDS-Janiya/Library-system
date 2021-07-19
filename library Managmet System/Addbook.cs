﻿using System;
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
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        SqlDataAdapter SqlDa = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True");

        //-------------------------------eraseMe--------------------------------------------//
        private void eraseMe()
        {
            txtbname.Text = "";
            txtauthor.Text = "";
            txtpublic.Text = "";
            txtquan.Text = "";
            txtbname.Focus();
        }

        //-------------------------------Button save--------------------------------------------//
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbname.Text != "" && txtauthor.Text != "" && txtpublic.Text != "" && txtquan.Text != "")
                try
                {

                    String saveque = "INSERT INTO Book_Dtl VALUES('" + txtbname.Text + "','" + txtauthor.Text + "','" + txtpublic.Text + "','" + txtquan.Text + "')";
                    conn.Open();
                    cmd = new SqlCommand(saveque, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Details of Book " + txtbname.Text + " ,successfully save to the Database!", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eraseMe();
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

        //-------------------------------Button clear--------------------------------------------//
        private void btncl_Click(object sender, EventArgs e)
        {
            eraseMe();
        }

        //-------------------------------Button Exit--------------------------------------------//
        private void btnexit_Click_1(object sender, EventArgs e)
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
               private void ptbox_Click(object sender, EventArgs e)
        {
           
            }
        }
    }