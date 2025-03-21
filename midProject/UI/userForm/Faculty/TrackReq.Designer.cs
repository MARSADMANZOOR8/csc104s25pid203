namespace midProject.UI.userForm.Faculty
{
    partial class TrackReq
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
            this.reqGrid = new System.Windows.Forms.DataGridView();
            this.btnload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reqGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Requests";
            // 
            // reqGrid
            // 
            this.reqGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reqGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reqGrid.Location = new System.Drawing.Point(110, 218);
            this.reqGrid.Name = "reqGrid";
            this.reqGrid.RowHeadersWidth = 51;
            this.reqGrid.RowTemplate.Height = 24;
            this.reqGrid.Size = new System.Drawing.Size(681, 315);
            this.reqGrid.TabIndex = 1;
            this.reqGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reqGrid_CellContentClick);
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnload.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(424, 587);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(351, 52);
            this.btnload.TabIndex = 2;
            this.btnload.Text = "Load My Requests";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // TrackReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.reqGrid);
            this.Controls.Add(this.label1);
            this.Name = "TrackReq";
            this.Size = new System.Drawing.Size(887, 704);
            ((System.ComponentModel.ISupportInitialize)(this.reqGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reqGrid;
        private System.Windows.Forms.Button btnload;
    }
}
