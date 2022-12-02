using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace animatiecucontroaleseparate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlanimat1.movetoLeftN(200);
            //Task<int> task1 = new Task<int>(() =>
            //{
            //    controlanimat1.movetoLeftN(200);
            //    return 0;
            //});
           
            //task1.Start();
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlanimat2.movetoLeftN(300);
            //Task<int> task1 = new Task<int>(() =>
            //{
            //    controlanimat2.movetoLeftN(300);
            //    return 0;
            //});
            
            //task1.Start();

        }
    }
}
