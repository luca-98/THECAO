namespace THECAOTOOL {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cbiValue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbiName = new System.Windows.Forms.TextBox();
            this.tbiID = new System.Windows.Forms.TextBox();
            this.tbiSeri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.diDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MENHGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANGSANXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbeValue = new System.Windows.Forms.ComboBox();
            this.rImport = new System.Windows.Forms.RadioButton();
            this.rExport = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbeName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbeStatus = new System.Windows.Forms.ComboBox();
            this.cbeManufacturer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbiManufacturer = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbiStatus = new System.Windows.Forms.ComboBox();
            this.cName = new System.Windows.Forms.CheckBox();
            this.cValue = new System.Windows.Forms.CheckBox();
            this.cHangSanXuat = new System.Windows.Forms.CheckBox();
            this.cStatus = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbiValue
            // 
            this.cbiValue.DisplayMember = "ID";
            this.cbiValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbiValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbiValue.Location = new System.Drawing.Point(127, 144);
            this.cbiValue.Name = "cbiValue";
            this.cbiValue.Size = new System.Drawing.Size(192, 21);
            this.cbiValue.TabIndex = 0;
            this.cbiValue.ValueMember = "ID";
            this.cbiValue.SelectedIndexChanged += new System.EventHandler(this.CbiValue_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Người Bán :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Thẻ :";
            // 
            // tbiName
            // 
            this.tbiName.Location = new System.Drawing.Point(127, 27);
            this.tbiName.MaxLength = 50;
            this.tbiName.Name = "tbiName";
            this.tbiName.Size = new System.Drawing.Size(192, 20);
            this.tbiName.TabIndex = 3;
            // 
            // tbiID
            // 
            this.tbiID.Location = new System.Drawing.Point(127, 66);
            this.tbiID.MaxLength = 15;
            this.tbiID.Name = "tbiID";
            this.tbiID.Size = new System.Drawing.Size(192, 20);
            this.tbiID.TabIndex = 4;
            // 
            // tbiSeri
            // 
            this.tbiSeri.Location = new System.Drawing.Point(127, 107);
            this.tbiSeri.MaxLength = 14;
            this.tbiSeri.Name = "tbiSeri";
            this.tbiSeri.Size = new System.Drawing.Size(192, 20);
            this.tbiSeri.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seri Thẻ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mệnh Giá Thẻ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày Nhập :";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // diDate
            // 
            this.diDate.Location = new System.Drawing.Point(127, 254);
            this.diDate.Name = "diDate";
            this.diDate.Size = new System.Drawing.Size(192, 20);
            this.diDate.TabIndex = 9;
            this.diDate.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.ID,
            this.SERI,
            this.MENHGIA,
            this.HANGSANXUAT,
            this.NGAYNHAP,
            this.TRANGTHAI});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(347, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(853, 558);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Người Bán";
            this.NAME.MaxInputLength = 50;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã Thẻ";
            this.ID.MaxInputLength = 15;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // SERI
            // 
            this.SERI.DataPropertyName = "SERI";
            this.SERI.HeaderText = "Seri";
            this.SERI.MaxInputLength = 14;
            this.SERI.Name = "SERI";
            this.SERI.ReadOnly = true;
            this.SERI.Width = 150;
            // 
            // MENHGIA
            // 
            this.MENHGIA.DataPropertyName = "NAME2";
            this.MENHGIA.HeaderText = "Mệnh Giá";
            this.MENHGIA.Name = "MENHGIA";
            this.MENHGIA.ReadOnly = true;
            // 
            // HANGSANXUAT
            // 
            this.HANGSANXUAT.DataPropertyName = "NAME1";
            this.HANGSANXUAT.HeaderText = "Nhà Sản Xuất";
            this.HANGSANXUAT.Name = "HANGSANXUAT";
            this.HANGSANXUAT.ReadOnly = true;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày Nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.ReadOnly = true;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "NAME3";
            this.TRANGTHAI.HeaderText = "Trạng Thái";
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.ReadOnly = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(228, 292);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(91, 23);
            this.btnImport.TabIndex = 11;
            this.btnImport.Text = "Nhập";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mệnh Giá Thẻ :";
            // 
            // cbeValue
            // 
            this.cbeValue.DisplayMember = "ID";
            this.cbeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbeValue.FormattingEnabled = true;
            this.cbeValue.Location = new System.Drawing.Point(127, 416);
            this.cbeValue.Name = "cbeValue";
            this.cbeValue.Size = new System.Drawing.Size(170, 21);
            this.cbeValue.TabIndex = 12;
            this.cbeValue.ValueMember = "ID";
            // 
            // rImport
            // 
            this.rImport.AutoSize = true;
            this.rImport.Checked = true;
            this.rImport.Location = new System.Drawing.Point(12, 4);
            this.rImport.Name = "rImport";
            this.rImport.Size = new System.Drawing.Size(51, 17);
            this.rImport.TabIndex = 14;
            this.rImport.TabStop = true;
            this.rImport.Text = "Nhập";
            this.rImport.UseVisualStyleBackColor = true;
            this.rImport.CheckedChanged += new System.EventHandler(this.RImport_CheckedChanged);
            // 
            // rExport
            // 
            this.rExport.AutoSize = true;
            this.rExport.Location = new System.Drawing.Point(15, 359);
            this.rExport.Name = "rExport";
            this.rExport.Size = new System.Drawing.Size(47, 17);
            this.rExport.TabIndex = 15;
            this.rExport.Text = "Xuất";
            this.rExport.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tên Người Bán :";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(127, 525);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(192, 20);
            this.tbQuantity.TabIndex = 21;
            this.tbQuantity.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số Lượng :";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(228, 565);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(91, 23);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "Xuất";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // cbeName
            // 
            this.cbeName.DisplayMember = "NAME";
            this.cbeName.FormattingEnabled = true;
            this.cbeName.Location = new System.Drawing.Point(127, 381);
            this.cbeName.Name = "cbeName";
            this.cbeName.Size = new System.Drawing.Size(170, 21);
            this.cbeName.TabIndex = 24;
            this.cbeName.ValueMember = "NAME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Trạng Thái  :";
            // 
            // cbeStatus
            // 
            this.cbeStatus.DisplayMember = "ID";
            this.cbeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbeStatus.FormattingEnabled = true;
            this.cbeStatus.Location = new System.Drawing.Point(127, 487);
            this.cbeStatus.Name = "cbeStatus";
            this.cbeStatus.Size = new System.Drawing.Size(170, 21);
            this.cbeStatus.TabIndex = 25;
            this.cbeStatus.ValueMember = "ID";
            // 
            // cbeManufacturer
            // 
            this.cbeManufacturer.DisplayMember = "ID";
            this.cbeManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbeManufacturer.FormattingEnabled = true;
            this.cbeManufacturer.Location = new System.Drawing.Point(127, 451);
            this.cbeManufacturer.Name = "cbeManufacturer";
            this.cbeManufacturer.Size = new System.Drawing.Size(170, 21);
            this.cbeManufacturer.TabIndex = 27;
            this.cbeManufacturer.ValueMember = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Hãng Sản Xuất  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Hãng Sản Xuất  :";
            // 
            // cbiManufacturer
            // 
            this.cbiManufacturer.DisplayMember = "ID";
            this.cbiManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbiManufacturer.FormattingEnabled = true;
            this.cbiManufacturer.Location = new System.Drawing.Point(127, 179);
            this.cbiManufacturer.Name = "cbiManufacturer";
            this.cbiManufacturer.Size = new System.Drawing.Size(192, 21);
            this.cbiManufacturer.TabIndex = 29;
            this.cbiManufacturer.ValueMember = "ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(127, 292);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 23);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Trạng Thái  :";
            // 
            // cbiStatus
            // 
            this.cbiStatus.DisplayMember = "ID";
            this.cbiStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbiStatus.FormattingEnabled = true;
            this.cbiStatus.Location = new System.Drawing.Point(127, 217);
            this.cbiStatus.Name = "cbiStatus";
            this.cbiStatus.Size = new System.Drawing.Size(192, 21);
            this.cbiStatus.TabIndex = 32;
            this.cbiStatus.ValueMember = "ID";
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Location = new System.Drawing.Point(303, 387);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(15, 14);
            this.cName.TabIndex = 34;
            this.cName.UseVisualStyleBackColor = true;
            this.cName.CheckedChanged += new System.EventHandler(this.CName_CheckedChanged);
            // 
            // cValue
            // 
            this.cValue.AutoSize = true;
            this.cValue.Location = new System.Drawing.Point(303, 422);
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(15, 14);
            this.cValue.TabIndex = 35;
            this.cValue.UseVisualStyleBackColor = true;
            this.cValue.CheckedChanged += new System.EventHandler(this.CValue_CheckedChanged);
            // 
            // cHangSanXuat
            // 
            this.cHangSanXuat.AutoSize = true;
            this.cHangSanXuat.Location = new System.Drawing.Point(303, 457);
            this.cHangSanXuat.Name = "cHangSanXuat";
            this.cHangSanXuat.Size = new System.Drawing.Size(15, 14);
            this.cHangSanXuat.TabIndex = 36;
            this.cHangSanXuat.UseVisualStyleBackColor = true;
            this.cHangSanXuat.CheckedChanged += new System.EventHandler(this.CHangSanXuat_CheckedChanged);
            // 
            // cStatus
            // 
            this.cStatus.AutoSize = true;
            this.cStatus.Location = new System.Drawing.Point(303, 493);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(15, 14);
            this.cStatus.TabIndex = 37;
            this.cStatus.UseVisualStyleBackColor = true;
            this.cStatus.CheckedChanged += new System.EventHandler(this.CStatus_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Nhập Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.cHangSanXuat);
            this.Controls.Add(this.cValue);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbiStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbiManufacturer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbeManufacturer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbeStatus);
            this.Controls.Add(this.cbeName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rExport);
            this.Controls.Add(this.rImport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbeValue);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.diDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbiSeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbiID);
            this.Controls.Add(this.tbiName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbiValue);
            this.Name = "Form1";
            this.Text = "Quản Lí Thẻ Cào - 0566662225";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbiValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbiName;
        private System.Windows.Forms.TextBox tbiID;
        private System.Windows.Forms.TextBox tbiSeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker diDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbeValue;
        private System.Windows.Forms.RadioButton rImport;
        private System.Windows.Forms.RadioButton rExport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cbeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbeStatus;
        private System.Windows.Forms.ComboBox cbeManufacturer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbiManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MENHGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANGSANXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbiStatus;
        private System.Windows.Forms.CheckBox cName;
        private System.Windows.Forms.CheckBox cValue;
        private System.Windows.Forms.CheckBox cHangSanXuat;
        private System.Windows.Forms.CheckBox cStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

