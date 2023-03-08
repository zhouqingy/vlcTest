using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vlcTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "视频文件(*.mp4)|*.mp4";
            of.RestoreDirectory = false;
            if(of.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = of.FileName;

                vlcControl1.SetMedia(new System.IO.FileInfo(of.FileName));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vlcControl1.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }
    }
}
