namespace midProject.UI.windowForm
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UptBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.MngBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ReqBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(314, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 704);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RosyBrown;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(314, 704);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 160);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UptBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 67);
            this.panel3.TabIndex = 1;
            // 
            // UptBtn
            // 
            this.UptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UptBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UptBtn.Location = new System.Drawing.Point(0, 0);
            this.UptBtn.Name = "UptBtn";
            this.UptBtn.Size = new System.Drawing.Size(311, 67);
            this.UptBtn.TabIndex = 0;
            this.UptBtn.Text = "Update Faculty";
            this.UptBtn.UseVisualStyleBackColor = true;
            this.UptBtn.Click += new System.EventHandler(this.UptBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.MngBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 67);
            this.panel4.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(311, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "Course Allocation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MngBtn
            // 
            this.MngBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MngBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngBtn.Location = new System.Drawing.Point(0, 0);
            this.MngBtn.Name = "MngBtn";
            this.MngBtn.Size = new System.Drawing.Size(311, 67);
            this.MngBtn.TabIndex = 1;
            this.MngBtn.Text = "Course Allocation";
            this.MngBtn.UseVisualStyleBackColor = true;
            this.MngBtn.Click += new System.EventHandler(this.MngBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ReqBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 315);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 67);
            this.panel5.TabIndex = 3;
            // 
            // ReqBtn
            // 
            this.ReqBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqBtn.Location = new System.Drawing.Point(0, 0);
            this.ReqBtn.Name = "ReqBtn";
            this.ReqBtn.Size = new System.Drawing.Size(311, 67);
            this.ReqBtn.TabIndex = 1;
            this.ReqBtn.Text = "Faculty Requests";
            this.ReqBtn.UseVisualStyleBackColor = true;
            this.ReqBtn.Click += new System.EventHandler(this.ReqBtn_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 0);
            this.button1.TabIndex = 4;
            this.button1.Text = "Faculty Requests";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1201, 704);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button UptBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button MngBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ReqBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}