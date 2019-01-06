using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigNumBer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cal_Click(object sender, EventArgs e)
        {
            BigInt a = new BigInt(inputA.Text);
            BigInt b = new BigInt(inputB.Text);
            BigInt ketqua = new BigInt().Cong(a,b);

            KetQua.Text = ketqua.value ;
        }
    }
}
