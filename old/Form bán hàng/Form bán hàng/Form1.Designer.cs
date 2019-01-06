namespace Form_bán_hàng
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.selection0 = new System.Windows.Forms.Panel();
            this.Bnt_Home = new System.Windows.Forms.Button();
            this.Btn_danhsach = new System.Windows.Forms.Button();
            this.UCT_home = new Form_bán_hàng.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_danhsach);
            this.panel1.Controls.Add(this.selection0);
            this.panel1.Controls.Add(this.Bnt_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 561);
            this.panel1.TabIndex = 0;
            // 
            // selection0
            // 
            this.selection0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.selection0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selection0.Location = new System.Drawing.Point(13, 90);
            this.selection0.Name = "selection0";
            this.selection0.Size = new System.Drawing.Size(10, 43);
            this.selection0.TabIndex = 1;
            // 
            // Bnt_Home
            // 
            this.Bnt_Home.BackColor = System.Drawing.Color.Silver;
            this.Bnt_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bnt_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bnt_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnt_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Home.Location = new System.Drawing.Point(23, 90);
            this.Bnt_Home.Name = "Bnt_Home";
            this.Bnt_Home.Size = new System.Drawing.Size(144, 44);
            this.Bnt_Home.TabIndex = 0;
            this.Bnt_Home.Text = "Home";
            this.Bnt_Home.UseVisualStyleBackColor = false;
            this.Bnt_Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_danhsach
            // 
            this.Btn_danhsach.BackColor = System.Drawing.Color.Silver;
            this.Btn_danhsach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_danhsach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_danhsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_danhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_danhsach.Location = new System.Drawing.Point(23, 140);
            this.Btn_danhsach.Name = "Btn_danhsach";
            this.Btn_danhsach.Size = new System.Drawing.Size(144, 44);
            this.Btn_danhsach.TabIndex = 2;
            this.Btn_danhsach.Text = "Danh Sách";
            this.Btn_danhsach.UseVisualStyleBackColor = false;
            this.Btn_danhsach.Click += new System.EventHandler(this.button2_Click);
            // 
            // UCT_home
            // 
            this.UCT_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UCT_home.BackgroundImage")));
            this.UCT_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UCT_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCT_home.Location = new System.Drawing.Point(168, 0);
            this.UCT_home.Name = "UCT_home";
            this.UCT_home.Size = new System.Drawing.Size(696, 561);
            this.UCT_home.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.UCT_home);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bnt_Home;
        private System.Windows.Forms.Panel selection0;
        private System.Windows.Forms.Button Btn_danhsach;
        private UserControl1 UCT_home;
    }
}

