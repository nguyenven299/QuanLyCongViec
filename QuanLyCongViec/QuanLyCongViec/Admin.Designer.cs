namespace QuanLyCongViec
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
            this.QuanLyAdmin = new System.Windows.Forms.TabControl();
            this.TaoCongViec = new System.Windows.Forms.TabPage();
            this.ThemLeader = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTaiKhoan = new System.Windows.Forms.GroupBox();
            this.groupBoxThongTinLeader = new System.Windows.Forms.GroupBox();
            this.groupBoxChucVu = new System.Windows.Forms.GroupBox();
            this.QuanLyAdmin.SuspendLayout();
            this.ThemLeader.SuspendLayout();
            this.groupBoxTaiKhoan.SuspendLayout();
            this.groupBoxThongTinLeader.SuspendLayout();
            this.groupBoxChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuanLyAdmin
            // 
            this.QuanLyAdmin.Controls.Add(this.TaoCongViec);
            this.QuanLyAdmin.Controls.Add(this.ThemLeader);
            this.QuanLyAdmin.Location = new System.Drawing.Point(-2, 0);
            this.QuanLyAdmin.Name = "QuanLyAdmin";
            this.QuanLyAdmin.SelectedIndex = 0;
            this.QuanLyAdmin.Size = new System.Drawing.Size(984, 769);
            this.QuanLyAdmin.TabIndex = 5;
            // 
            // TaoCongViec
            // 
            this.TaoCongViec.BackgroundImage = global::QuanLyCongViec.Properties.Resources.background;
            this.TaoCongViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TaoCongViec.Location = new System.Drawing.Point(4, 22);
            this.TaoCongViec.Name = "TaoCongViec";
            this.TaoCongViec.Padding = new System.Windows.Forms.Padding(3);
            this.TaoCongViec.Size = new System.Drawing.Size(976, 743);
            this.TaoCongViec.TabIndex = 0;
            this.TaoCongViec.Text = "Tạo Công Việc";
            this.TaoCongViec.UseVisualStyleBackColor = true;
            // 
            // ThemLeader
            // 
            this.ThemLeader.BackgroundImage = global::QuanLyCongViec.Properties.Resources.background;
            this.ThemLeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThemLeader.Controls.Add(this.groupBoxChucVu);
            this.ThemLeader.Controls.Add(this.groupBoxThongTinLeader);
            this.ThemLeader.Controls.Add(this.groupBoxTaiKhoan);
            this.ThemLeader.Location = new System.Drawing.Point(4, 22);
            this.ThemLeader.Name = "ThemLeader";
            this.ThemLeader.Padding = new System.Windows.Forms.Padding(3);
            this.ThemLeader.Size = new System.Drawing.Size(976, 743);
            this.ThemLeader.TabIndex = 1;
            this.ThemLeader.Text = "Thêm Leader";
            this.ThemLeader.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Chức Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Chức Vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mật Khẩu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nhập Lại Mật Khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Địa Chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giới Tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ngày Sinh";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 30);
            this.textBox1.TabIndex = 10;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNu.Location = new System.Drawing.Point(12, 156);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(53, 28);
            this.radioButtonNu.TabIndex = 18;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNam.Location = new System.Drawing.Point(102, 156);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(68, 28);
            this.radioButtonNam.TabIndex = 19;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(507, 67);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 30);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 61);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 30);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(507, 61);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 30);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 52);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(432, 30);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(483, 52);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(343, 30);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(483, 122);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(343, 30);
            this.textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 228);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(813, 30);
            this.textBox8.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(507, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 29);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // groupBoxTaiKhoan
            // 
            this.groupBoxTaiKhoan.Controls.Add(this.label5);
            this.groupBoxTaiKhoan.Controls.Add(this.label6);
            this.groupBoxTaiKhoan.Controls.Add(this.textBox5);
            this.groupBoxTaiKhoan.Controls.Add(this.textBox7);
            this.groupBoxTaiKhoan.Controls.Add(this.textBox6);
            this.groupBoxTaiKhoan.Controls.Add(this.label7);
            this.groupBoxTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTaiKhoan.Location = new System.Drawing.Point(22, 17);
            this.groupBoxTaiKhoan.Name = "groupBoxTaiKhoan";
            this.groupBoxTaiKhoan.Size = new System.Drawing.Size(874, 158);
            this.groupBoxTaiKhoan.TabIndex = 28;
            this.groupBoxTaiKhoan.TabStop = false;
            this.groupBoxTaiKhoan.Text = "Tài Khoản";
            // 
            // groupBoxThongTinLeader
            // 
            this.groupBoxThongTinLeader.Controls.Add(this.textBox2);
            this.groupBoxThongTinLeader.Controls.Add(this.label1);
            this.groupBoxThongTinLeader.Controls.Add(this.dateTimePicker1);
            this.groupBoxThongTinLeader.Controls.Add(this.label3);
            this.groupBoxThongTinLeader.Controls.Add(this.textBox8);
            this.groupBoxThongTinLeader.Controls.Add(this.textBox1);
            this.groupBoxThongTinLeader.Controls.Add(this.label10);
            this.groupBoxThongTinLeader.Controls.Add(this.label9);
            this.groupBoxThongTinLeader.Controls.Add(this.radioButtonNu);
            this.groupBoxThongTinLeader.Controls.Add(this.radioButtonNam);
            this.groupBoxThongTinLeader.Controls.Add(this.label8);
            this.groupBoxThongTinLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTinLeader.Location = new System.Drawing.Point(23, 181);
            this.groupBoxThongTinLeader.Name = "groupBoxThongTinLeader";
            this.groupBoxThongTinLeader.Size = new System.Drawing.Size(873, 291);
            this.groupBoxThongTinLeader.TabIndex = 29;
            this.groupBoxThongTinLeader.TabStop = false;
            this.groupBoxThongTinLeader.Text = "Thông Tin Leader";
            // 
            // groupBoxChucVu
            // 
            this.groupBoxChucVu.Controls.Add(this.textBox4);
            this.groupBoxChucVu.Controls.Add(this.label2);
            this.groupBoxChucVu.Controls.Add(this.label4);
            this.groupBoxChucVu.Controls.Add(this.textBox3);
            this.groupBoxChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChucVu.Location = new System.Drawing.Point(22, 478);
            this.groupBoxChucVu.Name = "groupBoxChucVu";
            this.groupBoxChucVu.Size = new System.Drawing.Size(874, 123);
            this.groupBoxChucVu.TabIndex = 30;
            this.groupBoxChucVu.TabStop = false;
            this.groupBoxChucVu.Text = "Chức Vụ";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 766);
            this.Controls.Add(this.QuanLyAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.QuanLyAdmin.ResumeLayout(false);
            this.ThemLeader.ResumeLayout(false);
            this.groupBoxTaiKhoan.ResumeLayout(false);
            this.groupBoxTaiKhoan.PerformLayout();
            this.groupBoxThongTinLeader.ResumeLayout(false);
            this.groupBoxThongTinLeader.PerformLayout();
            this.groupBoxChucVu.ResumeLayout(false);
            this.groupBoxChucVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl QuanLyAdmin;
        private System.Windows.Forms.TabPage TaoCongViec;
        private System.Windows.Forms.TabPage ThemLeader;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBoxTaiKhoan;
        private System.Windows.Forms.GroupBox groupBoxChucVu;
        private System.Windows.Forms.GroupBox groupBoxThongTinLeader;
    }
}