namespace QL_CF
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dangnhap = new Guna.UI.WinForms.GunaButton();
            this.txt_user = new Guna.UI.WinForms.GunaTextBox();
            this.txt_pass = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(534, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(534, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.AnimationHoverSpeed = 0.07F;
            this.btn_dangnhap.AnimationSpeed = 0.03F;
            this.btn_dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_dangnhap.BaseColor = System.Drawing.Color.LightSalmon;
            this.btn_dangnhap.BorderColor = System.Drawing.Color.Black;
            this.btn_dangnhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dangnhap.FocusedColor = System.Drawing.Color.Empty;
            this.btn_dangnhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.Peru;
            this.btn_dangnhap.Image = null;
            this.btn_dangnhap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dangnhap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_dangnhap.Location = new System.Drawing.Point(604, 344);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.OnHoverBaseColor = System.Drawing.Color.Salmon;
            this.btn_dangnhap.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btn_dangnhap.OnHoverForeColor = System.Drawing.Color.Chocolate;
            this.btn_dangnhap.OnHoverImage = null;
            this.btn_dangnhap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_dangnhap.Radius = 20;
            this.btn_dangnhap.Size = new System.Drawing.Size(220, 50);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "ĐĂNG NHẬP";
            this.btn_dangnhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.Transparent;
            this.txt_user.BaseColor = System.Drawing.Color.Linen;
            this.txt_user.BorderColor = System.Drawing.Color.Silver;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_user.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_user.ForeColor = System.Drawing.Color.Chocolate;
            this.txt_user.Location = new System.Drawing.Point(639, 177);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.Radius = 15;
            this.txt_user.SelectedText = "";
            this.txt_user.Size = new System.Drawing.Size(226, 40);
            this.txt_user.TabIndex = 6;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_pass.BaseColor = System.Drawing.Color.Linen;
            this.txt_pass.BorderColor = System.Drawing.Color.Silver;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pass.ForeColor = System.Drawing.Color.Chocolate;
            this.txt_pass.Location = new System.Drawing.Point(639, 243);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Radius = 15;
            this.txt_pass.SelectedText = "";
            this.txt_pass.Size = new System.Drawing.Size(226, 40);
            this.txt_pass.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(586, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 43);
            this.label3.TabIndex = 9;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Enabled = false;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(519, 467);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 10;
            this.gunaPictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(-4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(506, 52);
            this.label4.TabIndex = 11;
            this.label4.Text = "QUẢN LÝ QUÁN CAFE";
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(875, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhap";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btn_dangnhap;
        private Guna.UI.WinForms.GunaTextBox txt_user;
        private Guna.UI.WinForms.GunaTextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label4;
    }
}