using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace animatiecucontroaleseparate
{
    public partial class controlanimat : UserControl
    {
        public controlanimat()
        {
            InitializeComponent();
        }

       

        public void movetoLeftN(int n)
        {
            while (Left>0)
            {
                Left -= 1;
                Thread.Sleep(10);
            }
        }
        public void movetoRightN(int n)
        {
            while (Left <800)
            {
                Left += 1;
                Thread.Sleep(10);
            }
        }

        private void controlanimat_Load(object sender, EventArgs e)
        {

        }
    }
}
