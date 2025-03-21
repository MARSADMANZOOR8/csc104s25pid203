namespace midProject.UI.windowForm
{
    partial class DeptHead
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AsWork = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ApprBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ResBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(314, 704);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 160);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AsWork);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 67);
            this.panel3.TabIndex = 1;
            // 
            // AsWork
            // 
            this.AsWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AsWork.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsWork.Location = new System.Drawing.Point(0, 0);
            this.AsWork.Name = "AsWork";
            this.AsWork.Size = new System.Drawing.Size(311, 67);
            this.AsWork.TabIndex = 0;
            this.AsWork.Text = "Assign Workload";
            this.AsWork.UseVisualStyleBackColor = true;
            this.AsWork.Click += new System.EventHandler(this.AsWork_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ApprBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 67);
            this.panel4.TabIndex = 2;
            // 
            // ApprBtn
            // 
            this.ApprBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApprBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprBtn.Location = new System.Drawing.Point(0, 0);
            this.ApprBtn.Name = "ApprBtn";
            this.ApprBtn.Size = new System.Drawing.Size(311, 67);
            this.ApprBtn.TabIndex = 1;
            this.ApprBtn.Text = "Handle Requests";
            this.ApprBtn.UseVisualStyleBackColor = true;
            this.ApprBtn.Click += new System.EventHandler(this.ApprBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ResBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 315);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 67);
            this.panel5.TabIndex = 3;
            // 
            // ResBtn
            // 
            this.ResBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResBtn.Location = new System.Drawing.Point(0, 0);
            this.ResBtn.Name = "ResBtn";
            this.ResBtn.Size = new System.Drawing.Size(311, 67);
            this.ResBtn.TabIndex = 1;
            this.ResBtn.Text = "Add Resources";
            this.ResBtn.UseVisualStyleBackColor = true;
            this.ResBtn.Click += new System.EventHandler(this.ResBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1201, 704);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 704);
            this.panel1.TabIndex = 2;
            // 
            // DeptHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 704);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "DeptHead";
            this.Text = "DeptHead";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AsWork;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ApprBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ResBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
    }
}