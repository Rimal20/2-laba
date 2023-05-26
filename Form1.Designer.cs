namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxXPP = new System.Windows.Forms.TextBox();
            this.textBoxYPP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Прямоугольник = new System.Windows.Forms.Button();
            this.Квадрат = new System.Windows.Forms.Button();
            this.Эллипс = new System.Windows.Forms.Button();
            this.Круг = new System.Windows.Forms.Button();
            this.Треугольник = new System.Windows.Forms.Button();
            this.Многоугольник = new System.Windows.Forms.Button();
            this.buttonDell = new System.Windows.Forms.Button();
            this.buttonPerr = new System.Windows.Forms.Button();
            this.Глаз = new System.Windows.Forms.Button();
            this.Зачистить = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(869, 534);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(900, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxXPP
            // 
            this.textBoxXPP.Location = new System.Drawing.Point(927, 49);
            this.textBoxXPP.Name = "textBoxXPP";
            this.textBoxXPP.Size = new System.Drawing.Size(42, 27);
            this.textBoxXPP.TabIndex = 2;
            // 
            // textBoxYPP
            // 
            this.textBoxYPP.Location = new System.Drawing.Point(1011, 49);
            this.textBoxYPP.Name = "textBoxYPP";
            this.textBoxYPP.Size = new System.Drawing.Size(40, 27);
            this.textBoxYPP.TabIndex = 3;
            this.textBoxYPP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(903, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(988, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // Прямоугольник
            // 
            this.Прямоугольник.Location = new System.Drawing.Point(930, 188);
            this.Прямоугольник.Name = "Прямоугольник";
            this.Прямоугольник.Size = new System.Drawing.Size(131, 29);
            this.Прямоугольник.TabIndex = 6;
            this.Прямоугольник.Text = "Прямоугольник";
            this.Прямоугольник.UseVisualStyleBackColor = true;
            this.Прямоугольник.Click += new System.EventHandler(this.Прямоугольник_Click);
            // 
            // Квадрат
            // 
            this.Квадрат.Location = new System.Drawing.Point(930, 223);
            this.Квадрат.Name = "Квадрат";
            this.Квадрат.Size = new System.Drawing.Size(131, 29);
            this.Квадрат.TabIndex = 7;
            this.Квадрат.Text = "Квадрат";
            this.Квадрат.UseVisualStyleBackColor = true;
            this.Квадрат.Click += new System.EventHandler(this.Квадрат_Click);
            // 
            // Эллипс
            // 
            this.Эллипс.Location = new System.Drawing.Point(930, 258);
            this.Эллипс.Name = "Эллипс";
            this.Эллипс.Size = new System.Drawing.Size(131, 29);
            this.Эллипс.TabIndex = 8;
            this.Эллипс.Text = "Эллипс";
            this.Эллипс.UseVisualStyleBackColor = true;
            this.Эллипс.Click += new System.EventHandler(this.Эллипс_Click);
            // 
            // Круг
            // 
            this.Круг.Location = new System.Drawing.Point(930, 293);
            this.Круг.Name = "Круг";
            this.Круг.Size = new System.Drawing.Size(131, 29);
            this.Круг.TabIndex = 9;
            this.Круг.Text = "Круг";
            this.Круг.UseVisualStyleBackColor = true;
            this.Круг.Click += new System.EventHandler(this.Круг_Click);
            // 
            // Треугольник
            // 
            this.Треугольник.Location = new System.Drawing.Point(930, 328);
            this.Треугольник.Name = "Треугольник";
            this.Треугольник.Size = new System.Drawing.Size(131, 29);
            this.Треугольник.TabIndex = 10;
            this.Треугольник.Text = "Треугольник";
            this.Треугольник.UseVisualStyleBackColor = true;
            this.Треугольник.Click += new System.EventHandler(this.Треугольник_Click);
            // 
            // Многоугольник
            // 
            this.Многоугольник.Location = new System.Drawing.Point(930, 363);
            this.Многоугольник.Name = "Многоугольник";
            this.Многоугольник.Size = new System.Drawing.Size(131, 29);
            this.Многоугольник.TabIndex = 11;
            this.Многоугольник.Text = "Многоугольник";
            this.Многоугольник.UseVisualStyleBackColor = true;
            this.Многоугольник.Click += new System.EventHandler(this.Многоугольник_Click);
            // 
            // buttonDell
            // 
            this.buttonDell.Location = new System.Drawing.Point(900, 117);
            this.buttonDell.Name = "buttonDell";
            this.buttonDell.Size = new System.Drawing.Size(151, 29);
            this.buttonDell.TabIndex = 12;
            this.buttonDell.Text = "Удалить ";
            this.buttonDell.UseVisualStyleBackColor = true;
            this.buttonDell.Click += new System.EventHandler(this.buttonDell_Click);
            // 
            // buttonPerr
            // 
            this.buttonPerr.Location = new System.Drawing.Point(900, 82);
            this.buttonPerr.Name = "buttonPerr";
            this.buttonPerr.Size = new System.Drawing.Size(151, 29);
            this.buttonPerr.TabIndex = 13;
            this.buttonPerr.Text = "Переместить";
            this.buttonPerr.UseVisualStyleBackColor = true;
            this.buttonPerr.Click += new System.EventHandler(this.buttonPerr_Click);
            // 
            // Глаз
            // 
            this.Глаз.Location = new System.Drawing.Point(900, 476);
            this.Глаз.Name = "Глаз";
            this.Глаз.Size = new System.Drawing.Size(94, 29);
            this.Глаз.TabIndex = 14;
            this.Глаз.Text = "Глаз";
            this.Глаз.UseVisualStyleBackColor = true;
            this.Глаз.Click += new System.EventHandler(this.Глаз_Click);
            // 
            // Зачистить
            // 
            this.Зачистить.Location = new System.Drawing.Point(900, 152);
            this.Зачистить.Name = "Зачистить";
            this.Зачистить.Size = new System.Drawing.Size(151, 29);
            this.Зачистить.TabIndex = 15;
            this.Зачистить.Text = "Зачистить";
            this.Зачистить.UseVisualStyleBackColor = true;
            this.Зачистить.Click += new System.EventHandler(this.Зачистить_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1073, 558);
            this.Controls.Add(this.Зачистить);
            this.Controls.Add(this.Глаз);
            this.Controls.Add(this.buttonPerr);
            this.Controls.Add(this.buttonDell);
            this.Controls.Add(this.Многоугольник);
            this.Controls.Add(this.Треугольник);
            this.Controls.Add(this.Круг);
            this.Controls.Add(this.Эллипс);
            this.Controls.Add(this.Квадрат);
            this.Controls.Add(this.Прямоугольник);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYPP);
            this.Controls.Add(this.textBoxXPP);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        public ComboBox comboBox1;
        private TextBox textBoxXPP;
        private TextBox textBoxYPP;
        private Label label1;
        private Label label2;
        private Button Прямоугольник;
        private Button Квадрат;
        private Button Эллипс;
        private Button Круг;
        private Button Треугольник;
        private Button Многоугольник;
        private Button buttonDell;
        private Button buttonPerr;
        private Button Глаз;
        private Button Зачистить;
    }
}