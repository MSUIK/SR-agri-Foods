namespace SR
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UserTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserTextbox1
            // 
            this.UserTextbox1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.UserTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.UserTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.UserTextbox1.HintText = "User Name";
            this.UserTextbox1.isPassword = false;
            this.UserTextbox1.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.UserTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.UserTextbox1.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.UserTextbox1.LineThickness = 3;
            this.UserTextbox1.Location = new System.Drawing.Point(86, 149);
            this.UserTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.UserTextbox1.Name = "UserTextbox1";
            this.UserTextbox1.Size = new System.Drawing.Size(177, 32);
            this.UserTextbox1.TabIndex = 1;
            this.UserTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LoginBtn.Location = new System.Drawing.Point(86, 290);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(177, 34);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SR.Properties.Resources.Security_Password_2_icon;
            this.pictureBox2.Location = new System.Drawing.Point(27, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SR.Properties.Resources.admin_icon;
            this.pictureBox1.Location = new System.Drawing.Point(27, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Password
            // 
            this.Password.AllowDrop = true;
            this.Password.BackColor = System.Drawing.Color.SeaGreen;
            this.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Depth = 0;
            this.Password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Password.Hint = "Password";
            this.Password.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Password.Location = new System.Drawing.Point(86, 218);
            this.Password.MaxLength = 32767;
            this.Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.Size = new System.Drawing.Size(177, 23);
            this.Password.TabIndex = 2;
            this.Password.TabStop = false;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(331, 423);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserTextbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Login_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserTextbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Password;
    }
}

