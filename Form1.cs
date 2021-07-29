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
        class BritPic
        {
            public int picNum { get; set; }
            public float xLoc { get; set; }
            public float yLoc { get; set; }
            public float speed { get; set; }
        }

        List<Image> pics = new List<Image>();
        List<BritPic> britPics = new List<BritPic>();
        Random rand = new Random();

        

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

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void YeYScreenSaver_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("pics");
            foreach (string item in images)
            {
                Image i = new Bitmap(item);

                i = resizeImage(i, new Size(200,200));

                pics.Add(i);

            }


            for (int i = 0; i < 3000; i++)
            {
                BritPic mp = new BritPic();
                mp.picNum = i % pics.Count;
                mp.xLoc = rand.Next(0, Width);
                mp.yLoc = rand.Next(0, Height);
                britPics.Add(mp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void YeYScreenSaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in britPics)
            {
                e.Graphics.DrawImage(pics[bp.picNum],bp.xLoc,bp.yLoc);
                bp.xLoc -= 2;
                if (bp.xLoc < -250)
                {
                    bp.xLoc =Width + rand.Next(20,100);
                }
            }
        }
    }
}
