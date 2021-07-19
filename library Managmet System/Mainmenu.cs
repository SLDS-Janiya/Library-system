using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_Managmet_System
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        //-------------------------------addBook--------------------------------------------//
        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addbook frm = new Addbook();
            frm.Show();
            this.Hide();
        }

        //-------------------------------viewBook--------------------------------------------//
        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook frm = new ViewBook();
            frm.Show();
            this.Hide();
        }

        //-------------------------------addMember--------------------------------------------//
        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent frm = new AddStudent();
            frm.Show();
            this.Hide();
        }

        //-------------------------------viewMember--------------------------------------------//
        private void viewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMembers frm = new ViewMembers();
            frm.Show();
            this.Hide();
        }

        //-------------------------------Mainmenu Load--------------------------------------------//
        private void Mainmenu_Load(object sender, EventArgs e)
        {
            lblwelcom.Text = loginForm.Rname + ", WELCOME TO LIBRARY Management System !!!";
            if (loginForm.Utype == "User")
            {
                issueBookToolStripMenuItem.Visible = false;
                PIMReternbook.Visible = false;
                addBookT.Visible = false;
                addMemberT.Visible = false;
            }
        }

               //-------------------------------userRegi--------------------------------------------//
        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.Show();
            this.Hide();
        }

        //-------------------------------exitToolStripMenuItem--------------------------------------------//
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure, You want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //-------------------------------logout--------------------------------------------//
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm frm = new loginForm();
            frm.Show();
            this.Hide();
        }

        //-------------------------------issueBook--------------------------------------------//
        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issuesbook frm = new Issuesbook();
            frm.Show();
            this.Hide();
        }

        //-------------------------------reteranBook--------------------------------------------//
        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Retern_Book frm = new Retern_Book();
            frm.Show();
            this.Hide();
        }

        //-------------------------------completBook--------------------------------------------//
        private void completBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            completbook frm = new completbook();
            frm.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void issueBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
