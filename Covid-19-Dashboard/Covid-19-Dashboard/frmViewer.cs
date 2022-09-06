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
    public partial class frmViewer : Form
    {
        public frmViewer()
        {
            InitializeComponent();
        }

        public void loadDashboard(string fileName)
        {
            dashboardViewer1.LoadDashboard(fileName);
        }

        private void frmViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
