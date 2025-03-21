namespace midProject.UI.userForm.DeptHead
{
    partial class HandleReq
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
            this.FReqGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FReqGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Requests";
            // 
            // FReqGrid
            // 
            this.FReqGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FReqGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FReqGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FReqGrid.Location = new System.Drawing.Point(102, 214);
            this.FReqGrid.Name = "FReqGrid";
            this.FReqGrid.RowHeadersWidth = 51;
            this.FReqGrid.RowTemplate.Height = 24;
            this.FReqGrid.Size = new System.Drawing.Size(676, 302);
            this.FReqGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(426, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load Requests";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HandleReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FReqGrid);
            this.Controls.Add(this.label1);
            this.Name = "HandleReq";
            this.Size = new System.Drawing.Size(887, 704);
            ((System.ComponentModel.ISupportInitialize)(this.FReqGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FReqGrid;
        private System.Windows.Forms.Button button1;
    }
}
