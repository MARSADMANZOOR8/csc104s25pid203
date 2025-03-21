namespace midProject.UI.userForm.Adm
{
    partial class ManageCourses
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
            this.AddCourse = new System.Windows.Forms.Button();
            this.AlcBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ViewBtn);
            this.panel1.Controls.Add(this.AlcBtn);
            this.panel1.Controls.Add(this.AddCourse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(887, 704);
            this.panel1.TabIndex = 0;
            // 
            // AddCourse
            // 
            this.AddCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCourse.BackColor = System.Drawing.Color.Lime;
            this.AddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourse.Location = new System.Drawing.Point(275, 145);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(337, 77);
            this.AddCourse.TabIndex = 0;
            this.AddCourse.Text = "Create Course";
            this.AddCourse.UseVisualStyleBackColor = false;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // AlcBtn
            // 
            this.AlcBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AlcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlcBtn.Location = new System.Drawing.Point(275, 303);
            this.AlcBtn.Name = "AlcBtn";
            this.AlcBtn.Size = new System.Drawing.Size(337, 77);
            this.AlcBtn.TabIndex = 1;
            this.AlcBtn.Text = "Allocate Course";
            this.AlcBtn.UseVisualStyleBackColor = false;
            this.AlcBtn.Click += new System.EventHandler(this.AlcBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewBtn.BackColor = System.Drawing.Color.Red;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.Location = new System.Drawing.Point(275, 453);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(337, 77);
            this.ViewBtn.TabIndex = 2;
            this.ViewBtn.Text = "View Courses";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // ManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ManageCourses";
            this.Size = new System.Drawing.Size(887, 704);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button AlcBtn;
        private System.Windows.Forms.Button AddCourse;
    }
}
