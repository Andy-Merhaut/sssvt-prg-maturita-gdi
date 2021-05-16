using System.Drawing;
using System.Windows.Forms;

namespace MaturitaGDI
{
    public partial class MainForm : Form
    {
        private Pen _blackPen = new Pen(Color.Black);
        private Font _arialFont = new Font("Arial", 12);
        private SolidBrush _redBrush = new SolidBrush(Color.Red);

        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Point a = new Point(100, 50);
            Point b = new Point(200, 50);
            int width = 75;
            int height = 50;

            this.DrawLine(e.Graphics, this._blackPen, a, b);
            this.DrawRectagle(e.Graphics, this._blackPen, a.X + 20, a.Y + 10, width, height);
            this.DrawString(e.Graphics, "Ahoj text", this._arialFont, this._redBrush, a.X + 25, a.Y + 15);
        }

        private void DrawLine(Graphics graphics, Pen pen, Point a, Point b)
        {
            graphics.DrawLine(pen, a, b);
        }

        private void DrawRectagle(Graphics graphics, Pen pen, int x, int y, int width, int height)
        {
            graphics.DrawRectangle(pen, x, y, width, height);
        }

        private void DrawString(Graphics graphics, string text, Font font, SolidBrush brush, int x, int y)
        {
            graphics.DrawString(text, font, brush, x, y);
        }
    }
}
