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
    public partial class FormDashboard : Form
    {
        private Rectangle originalFormSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            originalFormSize = new Rectangle(this.Location.X,this.Location.Y,this.Width,this.Height);
            foreach(Control c in this.Controls)
            {
                originalControlBounds[c] = new Rectangle(c.Location.X,c.Location.Y,c.Width,c.Height);
            }
        }

        void changeSize()
        {
            float xRatio = (float)this.Width / (float)originalFormSize.Width;
            float yRatio = (float)this.Height / (float)originalFormSize.Height;

            foreach(var d in  originalControlBounds)
            {
                Control control = d.Key;
                Rectangle rec = d.Value;

                int newX = (int)(rec.Location.X * xRatio);
                int newY = (int)(rec.Location.Y * yRatio);

                int width = (int)(rec.Width * xRatio);
                int height = (int)(rec.Height * yRatio);

                control.Location = new Point(newX, newY);
                control.Size = new Size(width, height);
            }
        }

        private void FormDashboard_Resize(object sender, EventArgs e)
        {
            changeSize();
        }

    }
}
