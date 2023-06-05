namespace Risovka_05._06._23_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MyDraw(Graphics g, int N, int x, int y, int r)
        {
            if (N == 0)
                return;
            else
            {
                int LevX = x - r;
                int LevY = y - r;
                g.DrawEllipse(new Pen(Brushes.Blue, 2), LevX, LevY, r * 2, r * 2);
                r -= 14;
                MyDraw(g, N - 1, x, y, r);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MyDraw(g, 7, 225, 150, 100);

        }
    }
}