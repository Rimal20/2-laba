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
    public partial class Form6 : Form
    {
        public static Form1 form1;
        private bool flag;
        private int numPoints;
        Polygon polygon;
        private int i = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonDob_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    numPoints = int.Parse(textBoxKolVo.Text);
                    polygon = new Polygon(numPoints);
                    flag = true;
                    textBoxKolVo.Enabled = false;
                    textBoxX.Enabled = true;
                    textBoxY.Enabled = true;
                    ТыкМногоугольник.Enabled = false;

                }
                else if (i != numPoints && int.Parse(textBoxKolVo.Text) <= Init.pictureBox.Width && int.Parse(textBoxX.Text) <= Init.pictureBox.Height)
                {
                    polygon.pointFs[i].X = int.Parse(textBoxX.Text);
                    polygon.pointFs[i].Y = int.Parse(textBoxY.Text);
                    i++;
                }
                else
                {
                    MessageBox.Show("Ну это за гранью)");
                }
                if (i == numPoints)
                {
                    buttonDob.Enabled = false;
                    ТыкМногоугольник.Enabled = true;
                    flag = false;
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            textBoxX.Clear();
            textBoxY.Clear();
        }

        private void ТыкМногоугольник_Click(object sender, EventArgs e)
        {
            polygon.Draw();
            ShapeContainer.AddFigure(polygon);
            form1.comboBox1.Items.Clear();
            foreach (Figure figur in ShapeContainer.figureList)
            {
                form1.comboBox1.Items.Add(figur);
            }
            textBoxX.Clear();
            textBoxY.Clear();
            textBoxKolVo.Clear();
        }
    }
}
