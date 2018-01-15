using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV
{
    public partial class StartTest : Form
    {
        public StartTest()
        {
            InitializeComponent();
        }

        private void StartTest_Load(object sender, EventArgs e)
        {
            new ControlEnd();
        }

        private void StartTest_Activated(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
