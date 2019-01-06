namespace xử_lý_điểm_học_sinh
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hoTen = new System.Windows.Forms.TextBox();
            this.diemToan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.diemLy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.diemHoa = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.diemTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mathisinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trungbinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsthisinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danh_sach_thi_sinhDataSet = new xử_lý_điểm_học_sinh.Danh_sach_thi_sinhDataSet();
            this.ds_thi_sinhTableAdapter = new xử_lý_điểm_học_sinh.Danh_sach_thi_sinhDataSetTableAdapters.ds_thi_sinhTableAdapter();
            this.bnt_xoa = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsthisinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danh_sach_thi_sinhDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 90);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(774, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Điểm Học Sinh";
            // 
            // maSo
            // 
            this.maSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSo.Location = new System.Drawing.Point(174, 121);
            this.maSo.MaxLength = 10;
            this.maSo.Name = "maSo";
            this.maSo.Size = new System.Drawing.Size(144, 26);
            this.maSo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ Tên Thí Sinh";
            // 
            // hoTen
            // 
            this.hoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTen.Location = new System.Drawing.Point(560, 121);
            this.hoTen.MaxLength = 50;
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(197, 26);
            this.hoTen.TabIndex = 3;
            // 
            // diemToan
            // 
            this.diemToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemToan.FormattingEnabled = true;
            this.diemToan.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.diemToan.Location = new System.Drawing.Point(71, 188);
            this.diemToan.Name = "diemToan";
            this.diemToan.Size = new System.Drawing.Size(91, 28);
            this.diemToan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lý";
            // 
            // diemLy
            // 
            this.diemLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemLy.FormattingEnabled = true;
            this.diemLy.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.diemLy.Location = new System.Drawing.Point(206, 188);
            this.diemLy.Name = "diemLy";
            this.diemLy.Size = new System.Drawing.Size(91, 28);
            this.diemLy.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hóa";
            // 
            // diemHoa
            // 
            this.diemHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemHoa.FormattingEnabled = true;
            this.diemHoa.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.diemHoa.Location = new System.Drawing.Point(369, 188);
            this.diemHoa.Name = "diemHoa";
            this.diemHoa.Size = new System.Drawing.Size(91, 28);
            this.diemHoa.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Điểm Trung Bình";
            // 
            // diemTB
            // 
            this.diemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemTB.Location = new System.Drawing.Point(620, 190);
            this.diemTB.Name = "diemTB";
            this.diemTB.ReadOnly = true;
            this.diemTB.Size = new System.Drawing.Size(91, 26);
            this.diemTB.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathisinhDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.toanDataGridViewTextBoxColumn,
            this.lyDataGridViewTextBoxColumn,
            this.hoaDataGridViewTextBoxColumn,
            this.trungbinhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dsthisinhBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(865, 291);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mathisinhDataGridViewTextBoxColumn
            // 
            this.mathisinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mathisinhDataGridViewTextBoxColumn.DataPropertyName = "mathisinh";
            this.mathisinhDataGridViewTextBoxColumn.HeaderText = "Mã Thí Sinh";
            this.mathisinhDataGridViewTextBoxColumn.Name = "mathisinhDataGridViewTextBoxColumn";
            this.mathisinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "Họ Tên Thí Sinh";
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            this.hotenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toanDataGridViewTextBoxColumn
            // 
            this.toanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.toanDataGridViewTextBoxColumn.DataPropertyName = "toan";
            this.toanDataGridViewTextBoxColumn.HeaderText = "Toán";
            this.toanDataGridViewTextBoxColumn.Name = "toanDataGridViewTextBoxColumn";
            this.toanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lyDataGridViewTextBoxColumn
            // 
            this.lyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lyDataGridViewTextBoxColumn.DataPropertyName = "ly";
            this.lyDataGridViewTextBoxColumn.HeaderText = "Lý";
            this.lyDataGridViewTextBoxColumn.Name = "lyDataGridViewTextBoxColumn";
            this.lyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoaDataGridViewTextBoxColumn
            // 
            this.hoaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoaDataGridViewTextBoxColumn.DataPropertyName = "hoa";
            this.hoaDataGridViewTextBoxColumn.HeaderText = "Hóa";
            this.hoaDataGridViewTextBoxColumn.Name = "hoaDataGridViewTextBoxColumn";
            this.hoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trungbinhDataGridViewTextBoxColumn
            // 
            this.trungbinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trungbinhDataGridViewTextBoxColumn.DataPropertyName = "trungbinh";
            this.trungbinhDataGridViewTextBoxColumn.HeaderText = "Trung Bình";
            this.trungbinhDataGridViewTextBoxColumn.Name = "trungbinhDataGridViewTextBoxColumn";
            this.trungbinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsthisinhBindingSource
            // 
            this.dsthisinhBindingSource.DataMember = "ds_thi_sinh";
            this.dsthisinhBindingSource.DataSource = this.danh_sach_thi_sinhDataSet;
            // 
            // danh_sach_thi_sinhDataSet
            // 
            this.danh_sach_thi_sinhDataSet.DataSetName = "Danh_sach_thi_sinhDataSet";
            this.danh_sach_thi_sinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds_thi_sinhTableAdapter
            // 
            this.ds_thi_sinhTableAdapter.ClearBeforeFill = true;
            // 
            // bnt_xoa
            // 
            this.bnt_xoa.BackColor = System.Drawing.Color.LimeGreen;
            this.bnt_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_xoa.FlatAppearance.BorderSize = 0;
            this.bnt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_xoa.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_xoa.Location = new System.Drawing.Point(197, 249);
            this.bnt_xoa.Name = "bnt_xoa";
            this.bnt_xoa.Size = new System.Drawing.Size(121, 33);
            this.bnt_xoa.TabIndex = 16;
            this.bnt_xoa.Text = "Xóa";
            this.bnt_xoa.UseVisualStyleBackColor = false;
            this.bnt_xoa.Click += new System.EventHandler(this.bnt_xoa_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(340, 249);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(121, 33);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "Sửa Đổi";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(479, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Làm Mới";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ketqua
            // 
            this.ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.Location = new System.Drawing.Point(717, 256);
            this.ketqua.MaxLength = 10;
            this.ketqua.Name = "ketqua";
            this.ketqua.ReadOnly = true;
            this.ketqua.Size = new System.Drawing.Size(96, 26);
            this.ketqua.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(644, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kết Quả";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 61);
            this.button4.TabIndex = 2;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 594);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.bnt_xoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.diemTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.diemHoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.diemLy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diemToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maSo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsthisinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danh_sach_thi_sinhDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hoTen;
        private System.Windows.Forms.ComboBox diemToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox diemLy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox diemHoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox diemTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Danh_sach_thi_sinhDataSet danh_sach_thi_sinhDataSet;
        private System.Windows.Forms.BindingSource dsthisinhBindingSource;
        private Danh_sach_thi_sinhDataSetTableAdapters.ds_thi_sinhTableAdapter ds_thi_sinhTableAdapter;
        private System.Windows.Forms.Button bnt_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathisinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trungbinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
    }
}