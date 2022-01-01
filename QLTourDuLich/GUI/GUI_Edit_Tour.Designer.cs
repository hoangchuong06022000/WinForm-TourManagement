
namespace QLTourDuLich.GUI
{
    partial class GUI_Edit_Tour
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
            this.txtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.comboMaTour = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnChonLoaiHinh = new System.Windows.Forms.Button();
            this.txtDacDiem = new System.Windows.Forms.TextBox();
            this.txtTenGoi = new System.Windows.Forms.TextBox();
            this.comboLoaiHinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaGia = new ePOSOne.btnProduct.Button_WOC();
            this.btnSuaTour = new ePOSOne.btnProduct.Button_WOC();
            this.btnThem = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnSuaGia);
            this.panel1.Controls.Add(this.btnSuaTour);
            this.panel1.Controls.Add(this.txtNgayKetThuc);
            this.panel1.Controls.Add(this.txtNgayBatDau);
            this.panel1.Controls.Add(this.comboMaTour);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtGiaTien);
            this.panel1.Controls.Add(this.btnChonLoaiHinh);
            this.panel1.Controls.Add(this.txtDacDiem);
            this.panel1.Controls.Add(this.txtTenGoi);
            this.panel1.Controls.Add(this.comboLoaiHinh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 296);
            this.panel1.TabIndex = 0;
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.CustomFormat = "dd-MM-yyyy";
            this.txtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayKetThuc.Location = new System.Drawing.Point(588, 149);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(100, 20);
            this.txtNgayKetThuc.TabIndex = 33;
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.CustomFormat = "dd-MM-yyyy";
            this.txtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayBatDau.Location = new System.Drawing.Point(347, 150);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(100, 20);
            this.txtNgayBatDau.TabIndex = 32;
            // 
            // comboMaTour
            // 
            this.comboMaTour.FormattingEnabled = true;
            this.comboMaTour.Location = new System.Drawing.Point(152, 18);
            this.comboMaTour.Name = "comboMaTour";
            this.comboMaTour.Size = new System.Drawing.Size(159, 21);
            this.comboMaTour.TabIndex = 30;
            this.comboMaTour.SelectedIndexChanged += new System.EventHandler(this.comboMaTour_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(489, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kết Thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bắt Đầu";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(112, 150);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(99, 20);
            this.txtGiaTien.TabIndex = 13;
            // 
            // btnChonLoaiHinh
            // 
            this.btnChonLoaiHinh.Location = new System.Drawing.Point(676, 79);
            this.btnChonLoaiHinh.Name = "btnChonLoaiHinh";
            this.btnChonLoaiHinh.Size = new System.Drawing.Size(75, 23);
            this.btnChonLoaiHinh.TabIndex = 11;
            this.btnChonLoaiHinh.Text = "Tùy Chọn";
            this.btnChonLoaiHinh.UseVisualStyleBackColor = true;
            this.btnChonLoaiHinh.Click += new System.EventHandler(this.btnChonLoaiHinh_Click);
            // 
            // txtDacDiem
            // 
            this.txtDacDiem.Location = new System.Drawing.Point(152, 81);
            this.txtDacDiem.Name = "txtDacDiem";
            this.txtDacDiem.Size = new System.Drawing.Size(159, 20);
            this.txtDacDiem.TabIndex = 10;
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.Location = new System.Drawing.Point(493, 18);
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(159, 20);
            this.txtTenGoi.TabIndex = 8;
            // 
            // comboLoaiHinh
            // 
            this.comboLoaiHinh.FormattingEnabled = true;
            this.comboLoaiHinh.Location = new System.Drawing.Point(493, 81);
            this.comboLoaiHinh.Name = "comboLoaiHinh";
            this.comboLoaiHinh.Size = new System.Drawing.Size(159, 21);
            this.comboLoaiHinh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại Hình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đặc Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Gọi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Giá Tour";
            // 
            // btnSuaGia
            // 
            this.btnSuaGia.BackColor = System.Drawing.Color.White;
            this.btnSuaGia.BorderColor = System.Drawing.Color.Silver;
            this.btnSuaGia.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.btnSuaGia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSuaGia.FlatAppearance.BorderSize = 0;
            this.btnSuaGia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSuaGia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSuaGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuaGia.Location = new System.Drawing.Point(342, 224);
            this.btnSuaGia.Name = "btnSuaGia";
            this.btnSuaGia.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSuaGia.OnHoverButtonColor = System.Drawing.Color.LightYellow;
            this.btnSuaGia.OnHoverTextColor = System.Drawing.Color.YellowGreen;
            this.btnSuaGia.Size = new System.Drawing.Size(105, 51);
            this.btnSuaGia.TabIndex = 35;
            this.btnSuaGia.Text = "OK";
            this.btnSuaGia.TextColor = System.Drawing.Color.White;
            this.btnSuaGia.UseVisualStyleBackColor = false;
            this.btnSuaGia.Visible = false;
            this.btnSuaGia.Click += new System.EventHandler(this.btnSuaGia_Click);
            // 
            // btnSuaTour
            // 
            this.btnSuaTour.BackColor = System.Drawing.Color.White;
            this.btnSuaTour.BorderColor = System.Drawing.Color.Silver;
            this.btnSuaTour.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.btnSuaTour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSuaTour.FlatAppearance.BorderSize = 0;
            this.btnSuaTour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSuaTour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSuaTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuaTour.Location = new System.Drawing.Point(342, 224);
            this.btnSuaTour.Name = "btnSuaTour";
            this.btnSuaTour.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSuaTour.OnHoverButtonColor = System.Drawing.Color.LightYellow;
            this.btnSuaTour.OnHoverTextColor = System.Drawing.Color.YellowGreen;
            this.btnSuaTour.Size = new System.Drawing.Size(105, 51);
            this.btnSuaTour.TabIndex = 34;
            this.btnSuaTour.Text = "OK";
            this.btnSuaTour.TextColor = System.Drawing.Color.White;
            this.btnSuaTour.UseVisualStyleBackColor = false;
            this.btnSuaTour.Visible = false;
            this.btnSuaTour.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BorderColor = System.Drawing.Color.Silver;
            this.btnThem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(342, 224);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnThem.OnHoverButtonColor = System.Drawing.Color.LightYellow;
            this.btnThem.OnHoverTextColor = System.Drawing.Color.YellowGreen;
            this.btnThem.Size = new System.Drawing.Size(105, 51);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Visible = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // GUI_Edit_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 317);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_Edit_Tour";
            this.Text = "GUI_Edit_QLTour";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnChonLoaiHinh;
        private System.Windows.Forms.TextBox txtDacDiem;
        private System.Windows.Forms.TextBox txtTenGoi;
        private System.Windows.Forms.ComboBox comboLoaiHinh;
        private System.Windows.Forms.Label label5;
        private ePOSOne.btnProduct.Button_WOC btnThem;
        private System.Windows.Forms.ComboBox comboMaTour;
        private System.Windows.Forms.DateTimePicker txtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker txtNgayBatDau;
        private ePOSOne.btnProduct.Button_WOC btnSuaTour;
        private ePOSOne.btnProduct.Button_WOC btnSuaGia;
    }
}