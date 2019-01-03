using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_bai_6
{
    class KhachSan:Nguoi
    {
        int soNgayTro;
        double giaPhong;
        
        public KhachSan()
        {

        }
       
        /// <summary>
        /// Nhập thông tin của phòng trọ
        /// </summary>
        /// <param name="nt">Ngày trọ</param>
        /// <param name="lp">loại phòng</param>
        /// <param name="gp">giá phòng</param>
        public void Nhap(string nt, string lp, string gp)
        {
            int.TryParse(nt, out soNgayTro);
            LoaiPhong = lp;
            double.TryParse(gp, out giaPhong);            
        }
        public int NgayTro => soNgayTro;
        public string LoaiPhong { get; private set; }
        public double GiaPhong => giaPhong;
    }
}
