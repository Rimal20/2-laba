using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Glaz : Figure
    {
        public Ellipse pr;
        public Circle el1;
        public Circle el2;


        public Glaz(int x, int y, int w, int h)
        {
            this.pr = new Ellipse(x, y, w, h);
            this.el1 = new Circle(x + w / 3, y + h / 3,w /5);
            this.el2 = new Circle(x + 2 * w / 5, y + 2 * h / 5, w / 10);

        }
        public override void Draw()
        {
            this.pr.Draw();
            this.el1.Draw();
            this.el2.Draw();
            Init.pictureBox.Image = Init.bitmap;
        }

        public override void MoveTo(int x, int y)
        {
            if (!((this.pr.x + x < 0 && this.pr.y + y < 0) || (this.pr.y + y < 0)
                || (this.pr.x + x > Init.pictureBox.Width && this.pr.y + y < 0)
                || (this.pr.x + this.pr.w + x > Init.pictureBox.Width)
                || (this.pr.x + x > Init.pictureBox.Width && this.pr.y + y > Init.pictureBox.Height)
                || (this.pr.y + this.pr.h + y > Init.pictureBox.Height)
                || (this.pr.x + x < 0 && this.pr.y + y > Init.pictureBox.Height) || (this.pr.x + x < 0)))
            {
                this.el1.x += x;
                this.el1.y += y;
                this.el2.x += x;
                this.el2.y += y;
                this.pr.x += x;
                this.pr.y += y;
                ;
                this.DeleteF(this, false);
                this.Draw();
            }
        }
    }
}
