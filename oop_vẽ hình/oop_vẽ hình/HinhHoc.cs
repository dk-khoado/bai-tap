using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using Newtonsoft.Json;

namespace oop_vẽ_hình
{
    class HinhHoc
    {
        public List<Diem> save = new List<Diem>();

        public HinhHoc()
        {

        }
        /// <summary>
        /// dùng để load dữ liệu được lưu từ data chính và phần loại dữ liệu vào từng đối tượng khác nhau
        /// </summary>
        /// <param name="input"></param>
        /// <param name="input_Name"></param>
        public void LoadData(Dictionary<string, List<Diem>> input, string input_Name)
        {
            foreach (var item in input)
            {
                if (item.Key == input_Name)
                {
                    save = item.Value;
                }
            }
        }
        public List<Diem> SaveData()
        {
            List<Diem> temp = new List<Diem>();
            temp = save;
            return temp;
        }
    }
    class Line : HinhHoc
    {
        public Diem begin = new Diem();
        public Diem end = new Diem();      
        public Line()
        {
            begin = new Diem(0, 0);
            end = new Diem(0, 0);
        }
        public Line(Diem A, Diem B)
        {
            begin = A;
            end = B;
        } 
        /// <summary>
        /// dùng để vẽ lại tất các đường đã được lêu trong đối tượng này
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pen"></param>
        public  void Draw(Graphics g, Pen pen)
        {
            foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    g.DrawLine(pen, save[i].x, save[i].y, save[i + 1].x, save[i + 1].y);
                }
            }
        }
        public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }
    class Ellipse : HinhHoc
    {
        public Diem begin = new Diem();
        public Diem end = new Diem();         
        public Ellipse()
        {
            begin = new Diem(0, 0);
            end = new Diem(0, 0);
        }
        public Ellipse(Diem A, Diem B)
        {
            begin = A;
            end = B;
        }
        public void Draw(Graphics g, Pen pen)
        {
            Rectangle rect = new Rectangle();
            foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    rect.X = save[i].x;
                    rect.Y = save[i].y;
                    rect.Size = new Size(save[i+1].x - save[i].x, save[i + 1].y - save[i].y);
                    g.DrawEllipse(pen, rect);
                }
            }
        }
        public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }
}
