using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PointOfSale
{
    public class RoundComboBox : ComboBox
    {
        private Color borderColor = Color.Gray;      // Default border color
        private Color arrowColor = Color.Gray;       // Default arrow color
        private Color backgroundColor = Color.White; // Default background color
        private Color textColor = Color.Black;       // Default text color

        // Constructor
        public RoundComboBox()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList; // Read-only combo box
            this.FlatStyle = FlatStyle.Flat;                 // Flat style for custom drawing
            this.BackColor = backgroundColor;                // Set the background color
            this.ForeColor = textColor;                      // Set the text color
            this.Font = new Font("Arial", 12);               // Font customization
            this.DrawMode = DrawMode.OwnerDrawFixed;         // Custom drawing of items
            this.ItemHeight = 25;                            // Item height
            this.DropDownHeight = 100;                       // Dropdown height
        }

        // Property to customize border color
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();  // Redraw the control
            }
        }

        // Property to customize arrow color
        public Color ArrowColor
        {
            get { return arrowColor; }
            set
            {
                arrowColor = value;
                this.Invalidate();  // Redraw the control
            }
        }

        // Property to customize background color
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                this.BackColor = backgroundColor;
                this.Invalidate();  // Redraw the control
            }
        }

        // Property to customize text color
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.ForeColor = textColor;
                this.Invalidate();  // Redraw the control
            }
        }

        // Override OnPaint to customize ComboBox appearance
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Create a rounded rectangle for the ComboBox
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = GetRoundedRectPath(rect, 15))
            {
                g.FillPath(new SolidBrush(backgroundColor), path);
                g.DrawPath(new Pen(borderColor, 2), path);
            }

            // Draw the arrow
            DrawArrow(g);
        }

        // Override OnDrawItem to customize item appearance in the dropdown list
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            e.DrawBackground();

            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Set the text color based on selection
                string itemText = this.GetItemText(this.Items[e.Index]);
                Color itemTextColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? Color.White : textColor;
                g.DrawString(itemText, this.Font, new SolidBrush(itemTextColor), e.Bounds);

                // Set the background color for the selected item
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    g.FillRectangle(new SolidBrush(Color.Gray), e.Bounds);
                }
            }
        }

        // Method to draw a downward arrow for the ComboBox
        private void DrawArrow(Graphics g)
        {
            int arrowWidth = 10;
            int arrowHeight = 6;
            Point[] arrowPoints =
            {
                new Point(this.Width - 20, (this.Height - arrowHeight) / 2),
                new Point(this.Width - 10, (this.Height - arrowHeight) / 2),
                new Point(this.Width - 15, (this.Height + arrowHeight) / 2)
            };
            g.FillPolygon(new SolidBrush(arrowColor), arrowPoints);
        }

        // Method to create rounded rectangle
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int arcWidth = radius * 2;

            // Top-left arc
            path.AddArc(rect.X, rect.Y, arcWidth, arcWidth, 180, 90);

            // Top-right arc
            path.AddArc(rect.Right - arcWidth, rect.Y, arcWidth, arcWidth, 270, 90);

            // Bottom-right arc
            path.AddArc(rect.Right - arcWidth, rect.Bottom - arcWidth, arcWidth, arcWidth, 0, 90);

            // Bottom-left arc
            path.AddArc(rect.X, rect.Bottom - arcWidth, arcWidth, arcWidth, 90, 90);

            path.CloseFigure();
            return path;
        }

        // Override OnResize to redraw the ComboBox when its size changes
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();  // Redraw the control when it's resized
        }
    }
}
