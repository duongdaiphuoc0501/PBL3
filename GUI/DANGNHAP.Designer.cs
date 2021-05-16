
namespace PBL3_Client.GUI
{
    partial class DANGNHAP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.comboBoxMay = new System.Windows.Forms.ComboBox();
            this.textBoxMK = new System.Windows.Forms.TextBox();
            this.textBoxTK = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 97);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 166);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonDangNhap);
            this.panel3.Controls.Add(this.comboBoxMay);
            this.panel3.Controls.Add(this.textBoxMK);
            this.panel3.Controls.Add(this.textBoxTK);
            this.panel3.Location = new System.Drawing.Point(38, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 127);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MÁY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MẬT KHẨU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Location = new System.Drawing.Point(85, 107);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(113, 20);
            this.buttonDangNhap.TabIndex = 3;
            this.buttonDangNhap.Text = "ĐĂNG NHẬP";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // comboBoxMay
            // 
            this.comboBoxMay.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxMay.FormattingEnabled = true;
            this.comboBoxMay.Location = new System.Drawing.Point(85, 9);
            this.comboBoxMay.Name = "comboBoxMay";
            this.comboBoxMay.Size = new System.Drawing.Size(104, 21);
            this.comboBoxMay.TabIndex = 2;
            // 
            // textBoxMK
            // 
            this.textBoxMK.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxMK.Location = new System.Drawing.Point(85, 72);
            this.textBoxMK.Name = "textBoxMK";
            this.textBoxMK.Size = new System.Drawing.Size(220, 20);
            this.textBoxMK.TabIndex = 1;
            // 
            // textBoxTK
            // 
            this.textBoxTK.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxTK.Location = new System.Drawing.Point(85, 47);
            this.textBoxTK.Name = "textBoxTK";
            this.textBoxTK.Size = new System.Drawing.Size(220, 20);
            this.textBoxTK.TabIndex = 0;
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 263);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DANGNHAP";
            this.Text = "DANGNHAP";
            this.TransparencyKey = System.Drawing.Color.White;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxMK;
        private System.Windows.Forms.TextBox textBoxTK;
        private System.Windows.Forms.ComboBox comboBoxMay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDangNhap;
    }
}