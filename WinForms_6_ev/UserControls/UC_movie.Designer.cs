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
            this.lbl_movieType = new System.Windows.Forms.Label();
            this.lbl_movieName = new System.Windows.Forms.Label();
            this.lbl_rank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_movieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_movieImage
            // 
            this.pBox_movieImage.Location = new System.Drawing.Point(3, 3);
            this.pBox_movieImage.Name = "pBox_movieImage";
            this.pBox_movieImage.Size = new System.Drawing.Size(182, 237);
            this.pBox_movieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_movieImage.TabIndex = 0;
            this.pBox_movieImage.TabStop = false;
            this.pBox_movieImage.Click += new System.EventHandler(this.UC_movie_Click);
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
            this.lbl_movieYear.Click += new System.EventHandler(this.UC_movie_Click);
            // 
            // lbl_movieType
            // 
            this.lbl_movieType.AutoSize = true;
            this.lbl_movieType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_movieType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieType.ForeColor = System.Drawing.Color.Gold;
            this.lbl_movieType.Location = new System.Drawing.Point(12, 198);
            this.lbl_movieType.Name = "lbl_movieType";
            this.lbl_movieType.Size = new System.Drawing.Size(73, 17);
            this.lbl_movieType.TabIndex = 2;
            this.lbl_movieType.Text = "movieType";
            this.lbl_movieType.Click += new System.EventHandler(this.UC_movie_Click);
            // 
            // lbl_movieName
            // 
            this.lbl_movieName.AutoSize = true;
            this.lbl_movieName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_movieName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_movieName.Location = new System.Drawing.Point(12, 179);
            this.lbl_movieName.Name = "lbl_movieName";
            this.lbl_movieName.Size = new System.Drawing.Size(94, 20);
            this.lbl_movieName.TabIndex = 3;
            this.lbl_movieName.Text = "movieName";
            this.lbl_movieName.Click += new System.EventHandler(this.UC_movie_Click);
            // 
            // lbl_rank
            // 
            this.lbl_rank.AutoSize = true;
            this.lbl_rank.BackColor = System.Drawing.Color.Gold;
            this.lbl_rank.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_rank.ForeColor = System.Drawing.Color.White;
            this.lbl_rank.Location = new System.Drawing.Point(148, 11);
            this.lbl_rank.Name = "lbl_rank";
            this.lbl_rank.Size = new System.Drawing.Size(25, 17);
            this.lbl_rank.TabIndex = 5;
            this.lbl_rank.Text = "5.0";
            this.lbl_rank.Click += new System.EventHandler(this.UC_movie_Click);
            // 
            // UC_movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbl_rank);
            this.Controls.Add(this.lbl_movieName);
            this.Controls.Add(this.lbl_movieType);
            this.Controls.Add(this.lbl_movieYear);
            this.Controls.Add(this.pBox_movieImage);
            this.Name = "UC_movie";
            this.Size = new System.Drawing.Size(188, 243);
            this.Click += new System.EventHandler(this.UC_movie_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_movieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBox_movieImage;
        private Label lbl_movieYear;
        private Label lbl_movieType;
        private Label lbl_movieName;
        private Label lbl_rank;
    }
}
