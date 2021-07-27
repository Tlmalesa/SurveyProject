using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAssignment
{
    public partial class Screen1 : Form
    {
        public Screen1()
        {
            InitializeComponent();
        }

        private void Screen1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFillSurvey_Click(object sender, EventArgs e)
        {
            Screen2 s2 = new Screen2();
            this.Hide();
            s2.Show();
        }

        private void btnViewSurvey_Click(object sender, EventArgs e)
        {
            Screen3 s3 = new Screen3();
            this.Hide();
            s3.Show();
        }
    }
}
