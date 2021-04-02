namespace GiaoDien
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.buttom_in_User = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topdashboard_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttom_in_User
            // 
            this.buttom_in_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttom_in_User.BackColor = System.Drawing.Color.CadetBlue;
            this.buttom_in_User.FlatAppearance.BorderSize = 0;
            this.buttom_in_User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttom_in_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttom_in_User.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttom_in_User.ForeColor = System.Drawing.Color.White;
            this.buttom_in_User.Location = new System.Drawing.Point(887, 204);
            this.buttom_in_User.Name = "buttom_in_User";
            this.buttom_in_User.Size = new System.Drawing.Size(286, 62);
            this.buttom_in_User.TabIndex = 1;
            this.buttom_in_User.Text = "Users List";
            this.buttom_in_User.UseVisualStyleBackColor = false;
            this.buttom_in_User.Click += new System.EventHandler(this.buttom_in_User_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // topdashboard_text
            // 
            this.topdashboard_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.topdashboard_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topdashboard_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.topdashboard_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topdashboard_text.ForeColor = System.Drawing.SystemColors.Window;
            this.topdashboard_text.Location = new System.Drawing.Point(0, 0);
            this.topdashboard_text.Name = "topdashboard_text";
            this.topdashboard_text.Size = new System.Drawing.Size(1350, 49);
            this.topdashboard_text.TabIndex = 4;
            this.topdashboard_text.Text = "Users Management";
            this.topdashboard_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 524);
            this.Controls.Add(this.topdashboard_text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttom_in_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttom_in_User;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox topdashboard_text;
    }
}