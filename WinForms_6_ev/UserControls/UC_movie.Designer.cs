namespace WinForms_6_ev.UserControls
{
    partial class UC_movie
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
            this.pBox_movieImage = new System.Windows.Forms.PictureBox();
            this.lbl_movieYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_movieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_movieImage
            // 
            this.pBox_movieImage.Location = new System.Drawing.Point(3, 3);
            this.pBox_movieImage.Name = "pBox_movieImage";
            this.pBox_movieImage.Size = new System.Drawing.Size(182, 237);
            this.pBox_movieImage.TabIndex = 0;
            this.pBox_movieImage.TabStop = false;
            // 
            // lbl_movieYear
            // 
            this.lbl_movieYear.AutoSize = true;
            this.lbl_movieYear.BackColor = System.Drawing.Color.Transparent;
            this.lbl_movieYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_movieYear.Location = new System.Drawing.Point(12, 216);
            this.lbl_movieYear.Name = "lbl_movieYear";
            this.lbl_movieYear.Size = new System.Drawing.Size(62, 15);
            this.lbl_movieYear.TabIndex = 1;
            this.lbl_movieYear.Text = "movieYear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "movieYear";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "movieYear";
            // 
            // UC_movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_movieYear);
            this.Controls.Add(this.pBox_movieImage);
            this.Name = "UC_movie";
            this.Size = new System.Drawing.Size(188, 243);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_movieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBox_movieImage;
        private Label lbl_movieYear;
        private Label label1;
        private Label label2;
    }
}
