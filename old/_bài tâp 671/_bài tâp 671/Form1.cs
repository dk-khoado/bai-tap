using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _bài_tâp_671
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        public Form1()
        {
            table.Columns.Add("Mã Chuyến Bay");
            table.Columns.Add("Nơi Đi");
            table.Columns.Add("Nơi Đến");
            table.Columns.Add("Ngày Bay");
            table.Columns.Add("Giờ Bay");
            InitializeComponent();
        }
        void Clear()
        {
            maBay.Text = "";
            gioBay.Text = "";
            ngayBay.Text = "";
            noiDen.Text = "";
            noiDi.Text = "";
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            table.Rows.Add(maBay.Text, noiDi.Text, noiDen.Text, ngayBay.Text, gioBay.Text);
            DGview.Refresh();
            Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DGview.DataSource = table;
            DGview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGview.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGview.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void DELETE_Click(object sender, EventArgs e)
        {
            DataGridViewRow viewRow = DGview.CurrentRow;
            if (viewRow != null)
                DGview.Rows.Remove(viewRow);
            Clear();
            DGview.Refresh();
        }
        private void DGview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = DGview.CurrentRow;
            maBay.Text = viewRow.Cells[0].Value.ToString();
            noiDi.Text = viewRow.Cells[1].Value.ToString();
            noiDen.Text = viewRow.Cells[2].Value.ToString();
            ngayBay.Text = viewRow.Cells[3].Value.ToString();
            gioBay.Text = viewRow.Cells[4].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow viewRow = DGview.CurrentRow;
            viewRow.Cells[0].Value = maBay.Text;
            viewRow.Cells[1].Value = noiDi.Text;
            viewRow.Cells[2].Value = noiDen.Text;
            viewRow.Cells[3].Value = ngayBay.Text;
            viewRow.Cells[4].Value = gioBay.Text;
            table = (DataTable)DGview.DataSource;
        }
        private void lamMoi_Click(object sender, EventArgs e)
        {
            Clear();
            DGview.Refresh();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            table = (DataTable)DGview.DataSource;
            var json = JsonConvert.SerializeObject(table);
            saveFile.ShowDialog();
            if (saveFile.FileName != null)
            {
                StreamWriter writer = new StreamWriter(saveFile.FileName);
                writer.Write(json);
                writer.Close();
            }
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            if (openFile != null)
            {
                StreamReader reader = new StreamReader(openFile.FileName);
                var json = reader.ReadToEnd();
                table = JsonConvert.DeserializeObject<DataTable>(json);
                reader.Close();
                DGview.DataSource = table;
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (tim_kiem.Text =="")
            {
                (DGview.DataSource as DataTable).DefaultView.RowFilter = null;
                DGview.Refresh();
            }
            else
            {
                (DGview.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", table.Columns[0], tim_kiem.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            List<string> datatime = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                datatime.Add(row[3].ToString());
            }
            foreach (DataRow item in table.Rows)
            {
                datatime.FindIndex(x => x.Equals(item[3].ToString()));
            }
           
        }
    }
}
