using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace thiCuoiKy_dokimdangkhoa_1706020040
{
    class clsHinh
    {
        public List<Diem> saveData = new List<Diem>();
        public Diem diemDau = new Diem();
        public Diem diemCuoi = new Diem();
        public clsHinh()
        {

        }
        /// <summary>
        /// vẽ lại tất cả các điểm được lưu
        /// </summary>
        public virtual void Draw(Pen pen, Graphics g)
        {

        }
        public void LoadData(Dictionary<string, List<Diem>> input, string input_Name)
        {
            foreach (var item in input)
            {
                if (item.Key == input_Name)
                {
                    saveData = item.Value;
                }
            }
        }
        public List<Diem> SaveData()
        {
            List<Diem> temp = new List<Diem>();
            temp = saveData;
            return temp;
        }
    }
    class clsLine : clsHinh
    {        
        public clsLine()
        {

        }
        public override void Draw(Pen pen, Graphics g)
        {
            base.Draw(pen, g);
            for (int i = 0; i < saveData.Count - 1; i += 2)
            {
                g.DrawLine(pen, saveData[i].X, saveData[i].Y, saveData[i + 1].X, saveData[i + 1].Y);
            }
        }
        public clsLine(Diem begin, Diem end)
        {
            diemDau = begin;
            diemCuoi = end;
        }
        /// <summary>
        /// thêm điểm vào danh sách để lưu
        /// </summary>
        public void AddPoint()
        {
            saveData.Add(diemDau);
            saveData.Add(diemCuoi);
        }
    }

   class clsTamGiac:clsHinh
    {
        public clsTamGiac()
        {

        }
        public clsTamGiac(Diem begin, Diem end)
        {
            diemDau = begin;
            diemCuoi = end;
        }
        public override void Draw(Pen pen, Graphics g)
        {
            base.Draw(pen, g);
            for (int i = 0; i < saveData.Count - 1; i += 2)
            {
                Rectangle rect = new Rectangle();
                rect.Size = new Size(saveData[i+1].X - saveData[i].X, saveData[i+1].Y - saveData[i].Y);
                rect.X = saveData[i].X;
                rect.Y = saveData[i].Y;
                g.DrawLine(pen, rect.X, rect.Y + rect.Height, saveData[i+1].X, saveData[i+1].Y);
                g.DrawLine(pen, rect.X, rect.Y, saveData[i+1].X, saveData[i+1].Y);
                g.DrawLine(pen, rect.X, rect.Y, saveData[i + 1].X - rect.Width, saveData[i + 1].Y);
            }
        }
        public  void Draw_tamGiac(Pen pen, Graphics g)
        {            
            Rectangle rect = new Rectangle();
            rect.Size = new Size(diemCuoi.X - diemDau.X, diemCuoi.Y - diemDau.Y);            
            rect.X = diemDau.X;
            rect.Y = diemDau.Y;            
            g.DrawLine(pen, rect.X, rect.Y + rect.Height, diemCuoi.X, diemCuoi.Y);
            g.DrawLine(pen, rect.X , rect.Y, diemCuoi.X, diemCuoi.Y);
            g.DrawLine(pen, rect.X , rect.Y,diemCuoi.X - rect.Width, diemCuoi.Y);
        }
        public void AddPoint()
        {
            saveData.Add(diemDau);
            saveData.Add(diemCuoi);
        }
    }

    class clsThoi: clsHinh
    {
        public clsThoi()
        {

        }
        public clsThoi(Diem begin, Diem end)
        {
            diemDau = begin;
            diemCuoi = end;
        }
        public override void Draw(Pen pen, Graphics g)
        {
            base.Draw(pen, g);
            for (int i = 0; i < saveData.Count - 1; i += 2)
            {
                Rectangle rect = new Rectangle();
                rect.Size = new Size(saveData[i + 1].X - saveData[i].X, saveData[i + 1].Y - saveData[i].Y);
                rect.X = saveData[i].X;
                rect.Y = saveData[i].Y;
                float width = rect.Width / 2;
                float height = rect.Height / 2;
                g.DrawLine(pen, rect.X + width, rect.Y, saveData[i+1].X, saveData[i + 1].Y - height);
                g.DrawLine(pen, rect.X + width, rect.Y, rect.X, rect.Y + height);
                g.DrawLine(pen, rect.X, rect.Y + height, saveData[i + 1].X - width, saveData[i + 1].Y);
                g.DrawLine(pen, saveData[i + 1].X - width, saveData[i + 1].Y, saveData[i + 1].X, saveData[i + 1].Y - height);
            }
        }
        public void Draw_thoi(Pen pen, Graphics g)
        {
            Rectangle rect = new Rectangle();
            rect.Size = new Size(diemCuoi.X - diemDau.X, diemCuoi.Y - diemDau.Y);
            rect.X = diemDau.X;
            rect.Y = diemDau.Y;
            float width = rect.Width / 2;
            float height = rect.Height / 2;
            g.DrawLine(pen, rect.X + width, rect.Y, diemCuoi.X, diemCuoi.Y- height);
            g.DrawLine(pen, rect.X + width, rect.Y, rect.X, rect.Y + height);
            g.DrawLine(pen, rect.X, rect.Y + height, diemCuoi.X - width, diemCuoi.Y);
            g.DrawLine(pen, diemCuoi.X - width, diemCuoi.Y, diemCuoi.X, diemCuoi.Y - height);
            
        }
        public void AddPoint()
        {
            saveData.Add(diemDau);
            saveData.Add(diemCuoi);
        }
    }
}
