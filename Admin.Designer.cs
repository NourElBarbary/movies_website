
namespace SWE_Project
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.Sign_in_Admin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userSignUp_lb = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.admin_Pass_lb = new System.Windows.Forms.Label();
            this.admin_username_lb = new System.Windows.Forms.Label();
            this.admin_username_txt = new System.Windows.Forms.TextBox();
            this.adminPassword_txt = new System.Windows.Forms.TextBox();
            this.Sign_in_btn_admin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sign_in_Admin
            // 
            this.Sign_in_Admin.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_in_Admin.ForeColor = System.Drawing.Color.White;
            this.Sign_in_Admin.Location = new System.Drawing.Point(3, -2);
            this.Sign_in_Admin.Name = "Sign_in_Admin";
            this.Sign_in_Admin.Size = new System.Drawing.Size(173, 61);
            this.Sign_in_Admin.TabIndex = 14;
            this.Sign_in_Admin.Text = "Admin";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Sign_in_Admin);
            this.panel1.Controls.Add(this.userSignUp_lb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.admin_Pass_lb);
            this.panel1.Controls.Add(this.admin_username_lb);
            this.panel1.Controls.Add(this.admin_username_txt);
            this.panel1.Controls.Add(this.adminPassword_txt);
            this.panel1.Controls.Add(this.Sign_in_btn_admin);
            this.panel1.Location = new System.Drawing.Point(226, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 663);
            this.panel1.TabIndex = 16;
            // 
            // userSignUp_lb
            // 
            this.userSignUp_lb.ActiveLinkColor = System.Drawing.Color.White;
            this.userSignUp_lb.AutoSize = true;
            this.userSignUp_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userSignUp_lb.Font = new System.Drawing.Font("Corbel", 10F);
            this.userSignUp_lb.LinkColor = System.Drawing.Color.White;
            this.userSignUp_lb.Location = new System.Drawing.Point(286, 629);
            this.userSignUp_lb.Name = "userSignUp_lb";
            this.userSignUp_lb.Size = new System.Drawing.Size(121, 21);
            this.userSignUp_lb.TabIndex = 25;
            this.userSignUp_lb.TabStop = true;
            this.userSignUp_lb.Text = "Sign In as a User";
            this.userSignUp_lb.VisitedLinkColor = System.Drawing.Color.Red;
            this.userSignUp_lb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userSignUp_lb_LinkClicked);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(181, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Not Admin ?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(216, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // admin_Pass_lb
            // 
            this.admin_Pass_lb.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.admin_Pass_lb.ForeColor = System.Drawing.Color.White;
            this.admin_Pass_lb.Location = new System.Drawing.Point(85, 399);
            this.admin_Pass_lb.Name = "admin_Pass_lb";
            this.admin_Pass_lb.Size = new System.Drawing.Size(187, 39);
            this.admin_Pass_lb.TabIndex = 22;
            this.admin_Pass_lb.Text = "Password:";
            // 
            // admin_username_lb
            // 
            this.admin_username_lb.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.admin_username_lb.ForeColor = System.Drawing.Color.White;
            this.admin_username_lb.Location = new System.Drawing.Point(78, 278);
            this.admin_username_lb.Name = "admin_username_lb";
            this.admin_username_lb.Size = new System.Drawing.Size(187, 39);
            this.admin_username_lb.TabIndex = 21;
            this.admin_username_lb.Text = "Username:";
            // 
            // admin_username_txt
            // 
            this.admin_username_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.admin_username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.admin_username_txt.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_username_txt.ForeColor = System.Drawing.Color.White;
            this.admin_username_txt.Location = new System.Drawing.Point(83, 338);
            this.admin_username_txt.MaxLength = 300;
            this.admin_username_txt.Multiline = true;
            this.admin_username_txt.Name = "admin_username_txt";
            this.admin_username_txt.Size = new System.Drawing.Size(406, 40);
            this.admin_username_txt.TabIndex = 1;
            this.admin_username_txt.Tag = "";
            // 
            // adminPassword_txt
            // 
            this.adminPassword_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.adminPassword_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminPassword_txt.Font = new System.Drawing.Font("MS UI Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassword_txt.ForeColor = System.Drawing.Color.White;
            this.adminPassword_txt.Location = new System.Drawing.Point(90, 459);
            this.adminPassword_txt.MaxLength = 300;
            this.adminPassword_txt.Multiline = true;
            this.adminPassword_txt.Name = "adminPassword_txt";
            this.adminPassword_txt.PasswordChar = '*';
            this.adminPassword_txt.Size = new System.Drawing.Size(406, 40);
            this.adminPassword_txt.TabIndex = 1;
            this.adminPassword_txt.Tag = "";
            // 
            // Sign_in_btn_admin
            // 
            this.Sign_in_btn_admin.BackColor = System.Drawing.Color.Red;
            this.Sign_in_btn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_in_btn_admin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Sign_in_btn_admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sign_in_btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign_in_btn_admin.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.Sign_in_btn_admin.ForeColor = System.Drawing.Color.White;
            this.Sign_in_btn_admin.Location = new System.Drawing.Point(90, 537);
            this.Sign_in_btn_admin.Name = "Sign_in_btn_admin";
            this.Sign_in_btn_admin.Size = new System.Drawing.Size(406, 54);
            this.Sign_in_btn_admin.TabIndex = 0;
            this.Sign_in_btn_admin.Text = "Sign in";
            this.Sign_in_btn_admin.UseVisualStyleBackColor = false;
            this.Sign_in_btn_admin.Click += new System.EventHandler(this.Sign_in_btn_admin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SWE_Project.Properties.Resources.imdb__3_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1076, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Sign_in_Admin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel userSignUp_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label admin_Pass_lb;
        private System.Windows.Forms.Label admin_username_lb;
        private System.Windows.Forms.TextBox admin_username_txt;
        private System.Windows.Forms.TextBox adminPassword_txt;
        private System.Windows.Forms.Button Sign_in_btn_admin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}