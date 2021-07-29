using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class YeYScreenSaver : Form
    {
        public YeYScreenSaver()
        {
            InitializeComponent();
        }

        private void YeYScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void YeYScreenSaver_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
