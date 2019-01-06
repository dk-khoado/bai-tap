using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_bai2
{
    public class CanBo
    {
        string hoten, diaChi;
        bool gioiTinh;
        int namSinh;

    }
    public class CongNhan : CanBo
    {
        protected string[] bac = new string[7] {"Bậc 1", "Bậc 2" , "Bậc 3" , "Bậc 4" , "Bậc 5" , "Bậc 6" , "Bậc 7"};  
        public CongNhan()
        {

        }
    }
    public class KySu : CanBo
    {
        string nganhDaoTao;
        public KySu()
        {

        }
    }
    public class NhanVien :CanBo
    {
        string congViet;
        public NhanVien()
        {

        }
    }
    public class QLCB
    {

    }
}
