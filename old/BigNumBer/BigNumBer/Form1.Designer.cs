namespace BigNumBer
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
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.Cal = new System.Windows.Forms.Button();
            this.KetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputA
            // 
            this.inputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputA.Location = new System.Drawing.Point(163, 43);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(151, 26);
            this.inputA.TabIndex = 0;
            // 
            // inputB
            // 
            this.inputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputB.Location = new System.Drawing.Point(163, 101);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(151, 26);
            this.inputB.TabIndex = 1;
            // 
            // Cal
            // 
            this.Cal.Location = new System.Drawing.Point(163, 161);
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(150, 30);
            this.Cal.TabIndex = 2;
            this.Cal.Text = "Tính Toán";
            this.Cal.UseVisualStyleBackColor = true;
            this.Cal.Click += new System.EventHandler(this.Cal_Click);
            // 
            // KetQua
            // 
            this.KetQua.AutoSize = true;
            this.KetQua.Location = new System.Drawing.Point(12, 245);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(35, 13);
            this.KetQua.TabIndex = 3;
            this.KetQua.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 383);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.Cal);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.Button Cal;
        private System.Windows.Forms.Label KetQua;
    }
}

