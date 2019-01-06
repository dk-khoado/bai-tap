using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_học_sinh_not_database
{
    public partial class Main : Form
    {
        int index;
        DataTable table = new DataTable();
        public Main()
        {
            table.Columns.Add("Tên");
            table.Columns.Add("Họ");
            table.Columns.Add("Tuôi");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt_ten.Text, txt_ho.Text, txt_tuoi.Text);
            dgView.Refresh();
            Clrear();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            dgView.DataSource = table;
            dgView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            table = (DataTable)dgView.DataSource;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Json|*.json";
            save.ShowDialog();
            StreamWriter writer = new StreamWriter(save.FileName);
            var json = JsonConvert.SerializeObject(table);
            writer.Write(json);
            writer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Json|*.json";
            open.ShowDialog();
            StreamReader reader = new StreamReader(open.FileName);
            var json = reader.ReadToEnd();
            table = JsonConvert.DeserializeObject<DataTable>(json);
            reader.Close();
            dgView.DataSource = table;
        }
        void Clrear()
        {
            txt_ten.Text = "";
            txt_ho.Text = "";
            txt_tuoi.Text = "";

        }
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            DataGridViewRow viewRow = dgView.CurrentRow;
            txt_ten.Text = viewRow.Cells[0].Value.ToString();
            txt_ho.Text = viewRow.Cells[1].Value.ToString();
            txt_tuoi.Text = viewRow.Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_ho.Text != "" && txt_ten.Text != "" && txt_tuoi.Text != "")
            {
                DataGridViewRow viewRow = dgView.CurrentRow;
                viewRow.Cells[0].Value = txt_ten.Text;
                viewRow.Cells[1].Value = txt_ho.Text;
                viewRow.Cells[2].Value = txt_tuoi.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clrear();
            DataGridViewRow viewRow = dgView.CurrentRow;
            if (viewRow != null)
                dgView.Rows.Remove(viewRow);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clrear();
        }
    }
}
