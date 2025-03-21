namespace midProject.UI.userForm.Adm
{
    partial class CreateCourse
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HoursTxt = new System.Windows.Forms.TextBox();
            this.TypeTxt = new System.Windows.Forms.TextBox();
            this.HrsTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HrsTxt);
            this.panel1.Controls.Add(this.TypeTxt);
            this.panel1.Controls.Add(this.HoursTxt);
            this.panel1.Controls.Add(this.NameTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 704);
            this.panel1.TabIndex = 0;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(196, 134);
            this.NameTxt.Multiline = true;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(203, 45);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HoursTxt
            // 
            this.HoursTxt.Location = new System.Drawing.Point(196, 313);
            this.HoursTxt.Multiline = true;
            this.HoursTxt.Name = "HoursTxt";
            this.HoursTxt.Size = new System.Drawing.Size(203, 45);
            this.HoursTxt.TabIndex = 1;
            this.HoursTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TypeTxt
            // 
            this.TypeTxt.Location = new System.Drawing.Point(614, 134);
            this.TypeTxt.Multiline = true;
            this.TypeTxt.Name = "TypeTxt";
            this.TypeTxt.Size = new System.Drawing.Size(203, 45);
            this.TypeTxt.TabIndex = 2;
            this.TypeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HrsTxt
            // 
            this.HrsTxt.Location = new System.Drawing.Point(614, 313);
            this.HrsTxt.Multiline = true;
            this.HrsTxt.Name = "HrsTxt";
            this.HrsTxt.Size = new System.Drawing.Size(203, 45);
            this.HrsTxt.TabIndex = 3;
            this.HrsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact Hours";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Credit Hours";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course Type";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(663, 483);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(154, 46);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "Create";
            this.AddBtn.UseMnemonic = false;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CreateCourse";
            this.Size = new System.Drawing.Size(887, 704);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HrsTxt;
        private System.Windows.Forms.TextBox TypeTxt;
        private System.Windows.Forms.TextBox HoursTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AddBtn;
    }
}
