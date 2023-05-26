using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form

    {
        public static Form1 form1;
        Circle circle;
        public Form5()
        {
            InitializeComponent();
        }

        private void ТыкКруг_Click(object sender, EventArgs e)
        {
            try
            {
                circle = new Circle(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), int.Parse(textBoxD.Text));
                if (int.Parse(textBoxX.Text) + int.Parse(textBoxD.Text) <= Init.pictureBox.Width && int.Parse(textBoxY.Text) + int.Parse(textBoxD.Text) <= Init.pictureBox.Height)
                {
                    circle.Draw();
                    ShapeContainer.AddFigure(circle);
                    form1.comboBox1.Items.Add(circle);
                }
                else MessageBox.Show("Ну это за гранью)");
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            textBoxX.Clear();
            textBoxY.Clear();
            textBoxD.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
