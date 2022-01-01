
namespace QLTourDuLich.GUI
{
    partial class GUI_ChiTietDoan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.comboGia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.txtMaDoan = new System.Windows.Forms.TextBox();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.comboKhachHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXoa = new ePOSOne.btnProduct.Button_WOC();
            this.btnSua = new ePOSOne.btnProduct.Button_WOC();
            this.btThem = new ePOSOne.btnProduct.Button_WOC();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Location = new System.Drawing.Point(433, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 239);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMaTour);
            this.panel1.Controls.Add(this.comboGia);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnChon);
            this.panel1.Controls.Add(this.txtMaDoan);
            this.panel1.Controls.Add(this.txtVaiTro);
            this.panel1.Controls.Add(this.comboKhachHang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 199);
            this.panel1.TabIndex = 5;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Enabled = false;
            this.txtMaTour.Location = new System.Drawing.Point(430, 29);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(147, 20);
            this.txtMaTour.TabIndex = 10;
            // 
            // comboGia
            // 
            this.comboGia.FormattingEnabled = true;
            this.comboGia.Location = new System.Drawing.Point(430, 79);
            this.comboGia.Name = "comboGia";
            this.comboGia.Size = new System.Drawing.Size(147, 21);
            this.comboGia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(362, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(362, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã Tour";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(268, 79);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(68, 22);
            this.btnChon.TabIndex = 6;
            this.btnChon.Text = "Tùy chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtMaDoan
            // 
            this.txtMaDoan.Enabled = false;
            this.txtMaDoan.Location = new System.Drawing.Point(115, 25);
            this.txtMaDoan.Name = "txtMaDoan";
            this.txtMaDoan.Size = new System.Drawing.Size(147, 20);
            this.txtMaDoan.TabIndex = 5;
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.Location = new System.Drawing.Point(115, 138);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(147, 20);
            this.txtVaiTro.TabIndex = 4;
            // 
            // comboKhachHang
            // 
            this.comboKhachHang.FormattingEnabled = true;
            this.comboKhachHang.Location = new System.Drawing.Point(115, 79);
            this.comboKhachHang.Name = "comboKhachHang";
            this.comboKhachHang.Size = new System.Drawing.Size(147, 21);
            this.comboKhachHang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vai Trò";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Đoàn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 239);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderColor = System.Drawing.Color.Silver;
            this.btnXoa.ButtonColor = System.Drawing.Color.Maroon;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(32, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnXoa.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnXoa.Size = new System.Drawing.Size(106, 47);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderColor = System.Drawing.Color.Silver;
            this.btnSua.ButtonColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(32, 97);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSua.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSua.Size = new System.Drawing.Size(106, 47);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "SỬA";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btThem
            // 
            this.btThem.BorderColor = System.Drawing.Color.Silver;
            this.btThem.ButtonColor = System.Drawing.Color.Green;
            this.btThem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(33, 29);
            this.btThem.Name = "btThem";
            this.btThem.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btThem.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btThem.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btThem.Size = new System.Drawing.Size(106, 47);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "THÊM";
            this.btThem.TextColor = System.Drawing.Color.White;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // GUI_ChiTietDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI_ChiTietDoan";
            this.Text = "GUI_ChiTietDoan";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC btnXoa;
        private ePOSOne.btnProduct.Button_WOC btnSua;
        private ePOSOne.btnProduct.Button_WOC btThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtMaDoan;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.ComboBox comboKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTour;
    }
}