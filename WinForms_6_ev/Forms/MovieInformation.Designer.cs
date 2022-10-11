namespace WinForms_6_ev.Forms
{
    partial class MovieInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.btn_searchMovie = new System.Windows.Forms.Button();
            this.txt_movieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBox_moviePicture = new System.Windows.Forms.PictureBox();
            this.lbl_movieName = new System.Windows.Forms.Label();
            this.lbl_movieGenre = new System.Windows.Forms.Label();
            this.lbl_movieDirector = new System.Windows.Forms.Label();
            this.lbl_movieWriter = new System.Windows.Forms.Label();
            this.lbl_movieActors = new System.Windows.Forms.Label();
            this.lbl_movieAwards = new System.Windows.Forms.Label();
            this.lbl_movieCountry = new System.Windows.Forms.Label();
            this.lbl_movieRating = new System.Windows.Forms.Label();
            this.lbl_movieRuntime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_moviePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btn_goBack);
            this.panel1.Controls.Add(this.btn_searchMovie);
            this.panel1.Controls.Add(this.txt_movieName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 62);
            this.panel1.TabIndex = 1;
            // 
            // btn_goBack
            // 
            this.btn_goBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_goBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_goBack.Location = new System.Drawing.Point(502, 9);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(123, 45);
            this.btn_goBack.TabIndex = 3;
            this.btn_goBack.Text = "Geri Qayit";
            this.btn_goBack.UseVisualStyleBackColor = true;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // btn_searchMovie
            // 
            this.btn_searchMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_searchMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_searchMovie.Location = new System.Drawing.Point(1274, 18);
            this.btn_searchMovie.Name = "btn_searchMovie";
            this.btn_searchMovie.Size = new System.Drawing.Size(135, 29);
            this.btn_searchMovie.TabIndex = 2;
            this.btn_searchMovie.Text = "Film Axtar";
            this.btn_searchMovie.UseVisualStyleBackColor = true;
            // 
            // txt_movieName
            // 
            this.txt_movieName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_movieName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_movieName.Location = new System.Drawing.Point(976, 18);
            this.txt_movieName.Name = "txt_movieName";
            this.txt_movieName.Size = new System.Drawing.Size(292, 29);
            this.txt_movieName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film";
            // 
            // pBox_moviePicture
            // 
            this.pBox_moviePicture.Location = new System.Drawing.Point(12, 78);
            this.pBox_moviePicture.Name = "pBox_moviePicture";
            this.pBox_moviePicture.Size = new System.Drawing.Size(218, 298);
            this.pBox_moviePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_moviePicture.TabIndex = 2;
            this.pBox_moviePicture.TabStop = false;
            // 
            // lbl_movieName
            // 
            this.lbl_movieName.AutoSize = true;
            this.lbl_movieName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieName.ForeColor = System.Drawing.Color.Gold;
            this.lbl_movieName.Location = new System.Drawing.Point(236, 78);
            this.lbl_movieName.Name = "lbl_movieName";
            this.lbl_movieName.Size = new System.Drawing.Size(131, 30);
            this.lbl_movieName.TabIndex = 3;
            this.lbl_movieName.Text = "movieName";
            // 
            // lbl_movieGenre
            // 
            this.lbl_movieGenre.AutoSize = true;
            this.lbl_movieGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieGenre.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_movieGenre.Location = new System.Drawing.Point(236, 118);
            this.lbl_movieGenre.Name = "lbl_movieGenre";
            this.lbl_movieGenre.Size = new System.Drawing.Size(103, 21);
            this.lbl_movieGenre.TabIndex = 4;
            this.lbl_movieGenre.Text = "movieGenre";
            // 
            // lbl_movieDirector
            // 
            this.lbl_movieDirector.AutoSize = true;
            this.lbl_movieDirector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieDirector.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_movieDirector.Location = new System.Drawing.Point(236, 149);
            this.lbl_movieDirector.Name = "lbl_movieDirector";
            this.lbl_movieDirector.Size = new System.Drawing.Size(120, 21);
            this.lbl_movieDirector.TabIndex = 5;
            this.lbl_movieDirector.Text = "movieDirector";
            // 
            // lbl_movieWriter
            // 
            this.lbl_movieWriter.AutoSize = true;
            this.lbl_movieWriter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieWriter.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_movieWriter.Location = new System.Drawing.Point(236, 180);
            this.lbl_movieWriter.Name = "lbl_movieWriter";
            this.lbl_movieWriter.Size = new System.Drawing.Size(106, 21);
            this.lbl_movieWriter.TabIndex = 6;
            this.lbl_movieWriter.Text = "movieWriter";
            // 
            // lbl_movieActors
            // 
            this.lbl_movieActors.AutoSize = true;
            this.lbl_movieActors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieActors.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_movieActors.Location = new System.Drawing.Point(236, 211);
            this.lbl_movieActors.Name = "lbl_movieActors";
            this.lbl_movieActors.Size = new System.Drawing.Size(106, 21);
            this.lbl_movieActors.TabIndex = 7;
            this.lbl_movieActors.Text = "movieActors";
            // 
            // lbl_movieAwards
            // 
            this.lbl_movieAwards.AutoSize = true;
            this.lbl_movieAwards.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieAwards.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_movieAwards.Location = new System.Drawing.Point(236, 273);
            this.lbl_movieAwards.Name = "lbl_movieAwards";
            this.lbl_movieAwards.Size = new System.Drawing.Size(114, 21);
            this.lbl_movieAwards.TabIndex = 8;
            this.lbl_movieAwards.Text = "movieAwards";
            // 
            // lbl_movieCountry
            // 
            this.lbl_movieCountry.AutoSize = true;
            this.lbl_movieCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieCountry.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_movieCountry.Location = new System.Drawing.Point(236, 242);
            this.lbl_movieCountry.Name = "lbl_movieCountry";
            this.lbl_movieCountry.Size = new System.Drawing.Size(120, 21);
            this.lbl_movieCountry.TabIndex = 9;
            this.lbl_movieCountry.Text = "movieCountry";
            // 
            // lbl_movieRating
            // 
            this.lbl_movieRating.AutoSize = true;
            this.lbl_movieRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieRating.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_movieRating.Location = new System.Drawing.Point(236, 304);
            this.lbl_movieRating.Name = "lbl_movieRating";
            this.lbl_movieRating.Size = new System.Drawing.Size(108, 21);
            this.lbl_movieRating.TabIndex = 10;
            this.lbl_movieRating.Text = "movieRating";
            // 
            // lbl_movieRuntime
            // 
            this.lbl_movieRuntime.AutoSize = true;
            this.lbl_movieRuntime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_movieRuntime.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_movieRuntime.Location = new System.Drawing.Point(236, 335);
            this.lbl_movieRuntime.Name = "lbl_movieRuntime";
            this.lbl_movieRuntime.Size = new System.Drawing.Size(123, 21);
            this.lbl_movieRuntime.TabIndex = 11;
            this.lbl_movieRuntime.Text = "movieRuntime";
            // 
            // MovieInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 386);
            this.Controls.Add(this.lbl_movieRuntime);
            this.Controls.Add(this.lbl_movieRating);
            this.Controls.Add(this.lbl_movieCountry);
            this.Controls.Add(this.lbl_movieAwards);
            this.Controls.Add(this.lbl_movieActors);
            this.Controls.Add(this.lbl_movieWriter);
            this.Controls.Add(this.lbl_movieDirector);
            this.Controls.Add(this.lbl_movieGenre);
            this.Controls.Add(this.lbl_movieName);
            this.Controls.Add(this.pBox_moviePicture);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(653, 425);
            this.MinimumSize = new System.Drawing.Size(653, 425);
            this.Name = "MovieInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieInformation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_moviePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btn_searchMovie;
        private TextBox txt_movieName;
        private Label label1;
        private Button btn_goBack;
        private PictureBox pBox_moviePicture;
        private Label lbl_movieName;
        private Label lbl_movieGenre;
        private Label lbl_movieDirector;
        private Label lbl_movieWriter;
        private Label lbl_movieActors;
        private Label lbl_movieAwards;
        private Label lbl_movieCountry;
        private Label lbl_movieRating;
        private Label lbl_movieRuntime;
    }
}