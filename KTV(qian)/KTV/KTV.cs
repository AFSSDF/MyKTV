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

namespace KTV
{
    public partial class KTV : Form
    {
        MvInfo nowMv = new MvInfo();
        MvInfo nextMv = new MvInfo();
        public KTV()
        {
            InitializeComponent();
        }

        private void KTV_Load(object sender, EventArgs e)
        {
           
        }

        public static void SetEx(int cmd,MvInfo mvInfo)
        {
            switch (cmd)
            {
                case ExCmd.CMD_PLAY:
                    break;
                case ExCmd.CMD_PAUSE:
                    break;
                case ExCmd.CMD_RESET:
                    break;
                case ExCmd.CMD_NEXT:
                    break;
            }
        }
    }
}
