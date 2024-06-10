using _02_pPictureProje.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_pPictureProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pbImage.Image = Resources.Boy;
        //    pbImage.Image = Properties.Resources.Boy;
            label1.Text = "Boy";
          //  pbImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            pbImage.Image =Resources.Book;
            label1.Text = "Book";
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            pbImage.Image = Resources.Girl;
            label1.Text = "Girl";
            //pbImage.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            pbImage.Image = Resources.Pen;
            label1.Text = "Pen";
          //  pbImage.SizeMode = PictureBoxSizeMode.Zoom; 
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }
    }
}
