using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_bai_6
{
    public partial class Form1 : Form
    {
        QL ql = new QL();
        public Form1()
        {
            InitializeComponent();
        }
        void Clear()
        {
            soNgayTro.Text = "";
            loaiPhong.SelectedIndex = 0;
            giaPhong.Text = "";
            hoTen.Text = "";
            namSinh.Text = "";
            soCM.Text = "";
        }
        private void add_Click(object sender, EventArgs e)
        {
          
            KhachSan ks = new KhachSan();            
            ks.Nhap(soNgayTro.Text, loaiPhong.Text, giaPhong.Text);
            ks.NhapInfo(hoTen.Text, namSinh.Text, soCM.Text);                
            ql.Nhap(ks);
            dataGridView1.Rows.Add(ks.HoTen, ks.NamSinh, ks.CMNN, ks.NgayTro, ks.LoaiPhong, ks.GiaPhong);            
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "json| *.json";
            file.ShowDialog();
            ql.Save(file.FileName);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaiPhong.SelectedIndex = 0;     
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row != null)
            {
                ql.Delete(row.Index);
                dataGridView1.Rows.Remove(row);                
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row == null)
            {
                return;
            }
            hoTen.Text = row.Cells[0].Value.ToString();
            namSinh.Text = row.Cells[1].Value.ToString();
            soCM.Text = row.Cells[2].Value.ToString();
            soNgayTro.Text = row.Cells[3].Value.ToString();
            if (row.Cells[4].Value.ToString() == "Vip")
            {
                loaiPhong.SelectedIndex = 0;
            }
            else
            {
                loaiPhong.SelectedIndex = 1;
            }
            
            giaPhong.Text = row.Cells[5].Value.ToString();
        }
    }
}
