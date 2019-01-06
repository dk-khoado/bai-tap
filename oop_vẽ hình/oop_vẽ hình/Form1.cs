using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_vẽ_hình
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<Diem>> data = new Dictionary<string, List<Diem>>();//đối tượng để lưu dư liệu tổng
        Graphics g;//đối tượng nền
        Pen pen = new Pen(Color.Red, 1);//cây bút để vẽ
        bool canDraw = false;//kiểm tra điều kiện có thể vẽ hay không
        Diem begin = new Diem();//điểm bắt đầu vẽ
        Diem end = new Diem();//điểm kết thúc
        Line line = new Line();//tao đối tượng đường thằng
        Ellipse ellipse = new Ellipse();//tạo đối tượng hình tròn
        Rectangle rect = new Rectangle();//tạo vùng tiếp diện hình chữ nhật
        bool pointer, isLine, isElise;//kiểm tra menu chọn
        public Form1()
        {
            InitializeComponent();
            g = paper.CreateGraphics();
            pointer = true;
            isElise = false;
            isLine = false;
        }
        /// <summary>
        /// dùng để cập nhập lai các hình đã vẽ theo thời gian thực
        /// </summary>
        void Update()
        {
            for (int i = 0; i < line.save.Count - 1; i += 2)
            {
                line.Draw(g, pen);
            }
            for (int i = 0; i < ellipse.save.Count - 1; i += 2)
            {
                ellipse.Draw(g,pen);
            }
        }
        private void paper_MouseDown(object sender, MouseEventArgs e)
        {
            if (pointer == false)
            {
                canDraw = true;
                begin = new Diem(e.X, e.Y);
                rect.X = begin.x;
                rect.Y = begin.y;
            }
            
        }
        private void paper_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (canDraw == true)
            {
                end = new Diem(e.X, e.Y);
                g.Clear(paper.BackColor);
                if (pointer)
                {
                    return;
                }
                else if (isLine== true)
                {
                    g.DrawLine(pen, begin.x, begin.y, e.X, e.Y);                   
                }
                else if (isElise==true)
                {
                    rect.Size = new Size(end.x - begin.x, end.y - begin.y);
                    g.DrawEllipse(pen,rect);
                }
                Update();
            }                       
        }

        private void paper_MouseUp(object sender, MouseEventArgs e)
        {
            if (pointer == false)
            {
                end.x = e.X;
                end.y = e.Y;
                canDraw = false;
                if (isLine)
                {
                    line.begin = begin;
                    line.end = end;
                    line.AddPoint();
                }
                else if (isElise)
                {
                    ellipse.begin = begin;
                    ellipse.end = end;
                    ellipse.AddPoint();
                }
                
            }
            
        }
        private void open_Click(object sender, EventArgs e)
        {
            pointer = true;
            isElise = false;
            isLine = false;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "json| *.json";
            open.ShowDialog();
            StreamReader reader = new StreamReader(open.FileName);
            var json = reader.ReadToEnd();
            data = JsonConvert.DeserializeObject<Dictionary<string, List<Diem>>>(json);
            line.LoadData(data,"line");
            ellipse.LoadData(data,"tron");
            reader.Close();
            Update();
        }

        private void hinh_tron_Click(object sender, EventArgs e)
        {

            pointer = false;
            isLine = false;
            isElise = true;
        }

        private void con_tro_Click(object sender, EventArgs e)
        {
            pointer = true;
            isLine = false;
            isElise = false;
        }
        private void duong_thang_Click(object sender, EventArgs e)
        {

            pointer = false;
            isLine = true;
            isElise = false;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            pointer = true;
            isElise = false;
            isLine = false;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "json| *.json";
            save.ShowDialog();
            data.Add("line",line.SaveData());
            data.Add("tron",ellipse.SaveData());
            StreamWriter writer = new StreamWriter(save.FileName);
            var json = JsonConvert.SerializeObject(data);
            writer.Write(json);
            writer.Close();
        }
    }
}
