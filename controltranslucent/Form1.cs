using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace controltranslucent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int ismd = 0;

        private void userControl11_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void userControl11_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }

        private void userControl11_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void userControl11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
