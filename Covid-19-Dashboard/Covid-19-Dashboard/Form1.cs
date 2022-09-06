using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19_Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmdesigner f = new frmdesigner();
            f.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string fileName;
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName;
            frmViewer f = new frmViewer();
            f.Show();
            f.loadDashboard(fileName);
        }
    }
}
