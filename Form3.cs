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
    public partial class Form3 : Form
    {
        public static Form1 form1;
        Square square;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ТыкКвадрат_Click(object sender, EventArgs e)
        {
            try
            {
                square = new Square(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), int.Parse(textBoxVis.Text));
                if (int.Parse(textBoxX.Text) + int.Parse(textBoxVis.Text) <= Init.pictureBox.Width && int.Parse(textBoxY.Text) + int.Parse(textBoxVis.Text) <= Init.pictureBox.Height)
                {
                    square.Draw();
                    ShapeContainer.AddFigure(square);
                    form1.comboBox1.Items.Add(square);

                }
                else MessageBox.Show("Ну это за гранью)");
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            textBoxX.Clear();
            textBoxY.Clear();
            textBoxVis.Clear();
        }
    }
}
