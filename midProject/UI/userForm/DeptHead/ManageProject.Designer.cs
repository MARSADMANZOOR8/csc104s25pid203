namespace midProject.UI.userForm.DeptHead
{
    partial class ManageProject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.AlcBtn = new System.Windows.Forms.Button();
            this.AddProject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 704);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(887, 704);
            this.panel2.TabIndex = 1;
            // 
            // ViewBtn
            // 
            this.ViewBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewBtn.BackColor = System.Drawing.Color.Red;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.Location = new System.Drawing.Point(31, 347);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(337, 77);
            this.ViewBtn.TabIndex = 2;
            this.ViewBtn.Text = "View Projects";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // AlcBtn
            // 
            this.AlcBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AlcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlcBtn.Location = new System.Drawing.Point(31, 197);
            this.AlcBtn.Name = "AlcBtn";
            this.AlcBtn.Size = new System.Drawing.Size(337, 77);
            this.AlcBtn.TabIndex = 1;
            this.AlcBtn.Text = "Assign Project";
            this.AlcBtn.UseVisualStyleBackColor = false;
            this.AlcBtn.Click += new System.EventHandler(this.AlcBtn_Click);
            // 
            // AddProject
            // 
            this.AddProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProject.BackColor = System.Drawing.Color.Lime;
            this.AddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProject.Location = new System.Drawing.Point(31, 39);
            this.AddProject.Name = "AddProject";
            this.AddProject.Size = new System.Drawing.Size(337, 77);
            this.AddProject.TabIndex = 0;
            this.AddProject.Text = "Create Project";
            this.AddProject.UseVisualStyleBackColor = false;
            this.AddProject.Click += new System.EventHandler(this.AddProject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.AlcBtn);
            this.groupBox1.Controls.Add(this.ViewBtn);
            this.groupBox1.Controls.Add(this.AddProject);
            this.groupBox1.Location = new System.Drawing.Point(218, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 474);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // ManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ManageProject";
            this.Size = new System.Drawing.Size(887, 704);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button AlcBtn;
        private System.Windows.Forms.Button AddProject;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
