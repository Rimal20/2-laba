using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public static Form1 form1;

        Rectangle rectangle;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rectangle = new Rectangle(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), int.Parse(textBoxShir.Text), int.Parse(textBoxVis.Text));
                if (int.Parse(textBoxX.Text) + int.Parse(textBoxShir.Text) <= Init.pictureBox.Width && int.Parse(textBoxY.Text) + int.Parse(textBoxVis.Text) <= Init.pictureBox.Height)
                {
                    rectangle.Draw();
                    ShapeContainer.AddFigure(rectangle);
                    form1.comboBox1.Items.Add(rectangle);





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
            Form2 form2 = new Form2();
            form2.Close();
        }
    }
}
