namespace midProject.UI.userForm.Faculty
{
    partial class ViewCources
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
            this.label1 = new System.Windows.Forms.Label();
            this.courseGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Courses";
            // 
            // courseGrid
            // 
            this.courseGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.courseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGrid.Location = new System.Drawing.Point(105, 180);
            this.courseGrid.Name = "courseGrid";
            this.courseGrid.RowHeadersWidth = 51;
            this.courseGrid.RowTemplate.Height = 24;
            this.courseGrid.Size = new System.Drawing.Size(643, 264);
            this.courseGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(421, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load My Courses";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewCources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.courseGrid);
            this.Controls.Add(this.label1);
            this.Name = "ViewCources";
            this.Size = new System.Drawing.Size(887, 704);
            ((System.ComponentModel.ISupportInitialize)(this.courseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView courseGrid;
        private System.Windows.Forms.Button button1;
    }
}
