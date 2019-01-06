namespace oop_vẽ_hình
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
            this.paper = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.save = new System.Windows.Forms.ToolStripButton();
            this.open = new System.Windows.Forms.ToolStripButton();
            this.duong_thang = new System.Windows.Forms.ToolStripButton();
            this.hinh_tron = new System.Windows.Forms.ToolStripButton();
            this.con_tro = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paper
            // 
            this.paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.paper.Cursor = System.Windows.Forms.Cursors.Cross;
            this.paper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paper.Location = new System.Drawing.Point(0, 57);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(899, 477);
            this.paper.TabIndex = 1;
            this.paper.TabStop = false;
            this.paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paper_MouseDown);
            this.paper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paper_MouseMove);
            this.paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paper_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save,
            this.open,
            this.duong_thang,
            this.hinh_tron,
            this.con_tro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(899, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // save
            // 
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Image = global::oop_vẽ_hình.Properties.Resources._1__3ihG_PMKFRk_TGX6x8rOw;
            this.save.ImageTransparentColor = System.Drawing.Color.Crimson;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(36, 36);
            this.save.Text = "lưu";
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // open
            // 
            this.open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.open.Image = global::oop_vẽ_hình.Properties.Resources.folder_2_open_512;
            this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(36, 36);
            this.open.Text = "mở";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // duong_thang
            // 
            this.duong_thang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.duong_thang.Image = ((System.Drawing.Image)(resources.GetObject("duong_thang.Image")));
            this.duong_thang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.duong_thang.Name = "duong_thang";
            this.duong_thang.Size = new System.Drawing.Size(36, 36);
            this.duong_thang.Text = "toolStripButton1";
            this.duong_thang.ToolTipText = "Đường thằng";
            this.duong_thang.Click += new System.EventHandler(this.duong_thang_Click);
            // 
            // hinh_tron
            // 
            this.hinh_tron.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hinh_tron.Image = ((System.Drawing.Image)(resources.GetObject("hinh_tron.Image")));
            this.hinh_tron.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hinh_tron.Name = "hinh_tron";
            this.hinh_tron.Size = new System.Drawing.Size(36, 36);
            this.hinh_tron.Text = "hình tròn";
            this.hinh_tron.Click += new System.EventHandler(this.hinh_tron_Click);
            // 
            // con_tro
            // 
            this.con_tro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.con_tro.Image = ((System.Drawing.Image)(resources.GetObject("con_tro.Image")));
            this.con_tro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.con_tro.Name = "con_tro";
            this.con_tro.Size = new System.Drawing.Size(36, 36);
            this.con_tro.Text = "Trỏ";
            this.con_tro.Click += new System.EventHandler(this.con_tro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 534);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.paper);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton save;
        private System.Windows.Forms.ToolStripButton open;
        private System.Windows.Forms.ToolStripButton duong_thang;
        private System.Windows.Forms.ToolStripButton hinh_tron;
        private System.Windows.Forms.ToolStripButton con_tro;
    }
}

