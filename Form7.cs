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
    public partial class Form7 : Form
    {
        public static Form1 form1;
        Glaz svetofor;
        public Form7()
        {
            InitializeComponent();
        }

        private void ТыкСветофор_Click(object sender, EventArgs e)
        {
            try
            {
                svetofor = new Glaz(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), int.Parse(textBoxShir.Text), int.Parse(textBoxVis.Text));
                if (int.Parse(textBoxX.Text) + int.Parse(textBoxShir.Text) <= Init.pictureBox.Width && int.Parse(textBoxY.Text) + int.Parse(textBoxVis.Text) <= Init.pictureBox.Height)
                {
                    svetofor.Draw();
                    ShapeContainer.AddFigure(svetofor);
                    form1.comboBox1.Items.Add(svetofor);
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
