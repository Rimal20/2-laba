namespace WinFormsApp1
{
    partial class Form4
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
            this.textBoxVis = new System.Windows.Forms.TextBox();
            this.textBoxShir = new System.Windows.Forms.TextBox();
            this.ТыкЭлипс = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(270, 42);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(125, 27);
            this.textBoxX.TabIndex = 0;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(270, 75);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(125, 27);
            this.textBoxY.TabIndex = 1;
            // 
            // textBoxVis
            // 
            this.textBoxVis.Location = new System.Drawing.Point(270, 123);
            this.textBoxVis.Name = "textBoxVis";
            this.textBoxVis.Size = new System.Drawing.Size(125, 27);
            this.textBoxVis.TabIndex = 2;
            // 
            // textBoxShir
            // 
            this.textBoxShir.Location = new System.Drawing.Point(270, 156);
            this.textBoxShir.Name = "textBoxShir";
            this.textBoxShir.Size = new System.Drawing.Size(125, 27);
            this.textBoxShir.TabIndex = 3;
            // 
            // ТыкЭлипс
            // 
            this.ТыкЭлипс.Location = new System.Drawing.Point(270, 201);
            this.ТыкЭлипс.Name = "ТыкЭлипс";
            this.ТыкЭлипс.Size = new System.Drawing.Size(125, 29);
            this.ТыкЭлипс.TabIndex = 4;
            this.ТыкЭлипс.Text = "Кликай";
            this.ТыкЭлипс.UseVisualStyleBackColor = true;
            this.ТыкЭлипс.Click += new System.EventHandler(this.ТыкЭлипс_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите Х";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите У";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ширина";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ТыкЭлипс);
            this.Controls.Add(this.textBoxShir);
            this.Controls.Add(this.textBoxVis);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxX;
        private TextBox textBoxY;
        private TextBox textBoxVis;
        private TextBox textBoxShir;
        private Button ТыкЭлипс;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}