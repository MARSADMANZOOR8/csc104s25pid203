namespace midProject.UI.userForm.Faculty
{
    partial class ResourceReq
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Qtxt = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.ComboBox();
            this.reqBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item Name";
            // 
            // Qtxt
            // 
            this.Qtxt.Location = new System.Drawing.Point(606, 132);
            this.Qtxt.Multiline = true;
            this.Qtxt.Name = "Qtxt";
            this.Qtxt.Size = new System.Drawing.Size(196, 36);
            this.Qtxt.TabIndex = 9;
            // 
            // pname
            // 
            this.pname.FormattingEnabled = true;
            this.pname.Location = new System.Drawing.Point(221, 136);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(212, 24);
            this.pname.TabIndex = 13;
            // 
            // reqBtn
            // 
            this.reqBtn.BackColor = System.Drawing.Color.Lime;
            this.reqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqBtn.Location = new System.Drawing.Point(412, 276);
            this.reqBtn.Name = "reqBtn";
            this.reqBtn.Size = new System.Drawing.Size(218, 46);
            this.reqBtn.TabIndex = 16;
            this.reqBtn.Text = "Submit Request";
            this.reqBtn.UseMnemonic = false;
            this.reqBtn.UseVisualStyleBackColor = false;
            this.reqBtn.Click += new System.EventHandler(this.reqBtn_Click);
            // 
            // ResourceReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reqBtn);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Qtxt);
            this.Name = "ResourceReq";
            this.Size = new System.Drawing.Size(887, 704);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Qtxt;
        private System.Windows.Forms.ComboBox pname;
        private System.Windows.Forms.Button reqBtn;
    }
}
