
namespace SWE_Project
{
    partial class Trailer1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trailer1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddToWatchlist_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imdb_rate_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ratings = new System.Windows.Forms.Label();
            this.pb_str5 = new System.Windows.Forms.PictureBox();
            this.pb_str4 = new System.Windows.Forms.PictureBox();
            this.pb_str3 = new System.Windows.Forms.PictureBox();
            this.pb_str2 = new System.Windows.Forms.PictureBox();
            this.pb_str1 = new System.Windows.Forms.PictureBox();
            this.Rating_lbl = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.AddToWatchlist_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.imdb_rate_lb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_ratings);
            this.panel1.Controls.Add(this.pb_str5);
            this.panel1.Controls.Add(this.pb_str4);
            this.panel1.Controls.Add(this.pb_str3);
            this.panel1.Controls.Add(this.pb_str2);
            this.panel1.Controls.Add(this.pb_str1);
            this.panel1.Controls.Add(this.Rating_lbl);
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(246, 753);
            this.panel1.TabIndex = 0;
            // 
            // AddToWatchlist_btn
            // 
            this.AddToWatchlist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.AddToWatchlist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddToWatchlist_btn.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.AddToWatchlist_btn.ForeColor = System.Drawing.Color.White;
            this.AddToWatchlist_btn.Location = new System.Drawing.Point(7, 582);
            this.AddToWatchlist_btn.Name = "AddToWatchlist_btn";
            this.AddToWatchlist_btn.Size = new System.Drawing.Size(233, 88);
            this.AddToWatchlist_btn.TabIndex = 28;
            this.AddToWatchlist_btn.Text = "Add To Watchlist";
            this.AddToWatchlist_btn.UseVisualStyleBackColor = false;
            this.AddToWatchlist_btn.Click += new System.EventHandler(this.AddToWatchlist_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(49, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add Rate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imdb_rate_lb
            // 
            this.imdb_rate_lb.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.imdb_rate_lb.ForeColor = System.Drawing.Color.White;
            this.imdb_rate_lb.Location = new System.Drawing.Point(-1, 480);
            this.imdb_rate_lb.Name = "imdb_rate_lb";
            this.imdb_rate_lb.Size = new System.Drawing.Size(336, 41);
            this.imdb_rate_lb.TabIndex = 27;
            this.imdb_rate_lb.Text = "IMDb Rate:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SWE_Project.Properties.Resources.imdb__3_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ratings
            // 
            this.lbl_ratings.AutoSize = true;
            this.lbl_ratings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ratings.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_ratings.ForeColor = System.Drawing.Color.White;
            this.lbl_ratings.Location = new System.Drawing.Point(118, 300);
            this.lbl_ratings.Name = "lbl_ratings";
            this.lbl_ratings.Size = new System.Drawing.Size(0, 35);
            this.lbl_ratings.TabIndex = 25;
            // 
            // pb_str5
            // 
            this.pb_str5.Image = global::SWE_Project.Properties.Resources.white;
            this.pb_str5.Location = new System.Drawing.Point(173, 231);
            this.pb_str5.Name = "pb_str5";
            this.pb_str5.Size = new System.Drawing.Size(26, 26);
            this.pb_str5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_str5.TabIndex = 23;
            this.pb_str5.TabStop = false;
            this.pb_str5.Click += new System.EventHandler(this.pb_str5_Click);
            // 
            // pb_str4
            // 
            this.pb_str4.Image = global::SWE_Project.Properties.Resources.white;
            this.pb_str4.Location = new System.Drawing.Point(138, 231);
            this.pb_str4.Name = "pb_str4";
            this.pb_str4.Size = new System.Drawing.Size(26, 26);
            this.pb_str4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_str4.TabIndex = 22;
            this.pb_str4.TabStop = false;
            this.pb_str4.Click += new System.EventHandler(this.pb_str4_Click);
            // 
            // pb_str3
            // 
            this.pb_str3.Image = global::SWE_Project.Properties.Resources.white;
            this.pb_str3.Location = new System.Drawing.Point(99, 231);
            this.pb_str3.Name = "pb_str3";
            this.pb_str3.Size = new System.Drawing.Size(26, 26);
            this.pb_str3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_str3.TabIndex = 21;
            this.pb_str3.TabStop = false;
            this.pb_str3.Click += new System.EventHandler(this.pb_str3_Click);
            // 
            // pb_str2
            // 
            this.pb_str2.Image = global::SWE_Project.Properties.Resources.white;
            this.pb_str2.Location = new System.Drawing.Point(61, 231);
            this.pb_str2.Name = "pb_str2";
            this.pb_str2.Size = new System.Drawing.Size(26, 26);
            this.pb_str2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_str2.TabIndex = 20;
            this.pb_str2.TabStop = false;
            this.pb_str2.Click += new System.EventHandler(this.pb_str2_Click);
            // 
            // pb_str1
            // 
            this.pb_str1.Image = global::SWE_Project.Properties.Resources.white;
            this.pb_str1.Location = new System.Drawing.Point(23, 231);
            this.pb_str1.Name = "pb_str1";
            this.pb_str1.Size = new System.Drawing.Size(26, 26);
            this.pb_str1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_str1.TabIndex = 19;
            this.pb_str1.TabStop = false;
            this.pb_str1.Click += new System.EventHandler(this.pb_str1_Click);
            // 
            // Rating_lbl
            // 
            this.Rating_lbl.AutoSize = true;
            this.Rating_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Rating_lbl.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.Rating_lbl.ForeColor = System.Drawing.Color.White;
            this.Rating_lbl.Location = new System.Drawing.Point(6, 158);
            this.Rating_lbl.Name = "Rating_lbl";
            this.Rating_lbl.Size = new System.Drawing.Size(179, 35);
            this.Rating_lbl.TabIndex = 18;
            this.Rating_lbl.Text = "Movie Rating:";
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Location = new System.Drawing.Point(6, 694);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(233, 59);
            this.Exit_btn.TabIndex = 17;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(3, 3);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Padding = new System.Windows.Forms.Padding(3);
            this.wmp.Size = new System.Drawing.Size(1061, 383);
            this.wmp.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.wmp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(252, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(1067, 753);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 524);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(1061, 226);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discreption : A pragmatic paleontologist visiting an almost complete theme park i" +
    "s tasked with protecting a couple of kids after a power failure causes the parks" +
    " cloned dinosaurs to run loose.";
            // 
            // Trailer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1319, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Trailer1";
            this.Text = "Trailer1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label Rating_lbl;
        private System.Windows.Forms.PictureBox pb_str1;
        private System.Windows.Forms.PictureBox pb_str5;
        private System.Windows.Forms.PictureBox pb_str4;
        private System.Windows.Forms.PictureBox pb_str3;
        private System.Windows.Forms.PictureBox pb_str2;
        private System.Windows.Forms.Label lbl_ratings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label imdb_rate_lb;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddToWatchlist_btn;
        private System.Windows.Forms.Label label1;
    }
}