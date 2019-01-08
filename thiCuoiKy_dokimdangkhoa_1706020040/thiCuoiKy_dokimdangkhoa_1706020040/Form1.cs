using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace thiCuoiKy_dokimdangkhoa_1706020040
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<Diem>> data = new Dictionary<string, List<Diem>>();
        bool isLine, isTamGiac, isThoi;
        Graphics g;
        Pen pen = new Pen(Color.Black, 2);
        Diem begin = new Diem();
        Diem end = new Diem();
        bool isPaint= false;
        clsLine line = new clsLine();
        clsTamGiac tamGiac = new clsTamGiac();
        clsThoi thoi = new clsThoi();
        public Form1()
        {
            
            InitializeComponent();
            g = pictureBox.CreateGraphics();
        }
        void Update()
        {
            tamGiac.Draw(pen, g);
            line.Draw(pen,g);
            thoi.Draw(pen,g);
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            begin = new Diem(e.X, e.Y);
            if (isTamGiac)
            {
                tamGiac.diemDau = begin;
            }
            if (isThoi)
            {
                thoi.diemDau = begin;
            }
            isPaint = true;
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;
            end = new Diem(e.X, e.Y);
            if (isLine)
            {
                line.diemDau = begin;
                line.diemCuoi = end;
                line.AddPoint();
            }
            if (isTamGiac)
            {
                tamGiac.diemDau = begin;
                tamGiac.diemCuoi = end;
                tamGiac.AddPoint();
            }
            if (isThoi)
            {
                thoi.diemDau = begin;
                thoi.diemCuoi = end;
                thoi.AddPoint();
            }
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint == true)
            {                                
                g.Clear(pictureBox.BackColor);
                if (isLine)
                {                   
                    g.DrawLine(pen, begin.X, begin.Y, e.X, e.Y);
                }
                else if (isTamGiac)
                {
                    tamGiac.diemCuoi = new Diem(e.X, e.Y);
                    tamGiac.Draw_tamGiac(pen, g);
                }
                else if (isThoi)
                {
                    thoi.diemCuoi = new Diem(e.X, e.Y);
                    thoi.Draw_thoi(pen, g);
                }
                
            }
            Update();
        }
        private void toolStripTamGiac_Click(object sender, EventArgs e)
        {
            Select(2);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "json| *.json";
            save.ShowDialog();
            data.Add("line", line.SaveData());
            data.Add("tamgiac", tamGiac.SaveData());
            data.Add("thoi", thoi.SaveData());
            StreamWriter writer = new StreamWriter(save.FileName);
            var json = JsonConvert.SerializeObject(data);
            writer.Write(json);
            writer.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "json| *.json";
            open.ShowDialog();
            StreamReader reader = new StreamReader(open.FileName);
            var json = reader.ReadToEnd();
            data = JsonConvert.DeserializeObject<Dictionary<string, List<Diem>>>(json);
            line.LoadData(data, "line");
            tamGiac.LoadData(data, "tamgiac");
            thoi.LoadData(data, "thoi");
            reader.Close();
            Update();
        }

        private void toolStripHinhThoi_Click(object sender, EventArgs e)
        {
            Select(3);
        }

        void Select(int input)
        {
            switch (input)
            {
                case 1:
                    isLine = true;
                    isTamGiac = false;
                    isThoi = false;
                    break;
                case 2:
                    isLine = false;
                    isTamGiac = true;
                    isThoi = false;
                    break;
                case 3:
                    isLine = false;
                    isTamGiac = false;
                    isThoi = true;
                    break;

            }
        }
        private void toolStripLine_Click(object sender, EventArgs e)
        {
            Select(1);
        }

    }
}
