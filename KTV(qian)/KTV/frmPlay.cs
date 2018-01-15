using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTV.sys;
using System.Collections;
using AxWMPLib;
using WMPLib;

namespace KTV
{
    public partial class frmPlay : Form
    {
        private static frmPlay frmplay =new frmPlay();
        public static ArrayList mvList = new ArrayList();
        public frmPlay()
        {
            InitializeComponent();
        }

        private void frmPlay_Load(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}
