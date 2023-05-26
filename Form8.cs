using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form8 : Form
    {
        public static Form1 form1;
        private int numPoints;
        Triangle triangle;
        private int i = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void buttonDob_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxX.Text) <= Init.pictureBox.Width && int.Parse(textBoxY.Text) <= Init.pictureBox.Height)
                {
                    if (i == 0)
                    {
                        this.triangle = new Triangle(3);
                    }
                    triangle.pointFs[i].X = int.Parse(textBoxX.Text);
                    triangle.pointFs[i].Y = int.Parse(textBoxY.Text);
                    i++;
                }
                if (i == 3)
                {
                    ТыкТреугольник.Enabled = true;
                    buttonDob.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            textBoxX.Clear();
            textBoxY.Clear();
        }

        private void ТыкТреугольник_Click(object sender, EventArgs e)
        {
            triangle.Draw();
            ShapeContainer.AddFigure(triangle);
            form1.comboBox1.Items.Clear();
            foreach (Figure figur in ShapeContainer.figureList)
            {
                form1.comboBox1.Items.Add(figur);
            }
            textBoxX.Clear();
            textBoxY.Clear();
        }
    }
}
