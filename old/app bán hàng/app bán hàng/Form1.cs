using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_bán_hàng
{
    public partial class Form1 : Form
    {
        Home home = new Home();
        Label label = new Label();
        public Form1()
        {
            InitializeComponent();
            btn_home.MouseDown += new MouseEventHandler(panel4_MouseClick);
            btn_menu.MouseDown += new MouseEventHandler(panel4_MouseClick);
            btn_cart.MouseDown += new MouseEventHandler(panel4_MouseClick);            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home.Parent = panel_main;
            home.Show();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            panel_selection.Location = new Point(panel_selection.Location.X, b.Location.Y);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            home.Show();
            label.Hide();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            home.Hide();
            label.Parent = panel_main;
            label.Show();
            
            label.Text = "chưa làm";
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            home.Hide();
            label.Parent = panel_main;
            label.Show();
            label.Text = "chưa làm";
        }
    }
}
