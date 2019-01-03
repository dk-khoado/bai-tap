using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace oop_bai_6
{
    class QL
    {
        public List<KhachSan> save = new List<KhachSan>();
        public QL()
        {
            
        }
        
        public void Nhap(KhachSan ks)
        {
            save.Add(ks);
        }
        public void Save(string path)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path);
                var json = JsonConvert.SerializeObject(save);
                writer.Write(json);
                writer.Close();
            }
            catch (Exception)
            {
                
            }           
        }
        /// <summary>
        /// xóa khách hàng
        /// </summary>
        /// <param name="index">số thứ tự khách hàng</param>
        public void Delete(int index)
        {
            save.RemoveAt(index);
        }
    }
}
