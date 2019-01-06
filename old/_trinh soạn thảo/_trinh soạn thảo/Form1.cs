using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace _trinh_soạn_thảo
{
    public partial class Form1 : Form
    {
        bool check_press = false;
        float x, y;

        public Form1()
        {
            InitializeComponent();

        }
        void New()
        {
            if (Content.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn Lưu ", "thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    File.WriteAllText(saveFileDialog1.FileName, Content.Text);
                    Content.Text = "";
                }
                else if (result == DialogResult.No)
                {
                    Content.Text = "";
                }
            }

        }
        void Save()
        {
            if (tabPage1.Text == saveFileDialog1.FileName)
            {
                // saveFileDialog1.ShowDialog();    
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, Content.Text);
                    tabPage1.Text = saveFileDialog1.FileName;
                }
                catch (Exception)
                {
                }
            }
            else if (tabPage1.Text == openFileDialog1.FileName)
            {
                try
                {
                    File.WriteAllText(openFileDialog1.FileName, Content.Text);
                    tabPage1.Text = openFileDialog1.FileName;
                }
                catch (Exception)
                {
                }
            }
            else
            {
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    File.WriteAllText(saveFileDialog1.FileName, Content.Text);
                    tabPage1.Text = saveFileDialog1.FileName;
                }
            }

        }
        void Save_image()
        {
            try
            {
                saveImage.ShowDialog();
                
            }
            catch (Exception)
            {
                    
            }
        }
        void Open()
        {
            openFileDialog1.ShowDialog();
            try
            {
                //StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                //Content.Text = streamReader.ReadToEnd();
                //tabPage1.Text = openFileDialog1.FileName;
                //streamReader.Close();
                Content.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            catch (Exception)
            {
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Content_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                New();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                Save();
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                Open();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            check_press = true;
            x = e.X;
            y = e.Y;
       
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            check_press = false;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right )
            {
                saveImage.ShowDialog();
                Bitmap bitmap = (Bitmap)pictureBox1.Image;
                bitmap.Save(saveImage.FileName, ImageFormat.Jpeg);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();
            Bitmap bitmap = (Bitmap)pictureBox1.Image;
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Black, 2f);
            if (check_press == true)
            {
                graphics.DrawLine(pen, x, y, e.X, e.Y);
                
            }
            x = e.X;
            y = e.Y;

        }
    }
}
