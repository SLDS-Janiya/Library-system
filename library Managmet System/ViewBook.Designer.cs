namespace library_Managmet_System
{
    partial class ViewBook
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
            this.btncl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtqut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtauthour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtBname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancle = new System.Windows.Forms.Button();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncl
            // 
            this.btncl.BackColor = System.Drawing.Color.Tan;
            this.btncl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncl.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.btncl.ForeColor = System.Drawing.Color.DarkRed;
            this.btncl.Location = new System.Drawing.Point(1028, 81);
            this.btncl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncl.Name = "btncl";
            this.btncl.Size = new System.Drawing.Size(147, 43);
            this.btncl.TabIndex = 1;
            this.btncl.Text = "CLEAR";
            this.btncl.UseVisualStyleBackColor = false;
            this.btncl.Click += new System.EventHandler(this.btncl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(268, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Book";
            // 
            // txtBookname
            // 
            this.txtBookname.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtBookname.Location = new System.Drawing.Point(540, 81);
            this.txtBookname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(345, 42);
            this.txtBookname.TabIndex = 0;
            this.txtBookname.TextChanged += new System.EventHandler(this.txtBookname_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 254);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtqut);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtpb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtauthour);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.txtBname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btncancle);
            this.panel1.Location = new System.Drawing.Point(23, 428);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 229);
            this.panel1.TabIndex = 4;
            // 
            // txtqut
            // 
            this.txtqut.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqut.Location = new System.Drawing.Point(827, 101);
            this.txtqut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtqut.Name = "txtqut";
            this.txtqut.Size = new System.Drawing.Size(307, 42);
            this.txtqut.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // txtpb
            // 
            this.txtpb.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpb.Location = new System.Drawing.Point(827, 47);
            this.txtpb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpb.Name = "txtpb";
            this.txtpb.Size = new System.Drawing.Size(307, 42);
            this.txtpb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(613, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publisher";
            // 
            // txtauthour
            // 
            this.txtauthour.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtauthour.Location = new System.Drawing.Point(193, 101);
            this.txtauthour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtauthour.Name = "txtauthour";
            this.txtauthour.Size = new System.Drawing.Size(379, 42);
            this.txtauthour.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Tan;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.DarkRed;
            this.btnupdate.Location = new System.Drawing.Point(33, 166);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(165, 49);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Tan;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btndelete.Location = new System.Drawing.Point(464, 166);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(153, 49);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtBname
            // 
            this.txtBname.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBname.Location = new System.Drawing.Point(193, 47);
            this.txtBname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBname.Name = "txtBname";
            this.txtBname.Size = new System.Drawing.Size(379, 42);
            this.txtBname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Title";
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.Tan;
            this.btncancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.DarkRed;
            this.btncancle.Location = new System.Drawing.Point(983, 166);
            this.btncancle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(152, 49);
            this.btncancle.TabIndex = 7;
            this.btncancle.Text = "CANCEL";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.IndianRed;
            this.panel22.Controls.Add(this.label6);
            this.panel22.Location = new System.Drawing.Point(0, -2);
            this.panel22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(1199, 80);
            this.panel22.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(460, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 48);
            this.label6.TabIndex = 2;
            this.label6.Text = "View Book ";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Tan;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(23, 81);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(147, 43);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 670);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBookname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Book";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtqut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtauthour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtBname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnexit;
    }
}