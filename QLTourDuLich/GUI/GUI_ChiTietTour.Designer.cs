
namespace QLTourDuLich.GUI
{
    partial class GUI_ChiTietTour
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btThem = new ePOSOne.btnProduct.Button_WOC();
            this.btnSua = new ePOSOne.btnProduct.Button_WOC();
            this.btnXoa = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDiaDiem = new System.Windows.Forms.ComboBox();
            this.txtThuTu = new System.Windows.Forms.TextBox();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 239);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtMaTour);
            this.panel1.Controls.Add(this.txtThuTu);
            this.panel1.Controls.Add(this.comboDiaDiem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 199);
            this.panel1.TabIndex = 2;
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
            this.panel2.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(115, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(115, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(115, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thứ tự";
            // 
            // comboDiaDiem
            // 
            this.comboDiaDiem.FormattingEnabled = true;
            this.comboDiaDiem.Location = new System.Drawing.Point(235, 78);
            this.comboDiaDiem.Name = "comboDiaDiem";
            this.comboDiaDiem.Size = new System.Drawing.Size(147, 21);
            this.comboDiaDiem.TabIndex = 3;
            // 
            // txtThuTu
            // 
            this.txtThuTu.Location = new System.Drawing.Point(235, 137);
            this.txtThuTu.Name = "txtThuTu";
            this.txtThuTu.Size = new System.Drawing.Size(147, 20);
            this.txtThuTu.TabIndex = 4;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Enabled = false;
            this.txtMaTour.Location = new System.Drawing.Point(235, 24);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(147, 20);
            this.txtMaTour.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tùy chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_ChiTietTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI_ChiTietTour";
            this.Text = "Chi tiết Tour";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC btThem;
        private ePOSOne.btnProduct.Button_WOC btnXoa;
        private ePOSOne.btnProduct.Button_WOC btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.TextBox txtThuTu;
        private System.Windows.Forms.ComboBox comboDiaDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}