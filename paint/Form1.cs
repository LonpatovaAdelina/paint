using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*btnStartDrawing.MouseEnter += (s, e) => {
                btnStartDrawing.BackColor = Color.Pink;
            };
            btnStartDrawing.MouseLeave += (s, e) => {
                btnStartDrawing.BackColor = Color.FromKnownColor(KnownColor.Control);
            };*/
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MouseHover
        }
    }
}