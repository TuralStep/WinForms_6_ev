namespace WinForms_6_ev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_movieName = new System.Windows.Forms.TextBox();
            this.btn_searchMovie = new System.Windows.Forms.Button();
            this.pnl_movies = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btn_searchMovie);
            this.panel1.Controls.Add(this.txt_movieName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filmler";
            // 
            // txt_movieName
            // 
            this.txt_movieName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_movieName.Location = new System.Drawing.Point(355, 18);
            this.txt_movieName.Name = "txt_movieName";
            this.txt_movieName.Size = new System.Drawing.Size(292, 29);
            this.txt_movieName.TabIndex = 1;
            // 
            // btn_searchMovie
            // 
            this.btn_searchMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_searchMovie.Location = new System.Drawing.Point(653, 18);
            this.btn_searchMovie.Name = "btn_searchMovie";
            this.btn_searchMovie.Size = new System.Drawing.Size(135, 29);
            this.btn_searchMovie.TabIndex = 2;
            this.btn_searchMovie.Text = "Film Axtar";
            this.btn_searchMovie.UseVisualStyleBackColor = true;
            // 
            // pnl_movies
            // 
            this.pnl_movies.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_movies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_movies.Location = new System.Drawing.Point(0, 62);
            this.pnl_movies.Name = "pnl_movies";
            this.pnl_movies.Size = new System.Drawing.Size(800, 388);
            this.pnl_movies.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_movies);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FullHD Filmizlesene";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_searchMovie;
        private TextBox txt_movieName;
        private Label label1;
        private FlowLayoutPanel pnl_movies;
    }
}