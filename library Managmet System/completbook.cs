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
    public partial class completbook : Form
    {
        public completbook()
        {
            InitializeComponent();
        }
        //-------------------------------From load--------------------------------------------//
        private void completbook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-P8TJM59;Initial Catalog=library_System;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Issuesbook_Dtl where Book_retern_date is null";
            SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
            DataSet DS1 = new DataSet();
            DA1.Fill(DS1);
            dataGridView1.DataSource = DS1.Tables[0];

            //-------------------------------dataGridView2--------------------------------------------//
            cmd.CommandText = "select * from Issuesbook_Dtl where Book_retern_date is not null";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView2.DataSource = DS.Tables[0];
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
            }
        }
        private void ptbox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
