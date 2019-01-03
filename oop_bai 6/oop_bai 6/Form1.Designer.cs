namespace oop_bai_6
{
    partial class Form1
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
            this.hoTen = new System.Windows.Forms.TextBox();
            this.soCM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.soNgayTro = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loaiPhong = new System.Windows.Forms.ComboBox();
            this.giaPhong = new System.Windows.Forms.TextBox();
            this.namSinh = new System.Windows.Forms.MaskedTextBox();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTen
            // 
            this.hoTen.Location = new System.Drawing.Point(120, 46);
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(217, 20);
            this.hoTen.TabIndex = 0;
            // 
            // soCM
            // 
            this.soCM.Location = new System.Drawing.Point(120, 168);
            this.soCM.MaxLength = 12;
            this.soCM.Name = "soCM";
            this.soCM.Size = new System.Drawing.Size(217, 20);
            this.soCM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ Và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Năm Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Chứng Minh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loại Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số Ngày Trọ";
            // 
            // soNgayTro
            // 
            this.soNgayTro.Location = new System.Drawing.Point(456, 46);
            this.soNgayTro.Name = "soNgayTro";
            this.soNgayTro.Size = new System.Drawing.Size(217, 20);
            this.soNgayTro.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hovaten,
            this.sn,
            this.cm,
            this.ngayTro,
            this.lp,
            this.gp});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(730, 199);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hovaten
            // 
            this.hovaten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hovaten.HeaderText = "họ và tên";
            this.hovaten.Name = "hovaten";
            this.hovaten.ReadOnly = true;
            // 
            // sn
            // 
            this.sn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sn.HeaderText = "Năm Sinh";
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            // 
            // cm
            // 
            this.cm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cm.HeaderText = "Chứng minh";
            this.cm.Name = "cm";
            this.cm.ReadOnly = true;
            // 
            // ngayTro
            // 
            this.ngayTro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayTro.HeaderText = "Ngày Trọ";
            this.ngayTro.Name = "ngayTro";
            this.ngayTro.ReadOnly = true;
            // 
            // lp
            // 
            this.lp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lp.HeaderText = "loại Phòng";
            this.lp.Name = "lp";
            this.lp.ReadOnly = true;
            // 
            // gp
            // 
            this.gp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gp.HeaderText = "Giá Phong";
            this.gp.Name = "gp";
            this.gp.ReadOnly = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(120, 232);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(134, 32);
            this.add.TabIndex = 6;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loaiPhong
            // 
            this.loaiPhong.DisplayMember = "0";
            this.loaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loaiPhong.FormattingEnabled = true;
            this.loaiPhong.Items.AddRange(new object[] {
            "Vip",
            "Thường"});
            this.loaiPhong.Location = new System.Drawing.Point(456, 109);
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.Size = new System.Drawing.Size(217, 21);
            this.loaiPhong.TabIndex = 4;
            this.loaiPhong.ValueMember = "0";
            // 
            // giaPhong
            // 
            this.giaPhong.Location = new System.Drawing.Point(456, 168);
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.Size = new System.Drawing.Size(217, 20);
            this.giaPhong.TabIndex = 5;
            // 
            // namSinh
            // 
            this.namSinh.Location = new System.Drawing.Point(120, 106);
            this.namSinh.Mask = "00/00/0000";
            this.namSinh.Name = "namSinh";
            this.namSinh.Size = new System.Drawing.Size(216, 20);
            this.namSinh.TabIndex = 1;
            this.namSinh.ValidatingType = typeof(System.DateTime);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(120, 270);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(134, 32);
            this.delete.TabIndex = 13;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 617);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.namSinh);
            this.Controls.Add(this.loaiPhong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.giaPhong);
            this.Controls.Add(this.soNgayTro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soCM);
            this.Controls.Add(this.hoTen);
            this.Name = "Form1";
            this.Text = "Quản lý Khách Sạn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hoTen;
        private System.Windows.Forms.TextBox soCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox soNgayTro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gp;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox loaiPhong;
        private System.Windows.Forms.TextBox giaPhong;
        private System.Windows.Forms.MaskedTextBox namSinh;
        private System.Windows.Forms.Button delete;
    }
}

