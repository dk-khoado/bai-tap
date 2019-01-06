namespace _bài_tâp_671
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maBay = new System.Windows.Forms.TextBox();
            this.noiDi = new System.Windows.Forms.TextBox();
            this.noiDen = new System.Windows.Forms.TextBox();
            this.ngayBay = new System.Windows.Forms.MaskedTextBox();
            this.gioBay = new System.Windows.Forms.MaskedTextBox();
            this.DGview = new System.Windows.Forms.DataGridView();
            this.ADD = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lamMoi = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.tim_kiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chuyến Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Bay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giờ Bay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nơi Đi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nơi Đến";
            // 
            // maBay
            // 
            this.maBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maBay.Location = new System.Drawing.Point(137, 40);
            this.maBay.MaxLength = 5;
            this.maBay.Name = "maBay";
            this.maBay.Size = new System.Drawing.Size(91, 26);
            this.maBay.TabIndex = 5;
            // 
            // noiDi
            // 
            this.noiDi.AutoCompleteCustomSource.AddRange(new string[] {
            "TP Hồ Chí Minh",
            "Nhật Bổn",
            "Viến đông"});
            this.noiDi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.noiDi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.noiDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiDi.Location = new System.Drawing.Point(137, 81);
            this.noiDi.MaxLength = 20;
            this.noiDi.Name = "noiDi";
            this.noiDi.Size = new System.Drawing.Size(216, 26);
            this.noiDi.TabIndex = 6;
            // 
            // noiDen
            // 
            this.noiDen.AutoCompleteCustomSource.AddRange(new string[] {
            "TP Hồ Chí Minh",
            "Nhật Bổn",
            "Viến đông"});
            this.noiDen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.noiDen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.noiDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noiDen.Location = new System.Drawing.Point(137, 127);
            this.noiDen.MaxLength = 20;
            this.noiDen.Name = "noiDen";
            this.noiDen.Size = new System.Drawing.Size(216, 26);
            this.noiDen.TabIndex = 7;
            // 
            // ngayBay
            // 
            this.ngayBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayBay.Location = new System.Drawing.Point(326, 37);
            this.ngayBay.Mask = "00/00/0000";
            this.ngayBay.Name = "ngayBay";
            this.ngayBay.Size = new System.Drawing.Size(97, 26);
            this.ngayBay.TabIndex = 8;
            this.ngayBay.ValidatingType = typeof(System.DateTime);
            // 
            // gioBay
            // 
            this.gioBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioBay.Location = new System.Drawing.Point(522, 37);
            this.gioBay.Mask = "00:00";
            this.gioBay.Name = "gioBay";
            this.gioBay.Size = new System.Drawing.Size(53, 26);
            this.gioBay.TabIndex = 9;
            this.gioBay.ValidatingType = typeof(System.DateTime);
            // 
            // DGview
            // 
            this.DGview.AllowUserToAddRows = false;
            this.DGview.AllowUserToDeleteRows = false;
            this.DGview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGview.Location = new System.Drawing.Point(0, 328);
            this.DGview.Name = "DGview";
            this.DGview.ReadOnly = true;
            this.DGview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGview.Size = new System.Drawing.Size(892, 222);
            this.DGview.TabIndex = 10;
            this.DGview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGview_CellClick);
            // 
            // ADD
            // 
            this.ADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD.Location = new System.Drawing.Point(12, 182);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(125, 37);
            this.ADD.TabIndex = 11;
            this.ADD.Text = "Thêm Chuyến Bay";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // DELETE
            // 
            this.DELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETE.Location = new System.Drawing.Point(153, 182);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(125, 37);
            this.DELETE.TabIndex = 12;
            this.DELETE.Text = "Xóa Chuyến Bay";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(298, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cập Nhâp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lamMoi
            // 
            this.lamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lamMoi.Location = new System.Drawing.Point(13, 225);
            this.lamMoi.Name = "lamMoi";
            this.lamMoi.Size = new System.Drawing.Size(125, 37);
            this.lamMoi.TabIndex = 14;
            this.lamMoi.Text = "Làm mới";
            this.lamMoi.UseVisualStyleBackColor = true;
            this.lamMoi.Click += new System.EventHandler(this.lamMoi_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(441, 182);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 37);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Lưu Dữ Liêu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Json |*.json";
            // 
            // openFile
            // 
            this.openFile.Filter = "Json |*.json";
            // 
            // btn_load
            // 
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.Location = new System.Drawing.Point(582, 182);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(125, 37);
            this.btn_load.TabIndex = 16;
            this.btn_load.Text = "Tải Dữ Liệu";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_timkiem.Location = new System.Drawing.Point(13, 283);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(125, 37);
            this.btn_timkiem.TabIndex = 17;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // tim_kiem
            // 
            this.tim_kiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim_kiem.Location = new System.Drawing.Point(144, 294);
            this.tim_kiem.Name = "tim_kiem";
            this.tim_kiem.Size = new System.Drawing.Size(106, 26);
            this.tim_kiem.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã Chuyến Bay";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(270, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Tìm Kiếm Ngày Có Nhiều Chuyến Bay Nhất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(408, 287);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(97, 26);
            this.maskedTextBox1.TabIndex = 21;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 550);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tim_kiem);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lamMoi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.DGview);
            this.Controls.Add(this.gioBay);
            this.Controls.Add(this.ngayBay);
            this.Controls.Add(this.noiDen);
            this.Controls.Add(this.noiDi);
            this.Controls.Add(this.maBay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maBay;
        private System.Windows.Forms.TextBox noiDi;
        private System.Windows.Forms.TextBox noiDen;
        private System.Windows.Forms.MaskedTextBox ngayBay;
        private System.Windows.Forms.MaskedTextBox gioBay;
        private System.Windows.Forms.DataGridView DGview;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lamMoi;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox tim_kiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

