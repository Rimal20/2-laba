namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2.form1 = this;
            Form3.form1 = this;
            Form4.form1 = this;
            Form5.form1 = this;
            Form6.form1 = this;
            Form7.form1 = this;
            Form8.form1 = this;

            Bitmap bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Pen pen = new Pen(Color.Black, 1);
            Init.bitmap = bitmap;
            Init.pen = pen;
            Init.pictureBox = pictureBox1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Прямоугольник_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2.Close();
        }

        private void Квадрат_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            form3.Close();
        }

        private void Эллипс_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            form4.Close();
        }

        private void Круг_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
            form5.Close();
        }

        private void Треугольник_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
            form8.Close();
        }

        private void Многоугольник_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
            form6.Close();
        }

        private void Глаз_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
            form7.Close();
        }

        private void Зачистить_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
            Init.pictureBox.Image = Init.bitmap;

            ShapeContainer.figureList.Clear();
        }

        private void buttonDell_Click(object sender, EventArgs e)
        {
            Figure figure = (Figure)comboBox1.SelectedItem;
            figure.DeleteF(figure);
            comboBox1.Items.Clear();
            foreach (Figure figur in ShapeContainer.figureList)
            {
                comboBox1.Items.Add(figur);
            }
        }

        private void buttonPerr_Click(object sender, EventArgs e)
        {
            Figure figure = (Figure)comboBox1.SelectedItem;
            figure.MoveTo(int.Parse(textBoxXPP.Text), int.Parse(textBoxYPP.Text));
            textBoxXPP.Clear();
            textBoxYPP.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}