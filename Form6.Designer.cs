namespace WinFormsApp1
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxKolVo = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonDob = new System.Windows.Forms.Button();
            this.ТыкМногоугольник = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKolVo
            // 
            this.textBoxKolVo.Location = new System.Drawing.Point(310, 20);
            this.textBoxKolVo.Name = "textBoxKolVo";
            this.textBoxKolVo.Size = new System.Drawing.Size(125, 27);
            this.textBoxKolVo.TabIndex = 0;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(310, 82);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(125, 27);
            this.textBoxX.TabIndex = 1;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(310, 115);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(125, 27);
            this.textBoxY.TabIndex = 2;
            // 
            // buttonDob
            // 
            this.buttonDob.Location = new System.Drawing.Point(231, 161);
            this.buttonDob.Name = "buttonDob";
            this.buttonDob.Size = new System.Drawing.Size(125, 34);
            this.buttonDob.TabIndex = 3;
            this.buttonDob.Text = "Добавить точку";
            this.buttonDob.UseVisualStyleBackColor = true;
            this.buttonDob.Click += new System.EventHandler(this.buttonDob_Click);
            // 
            // ТыкМногоугольник
            // 
            this.ТыкМногоугольник.Location = new System.Drawing.Point(384, 161);
            this.ТыкМногоугольник.Name = "ТыкМногоугольник";
            this.ТыкМногоугольник.Size = new System.Drawing.Size(125, 34);
            this.ТыкМногоугольник.TabIndex = 4;
            this.ТыкМногоугольник.Text = "Нарисовать";
            this.ТыкМногоугольник.UseVisualStyleBackColor = true;
            this.ТыкМногоугольник.Click += new System.EventHandler(this.ТыкМногоугольник_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во вершин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Координата по Х";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Координата по У ";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ТыкМногоугольник);
            this.Controls.Add(this.buttonDob);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxKolVo);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxKolVo;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Button buttonDob;
        private Button ТыкМногоугольник;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}