using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PointOfSale
{
    public class RoundTxtbox : UserControl
    {
        private TextBox textBox;
        private int borderRadius = 15; // Default radius
        private int borderWidth = 2;   // Border width
        private string placeholderText = "Enter text..."; // Default placeholder text
        private bool isPlaceholderActive = true; // Flag to check if the placeholder is active
        private char passwordChar = '\0'; // Default no password char

        // Event to notify when Enter key is pressed
        public event EventHandler EnterKeyPressed;

        // Event to notify when text changes
        public new event EventHandler TextChanged;

        public RoundTxtbox()
        {
            // Set properties for the UserControl
            this.BackColor = Color.Transparent;
            this.Padding = new Padding(10);

            // Initialize the TextBox and add it to the control
            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Multiline = false,
                BackColor = Color.White,
                ForeColor = Color.Gray, // Placeholder color
                Font = new Font("Arial", 12),
                Dock = DockStyle.Fill,
                Text = placeholderText // Set initial text to placeholder
            };
            this.Controls.Add(textBox);

            // Set default size
            this.Size = new Size(200, 40);

            // Add event handlers for focus and leave events
            textBox.GotFocus += RemovePlaceholder;
            textBox.LostFocus += SetPlaceholder;

            // Attach KeyDown event handler for Enter key detection
            textBox.KeyDown += TextBox_KeyDown;

            // Attach TextChanged event of the internal textbox to the control's own TextChanged event
            textBox.TextChanged += (sender, e) => TextChanged?.Invoke(this, e);

            // Enable optimized double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true); // Redraw on resize
            this.SetStyle(ControlStyles.UserPaint, true);    // Use custom painting
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;

            // Initialize with placeholder active
            SetPlaceholderState();
        }

        // Property to adjust border radius
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate(); // Redraw when radius is changed
            }
        }

        // Property to get/set placeholder text
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                if (isPlaceholderActive)
                {
                    SetPlaceholderState();
                }
            }
        }

        // Property to get/set password character
        public char PasswordChar
        {
            get => passwordChar;
            set
            {
                passwordChar = value;
                if (!isPlaceholderActive)
                {
                    textBox.PasswordChar = passwordChar; // Set the password char of the inner TextBox only if not in placeholder mode
                }
            }
        }

        // Override Text property to handle placeholder logic
        public new string Text
        {
            get => isPlaceholderActive ? string.Empty : textBox.Text;
            set
            {
                isPlaceholderActive = string.IsNullOrEmpty(value);
                if (isPlaceholderActive)
                {
                    SetPlaceholderState();
                }
                else
                {
                    textBox.Text = value;
                    textBox.ForeColor = Color.Black;
                    textBox.PasswordChar = passwordChar;
                }
            }
        }

        // Remove placeholder when the user focuses on the textbox
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
                textBox.PasswordChar = passwordChar; // Set password char when user starts typing
                isPlaceholderActive = false;
            }
        }

        // Restore placeholder when the textbox loses focus and is empty
        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                SetPlaceholderState();
            }
        }

        // Set the placeholder state and remove password masking
        private void SetPlaceholderState()
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;
            textBox.PasswordChar = '\0'; // Remove password char for placeholder
            isPlaceholderActive = true;
        }

        // KeyDown event handler for the inner TextBox
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // If Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Raise the EnterKeyPressed event
                EnterKeyPressed?.Invoke(this, EventArgs.Empty);
                e.Handled = true; // Mark the event as handled if needed
            }
        }

        // Override OnPaint to create a round border
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Define rectangle for the rounded border
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = GetRoundedRectPath(rect, borderRadius))
            {
                // Draw background (inside the border)
                using (Brush brush = new SolidBrush(Color.White))
                {
                    g.FillPath(brush, path);
                }

                // Draw border
                using (Pen pen = new Pen(Color.Gray, borderWidth))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        // Method to create a rounded rectangle
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

        // Override OnResize to redraw the control when its size changes
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Redraw the control when it's resized
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RoundTxtbox
            // 
            this.Name = "RoundTxtbox";
            this.Size = new System.Drawing.Size(587, 403);
            this.ResumeLayout(false);
        }
    }
}
