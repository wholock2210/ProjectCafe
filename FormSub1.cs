using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCafe
{

    public partial class Order : Form
    {
        private Rectangle originalFormSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        public Order()
        {
            InitializeComponent();
        }

        private void FormSub1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            foreach (Control c in this.Controls)
            {
                originalControlBounds[c] = new Rectangle(c.Location.X, c.Location.Y, c.Width, c.Height);
            }
        }

        void ChangeSizeControls()
        {
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            
            foreach (var kvp in originalControlBounds)
            {
                Control control = kvp.Key;
                Rectangle originalBounds = kvp.Value;

                int newX = (int)(originalBounds.X * xRatio);
                int newY = (int)(originalBounds.Y * yRatio);
                int newWidth = (int)(originalBounds.Width * xRatio);
                int newHeight = (int)(originalBounds.Height * yRatio);

                control.Location = new Point(newX, newY);
                control.Size = new Size(newWidth, newHeight);
            }
        }

        private void Order_Resize(object sender, EventArgs e)
        {
            ChangeSizeControls();
            bigLabel1.Text = $"X = {MdiParent.Location.X} | Y = {MdiParent.Location.Y}\nchild\nX = {this.Location.X} | Y = {this.Location.Y}";
        }
    }
}
