namespace WinFormsApp1
{
    partial class Form8
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
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonDob = new System.Windows.Forms.Button();
            this.ТыкТреугольник = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(304, 12);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(125, 27);
            this.textBoxX.TabIndex = 0;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(304, 61);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(125, 27);
            this.textBoxY.TabIndex = 1;
            // 
            // buttonDob
            // 
            this.buttonDob.Location = new System.Drawing.Point(243, 111);
            this.buttonDob.Name = "buttonDob";
            this.buttonDob.Size = new System.Drawing.Size(99, 29);
            this.buttonDob.TabIndex = 2;
            this.buttonDob.Text = "Добавить точку";
            this.buttonDob.UseVisualStyleBackColor = true;
            this.buttonDob.Click += new System.EventHandler(this.buttonDob_Click);
            // 
            // ТыкТреугольник
            // 
            this.ТыкТреугольник.Location = new System.Drawing.Point(370, 111);
            this.ТыкТреугольник.Name = "ТыкТреугольник";
            this.ТыкТреугольник.Size = new System.Drawing.Size(102, 29);
            this.ТыкТреугольник.TabIndex = 3;
            this.ТыкТреугольник.Text = "Нарисовать ";
            this.ТыкТреугольник.UseVisualStyleBackColor = true;
            this.ТыкТреугольник.Click += new System.EventHandler(this.ТыкТреугольник_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Координата по Х";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Координата по У";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ТыкТреугольник);
            this.Controls.Add(this.buttonDob);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxX;
        private TextBox textBoxY;
        private Button buttonDob;
        private Button ТыкТреугольник;
        private Label label1;
        private Label label2;
    }
}