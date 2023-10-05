namespace walk_Rn
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ramdomwalkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvnextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvdouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvdounextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfavoidingwalkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lengthrandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1091, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "20";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1296, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1113, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "steps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1325, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "walks";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ramdomwalkToolStripMenuItem,
            this.lengthrandomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1473, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ramdomwalkToolStripMenuItem
            // 
            this.ramdomwalkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.dToolStripMenuItem1,
            this.dToolStripMenuItem2,
            this.dgvnextToolStripMenuItem,
            this.dgvdouToolStripMenuItem,
            this.dgvdounextToolStripMenuItem,
            this.selfavoidingwalkToolStripMenuItem});
            this.ramdomwalkToolStripMenuItem.Name = "ramdomwalkToolStripMenuItem";
            this.ramdomwalkToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.ramdomwalkToolStripMenuItem.Text = "Ramdom_walk";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dToolStripMenuItem.Text = "1d";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem1
            // 
            this.dToolStripMenuItem1.Name = "dToolStripMenuItem1";
            this.dToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dToolStripMenuItem1.Text = "2d";
            this.dToolStripMenuItem1.Click += new System.EventHandler(this.dToolStripMenuItem1_Click);
            // 
            // dToolStripMenuItem2
            // 
            this.dToolStripMenuItem2.Name = "dToolStripMenuItem2";
            this.dToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.dToolStripMenuItem2.Text = "3d";
            this.dToolStripMenuItem2.Click += new System.EventHandler(this.dToolStripMenuItem2_Click);
            // 
            // dgvnextToolStripMenuItem
            // 
            this.dgvnextToolStripMenuItem.Name = "dgvnextToolStripMenuItem";
            this.dgvnextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dgvnextToolStripMenuItem.Text = "dgv_next";
            this.dgvnextToolStripMenuItem.Click += new System.EventHandler(this.dgvnextToolStripMenuItem_Click);
            // 
            // dgvdouToolStripMenuItem
            // 
            this.dgvdouToolStripMenuItem.Name = "dgvdouToolStripMenuItem";
            this.dgvdouToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dgvdouToolStripMenuItem.Text = "dgv_dou";
            this.dgvdouToolStripMenuItem.Click += new System.EventHandler(this.dgvdouToolStripMenuItem_Click);
            // 
            // dgvdounextToolStripMenuItem
            // 
            this.dgvdounextToolStripMenuItem.Name = "dgvdounextToolStripMenuItem";
            this.dgvdounextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dgvdounextToolStripMenuItem.Text = "dgv_dou_next";
            this.dgvdounextToolStripMenuItem.Click += new System.EventHandler(this.dgvdounextToolStripMenuItem_Click);
            // 
            // selfavoidingwalkToolStripMenuItem
            // 
            this.selfavoidingwalkToolStripMenuItem.Name = "selfavoidingwalkToolStripMenuItem";
            this.selfavoidingwalkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selfavoidingwalkToolStripMenuItem.Text = "self_avoiding_walk";
            this.selfavoidingwalkToolStripMenuItem.Click += new System.EventHandler(this.selfavoidingwalkToolStripMenuItem_Click);
            // 
            // lengthrandomToolStripMenuItem
            // 
            this.lengthrandomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kengthToolStripMenuItem});
            this.lengthrandomToolStripMenuItem.Name = "lengthrandomToolStripMenuItem";
            this.lengthrandomToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.lengthrandomToolStripMenuItem.Text = "random_finding";
            this.lengthrandomToolStripMenuItem.Click += new System.EventHandler(this.lengthrandomToolStripMenuItem_Click);
            // 
            // kengthToolStripMenuItem
            // 
            this.kengthToolStripMenuItem.Name = "kengthToolStripMenuItem";
            this.kengthToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.kengthToolStripMenuItem.Text = "Length";
            this.kengthToolStripMenuItem.Click += new System.EventHandler(this.kengthToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1091, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 402);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 559);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ramdomwalkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dgvnextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dgvdouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dgvdounextToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem lengthrandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selfavoidingwalkToolStripMenuItem;
    }
}

