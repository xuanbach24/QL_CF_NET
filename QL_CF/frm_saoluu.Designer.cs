namespace QL_CF
{
    partial class frm_saoluu
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_macdinh = new System.Windows.Forms.Button();
            this.btn_xnsaoluu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(124, 187);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(581, 65);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(216, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sao Lưu Dữ Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(117, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đường Dẫn Sao Lưu:";
            // 
            // btn_macdinh
            // 
            this.btn_macdinh.BackColor = System.Drawing.Color.Chocolate;
            this.btn_macdinh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_macdinh.FlatAppearance.BorderSize = 3;
            this.btn_macdinh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_macdinh.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_macdinh.Location = new System.Drawing.Point(145, 304);
            this.btn_macdinh.Name = "btn_macdinh";
            this.btn_macdinh.Size = new System.Drawing.Size(215, 66);
            this.btn_macdinh.TabIndex = 22;
            this.btn_macdinh.Text = "Đường Dẫn Mặc Định";
            this.btn_macdinh.UseVisualStyleBackColor = false;
            this.btn_macdinh.Click += new System.EventHandler(this.btn_macdinh_Click);
            // 
            // btn_xnsaoluu
            // 
            this.btn_xnsaoluu.BackColor = System.Drawing.Color.Chocolate;
            this.btn_xnsaoluu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_xnsaoluu.FlatAppearance.BorderSize = 3;
            this.btn_xnsaoluu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xnsaoluu.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_xnsaoluu.Location = new System.Drawing.Point(459, 304);
            this.btn_xnsaoluu.Name = "btn_xnsaoluu";
            this.btn_xnsaoluu.Size = new System.Drawing.Size(195, 66);
            this.btn_xnsaoluu.TabIndex = 23;
            this.btn_xnsaoluu.Text = "Sao Lưu";
            this.btn_xnsaoluu.UseVisualStyleBackColor = false;
            this.btn_xnsaoluu.Click += new System.EventHandler(this.btn_xnsaoluu_Click);
            // 
            // frm_saoluu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_xnsaoluu);
            this.Controls.Add(this.btn_macdinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frm_saoluu";
            this.Text = "frm_saoluu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_macdinh;
        private System.Windows.Forms.Button btn_xnsaoluu;
    }
}