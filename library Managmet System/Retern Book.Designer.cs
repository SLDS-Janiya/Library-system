namespace library_Managmet_System
{
    partial class Retern_Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel122 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtmid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncl = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtprent = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbissdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnretern = new System.Windows.Forms.Button();
            this.btnse = new System.Windows.Forms.Button();
            this.panel122.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel122
            // 
            this.panel122.BackColor = System.Drawing.Color.Firebrick;
            this.panel122.Controls.Add(this.label6);
            this.panel122.Location = new System.Drawing.Point(-10, -7);
            this.panel122.Name = "panel122";
            this.panel122.Size = new System.Drawing.Size(888, 67);
            this.panel122.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(303, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Retern Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(797, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Tan;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(580, 42);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(175, 35);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtmid
            // 
            this.txtmid.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtmid.Location = new System.Drawing.Point(355, 66);
            this.txtmid.Name = "txtmid";
            this.txtmid.Size = new System.Drawing.Size(260, 35);
            this.txtmid.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(140, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search Member ID";
            // 
            // btncl
            // 
            this.btncl.BackColor = System.Drawing.Color.Tan;
            this.btncl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncl.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.btncl.ForeColor = System.Drawing.Color.DarkRed;
            this.btncl.Location = new System.Drawing.Point(744, 66);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(89, 35);
            this.btncl.TabIndex = 14;
            this.btncl.Text = "CLEAR";
            this.btncl.UseVisualStyleBackColor = false;
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtprent);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.txtbissdate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtbname);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnretern);
            this.panel2.Location = new System.Drawing.Point(24, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 175);
            this.panel2.TabIndex = 16;
            // 
            // dtprent
            // 
            this.dtprent.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtprent.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.dtprent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtprent.Location = new System.Drawing.Point(249, 118);
            this.dtprent.Name = "dtprent";
            this.dtprent.Size = new System.Drawing.Size(285, 35);
            this.dtprent.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Book Retern Date";
            // 
            // txtbissdate
            // 
            this.txtbissdate.Enabled = false;
            this.txtbissdate.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbissdate.Location = new System.Drawing.Point(249, 69);
            this.txtbissdate.MaxLength = 3000;
            this.txtbissdate.Name = "txtbissdate";
            this.txtbissdate.ReadOnly = true;
            this.txtbissdate.Size = new System.Drawing.Size(285, 35);
            this.txtbissdate.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Book Issue Date";
            // 
            // txtbname
            // 
            this.txtbname.Enabled = false;
            this.txtbname.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbname.Location = new System.Drawing.Point(249, 12);
            this.txtbname.MaxLength = 3000;
            this.txtbname.Name = "txtbname";
            this.txtbname.ReadOnly = true;
            this.txtbname.Size = new System.Drawing.Size(285, 35);
            this.txtbname.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "Book Name";
            // 
            // btnretern
            // 
            this.btnretern.BackColor = System.Drawing.Color.Tan;
            this.btnretern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnretern.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretern.ForeColor = System.Drawing.Color.DarkRed;
            this.btnretern.Location = new System.Drawing.Point(580, 111);
            this.btnretern.Name = "btnretern";
            this.btnretern.Size = new System.Drawing.Size(175, 40);
            this.btnretern.TabIndex = 7;
            this.btnretern.Text = "RETERN BOOK";
            this.btnretern.UseVisualStyleBackColor = false;
            this.btnretern.Click += new System.EventHandler(this.btnretern_Click);
            // 
            // btnse
            // 
            this.btnse.BackColor = System.Drawing.Color.Tan;
            this.btnse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnse.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnse.ForeColor = System.Drawing.Color.DarkRed;
            this.btnse.Location = new System.Drawing.Point(621, 66);
            this.btnse.Name = "btnse";
            this.btnse.Size = new System.Drawing.Size(107, 35);
            this.btnse.TabIndex = 17;
            this.btnse.Text = "SEARCH";
            this.btnse.UseVisualStyleBackColor = false;
            this.btnse.Click += new System.EventHandler(this.btnse_Click);
            // 
            // Retern_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 489);
            this.ControlBox = false;
            this.Controls.Add(this.btnse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtmid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel122);
            this.Name = "Retern_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retern Book";
            this.Load += new System.EventHandler(this.Retern_Book_Load);
            this.panel122.ResumeLayout(false);
            this.panel122.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel122;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtmid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbissdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnretern;
        private System.Windows.Forms.DateTimePicker dtprent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnse;
    }
}