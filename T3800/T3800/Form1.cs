using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T3800.T3800.SqlService;

namespace T3800
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //初始化

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLConnect.GetSQLConnectInstance();
        }
    }
}
