using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
/* - kết nối database
 * - xuất dữ liệu từ database ra màn hình
 * - thêm, xóa dữ liệu
 * - 
 */
namespace trainee_24_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string sql = @"Data Source=KHOATHU\SQLdatabase;Initial Catalog=kakoi;Integrated Security=True";
            string hienthi = "select * from sanpham";
            SqlConnection connection = new SqlConnection(sql);
            SqlCommand command = new SqlCommand(hienthi,connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            try
            {
                connection.Open();
                Console.WriteLine("ket noi thanh cong");
                Console.WriteLine("==============================================");
                Console.WriteLine("|Tên Mặt Hàng       |Giá           |Số Lượng |");
                Console.WriteLine("==============================================");
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine("|{0,-19}|{1,-14}|{2,-9}|",row[1],row[2],row[3]);
                    
                }
                Console.WriteLine("==============================================");
                
            }
            catch (Exception)
            {
                Console.WriteLine("Ket noi that bai");
            }
            Console.ReadKey();
        }
    }
}
