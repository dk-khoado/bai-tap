using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_bai_6
{
    class Nguoi
    {
        public string HoTen { get; private set; }
        public string NamSinh { get; private set; }
        string cmnn;
        public Nguoi()
        {

        }
        /// <summary>
        /// nhập thông tin khách hàng
        /// </summary>
        /// <param name="ht">họ tên</param>
        /// <param name="ns">năm sinh</param>
        /// <param name="cm">chứng minh</param>
        public void NhapInfo(string ht, string ns, string cm)
        {
            HoTen = ht;
            NamSinh = ns;
            cmnn = cm;
        }

        
        public string CMNN => cmnn;

    }
}
