using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.IO;
namespace xử_lý_điểm_học_sinh
{
    public partial class Main : Form
    {
        string sql = @"Data Source=KHOATHU\SQLdatabase;Initial Catalog=Danh_sach_thi_sinh;Integrated Security=True";
        SqlConnection connection;
        //SqlDataAdapter adapter;
        //DataTable DataTable = new DataTable();
        public Main()
        {
            connection = new SqlConnection(sql);
            InitializeComponent();
        }
        void Lam_Moi()
        {
            maSo.Text = "";
            hoTen.Text = "";
            diemToan.Text = "";
            diemLy.Text = "";
            diemHoa.Text = "";
            diemTB.Text = "";
        }
        void Add()
        {
            float toan;
            float.TryParse(diemToan.Text, out toan);            
            float ly; float.TryParse(diemLy.Text,out ly);
            float hoa;  float.TryParse(diemHoa.Text,out hoa);
            float tb = (toan + ly + hoa) / 3;
            string ten = hoTen.Text.ToString().ToUpperInvariant();
            try
            {
                connection.Open();
                string query = "insert ds_thi_sinh(mathisinh, hoten, toan, ly, hoa, trungbinh) values('" +
                    maSo.Text + "',N'" + ten + "'," + toan + "," + ly + "," + hoa + ", " + tb + ")";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            connection.Close();
        }
        void delete()
        {
            try
            {
                connection.Open();               
                SqlCommand command = new SqlCommand("delete ds_thi_sinh where mathisinh='"+maSo.Text+"'", connection);
                command.ExecuteNonQuery();
                this.ds_thi_sinhTableAdapter.Fill(this.danh_sach_thi_sinhDataSet.ds_thi_sinh);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể Xóa");
            }
            connection.Close();
        }
        void Edit()
        {
            float toan;
            float.TryParse(diemToan.Text, out toan);
            float ly;
            float.TryParse(diemLy.Text, out ly);
            float hoa;
            float.TryParse(diemHoa.Text, out hoa);
            float tb = (toan + ly + hoa) / 3;
           
            try
            {
                connection.Open();
                string query = "update ds_thi_sinh " +
                    "set hoten =N'"+hoTen.Text+"', toan="+toan+", ly="+ly+",hoa="+hoa+", trungbinh="+tb+" " +
                    "where mathisinh='"+maSo.Text+"'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                this.ds_thi_sinhTableAdapter.Fill(this.danh_sach_thi_sinhDataSet.ds_thi_sinh);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể chỉnh sửa");
                
            }
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)//thêm dữ liệu
        {
            if (maSo.Text != "" && hoTen.Text != "")
                Add();
            else
                MessageBox.Show("Mã Số hoăc tên thí sinh không được để trông");
            this.ds_thi_sinhTableAdapter.Fill(this.danh_sach_thi_sinhDataSet.ds_thi_sinh);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danh_sach_thi_sinhDataSet.ds_thi_sinh' table. You can move, or remove it, as needed.
            this.ds_thi_sinhTableAdapter.Fill(this.danh_sach_thi_sinhDataSet.ds_thi_sinh);
            
        }

        private void bnt_xoa_Click(object sender, EventArgs e)
        {
            delete();
            Lam_Moi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Hide();
            maSo.ReadOnly = true;
            int index = e.RowIndex;
            if (index >=0)
            {
                DataGridViewRow view = dataGridView1.Rows[index];
                maSo.Text = view.Cells[0].Value.ToString();
                hoTen.Text = view.Cells[1].Value.ToString();
                diemToan.Text = view.Cells[2].Value.ToString();
                diemLy.Text = view.Cells[3].Value.ToString();
                diemHoa.Text = view.Cells[4].Value.ToString();
                diemTB.Text = view.Cells[5].Value.ToString();
            }
             if(float.Parse(diemTB.Text) >= 5)
            {
                ketqua.Text = "Đậu";
            }else
            {
                ketqua.Text = "Rớt";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //thoát khỏi chương trình
            Application.Exit();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lam_Moi();
            button1.Show();
            maSo.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "json |*.json";
            saveFile.ShowDialog();
            var json = JsonConvert.SerializeObject(danh_sach_thi_sinhDataSet);
            StreamWriter writer = new StreamWriter(saveFile.FileName);
            writer.Write(json);
            writer.Close();
        }
    }
}

