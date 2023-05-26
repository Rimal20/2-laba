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
    public partial class Form4 : Form
    {
        public static Form1 form1;
        Ellipse ellipse;
        public Form4()
        {
            InitializeComponent();
        }

        private void ТыкЭлипс_Click(object sender, EventArgs e)
        {
            try
            {
                ellipse = new Ellipse(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), int.Parse(textBoxShir.Text), int.Parse(textBoxVis.Text));
                if (int.Parse(textBoxX.Text) + int.Parse(textBoxShir.Text) <= Init.pictureBox.Width && int.Parse(textBoxY.Text) + int.Parse(textBoxVis.Text) <= Init.pictureBox.Height)
                {
                    ellipse.Draw();
                    ShapeContainer.AddFigure(ellipse);
                    form1.comboBox1.Items.Add(ellipse);
                }
                else MessageBox.Show("Ну это за гранью)");
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            textBoxX.Clear();
            textBoxY.Clear();
            textBoxShir.Clear();
            textBoxVis.Clear();
        }
    }
}
