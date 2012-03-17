using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EveOnline.control
{
    public class PointImage : Control
   {
        private bool IsHover = false;
        private Pen selectPen = new Pen(Brushes.Red, 5);
        public event EventHandler OnSelect;

        public void InvokeOnSelect(EventArgs e)
        {
            EventHandler handler = OnSelect;
            if (handler != null) handler(this, e);
        }

        public PointImage()
        {
            ControlMover.Init(this, this, ControlMover.Direction.Any);
            MouseDown += delegate(object sender, MouseEventArgs e)
                             {
                                 var handler = OnSelect;
                                 if (handler != null) handler(this, EventArgs.Empty);
                             };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            if (IsHover)
                e.Graphics.DrawRectangle(selectPen, 0, 0, Width - 1, Height - 1);

            e.Graphics.DrawRectangle(Pens.Red, 0, 0, Width - 1, Height - 1);
            e.Graphics.FillRectangle(Brushes.Green, Width - 5, Height - 5, Width - 1, Height - 1);
            
        }

        protected override void OnMouseHover(System.EventArgs e)
        {
            if (!IsHover)
            {
                IsHover = true;
                Invalidate();
            }
            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            if (IsHover)
            {
                IsHover = false;
                Invalidate();
            }
            base.OnMouseLeave(e);
        }
    }
}
