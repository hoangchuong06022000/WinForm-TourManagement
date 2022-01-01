
namespace QLTourDuLich.GUI
{
    partial class GUI_PhanBoNhanVien
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
            this.txtMaDoan = new System.Windows.Forms.TextBox();
            this.txtNhiemVu = new System.Windows.Forms.TextBox();
            this.comboNhanVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new ePOSOne.btnProduct.Button_WOC();
            this.btnSua = new ePOSOne.btnProduct.Button_WOC();
            this.btnThem = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMaDoan);
            this.panel1.Controls.Add(this.txtNhiemVu);
            this.panel1.Controls.Add(this.comboNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 199);
            this.panel1.TabIndex = 4;
            // 
            // txtMaDoan
            // 
            this.txtMaDoan.Enabled = false;
            this.txtMaDoan.Location = new System.Drawing.Point(235, 24);
            this.txtMaDoan.Name = "txtMaDoan";
            this.txtMaDoan.Size = new System.Drawing.Size(147, 20);
            this.txtMaDoan.TabIndex = 5;
            // 
            // txtNhiemVu
            // 
            this.txtNhiemVu.Location = new System.Drawing.Point(235, 137);
            this.txtNhiemVu.Name = "txtNhiemVu";
            this.txtNhiemVu.Size = new System.Drawing.Size(147, 20);
            this.txtNhiemVu.TabIndex = 4;
            // 
            // comboNhanVien
            // 
            this.comboNhanVien.FormattingEnabled = true;
            this.comboNhanVien.Location = new System.Drawing.Point(235, 78);
            this.comboNhanVien.Name = "comboNhanVien";
            this.comboNhanVien.Size = new System.Drawing.Size(147, 21);
            this.comboNhanVien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(115, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhiệm Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(115, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(115, 24);
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
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(435, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 239);
            this.panel2.TabIndex = 9;
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
            // btnThem
            // 
            this.btnThem.BorderColor = System.Drawing.Color.Silver;
            this.btnThem.ButtonColor = System.Drawing.Color.Green;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(33, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnThem.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnThem.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnThem.Size = new System.Drawing.Size(106, 47);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // GUI_PhanBoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_PhanBoNhanVien";
            this.Text = "Phân Bổ Nhân Viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaDoan;
        private System.Windows.Forms.TextBox txtNhiemVu;
        private System.Windows.Forms.ComboBox comboNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC btnXoa;
        private ePOSOne.btnProduct.Button_WOC btnSua;
        private ePOSOne.btnProduct.Button_WOC btnThem;
    }
}