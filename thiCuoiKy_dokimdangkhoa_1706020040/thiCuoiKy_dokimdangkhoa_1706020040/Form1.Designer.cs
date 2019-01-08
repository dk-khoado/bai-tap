namespace thiCuoiKy_dokimdangkhoa_1706020040
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripTamGiac = new System.Windows.Forms.ToolStripButton();
            this.toolStripHinhThoi = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLine,
            this.toolStripTamGiac,
            this.toolStripHinhThoi,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "menu chọn";
            // 
            // toolStripLine
            // 
            this.toolStripLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLine.Image")));
            this.toolStripLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLine.Name = "toolStripLine";
            this.toolStripLine.Size = new System.Drawing.Size(36, 36);
            this.toolStripLine.Text = "đường thẳng";
            this.toolStripLine.Click += new System.EventHandler(this.toolStripLine_Click);
            // 
            // toolStripTamGiac
            // 
            this.toolStripTamGiac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripTamGiac.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTamGiac.Image")));
            this.toolStripTamGiac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTamGiac.Name = "toolStripTamGiac";
            this.toolStripTamGiac.Size = new System.Drawing.Size(36, 36);
            this.toolStripTamGiac.Text = "tam giác";
            this.toolStripTamGiac.Click += new System.EventHandler(this.toolStripTamGiac_Click);
            // 
            // toolStripHinhThoi
            // 
            this.toolStripHinhThoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHinhThoi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHinhThoi.Image")));
            this.toolStripHinhThoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHinhThoi.Name = "toolStripHinhThoi";
            this.toolStripHinhThoi.Size = new System.Drawing.Size(36, 36);
            this.toolStripHinhThoi.Text = "hình thoi";
            this.toolStripHinhThoi.Click += new System.EventHandler(this.toolStripHinhThoi_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 39);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 411);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "save";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::thiCuoiKy_dokimdangkhoa_1706020040.Properties.Resources.folder_2_open_512;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "lưu";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripLine;
        private System.Windows.Forms.ToolStripButton toolStripTamGiac;
        private System.Windows.Forms.ToolStripButton toolStripHinhThoi;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

