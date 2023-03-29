using System.Windows.Forms;

namespace Fibonnaci_Final
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = 1;

        public Form1()
        {
            InitializeComponent();
        }

        public ulong fib(int index)
        {
            List<ulong> fib = new List<ulong>();
            fib.Add(1);
            fib.Add(1);
            for (int x = 1; x < index; x++)
            {
                fib.Add(fib[x] + fib[x - 1]);
            }
            return fib[index];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void drawRect()
        {

            var rand = new Random();
            int formHeight = this.Height;
            int formWidth = this.Width;
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            int count = Convert.ToInt32(fib(Convert.ToInt32(x) - 1));
            for (int i = 0; i < count; i++)
            {
                SolidBrush randBrush = new SolidBrush(Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256)));
                Rectangle rect = new Rectangle(0 + (i * formWidth / count), 0, formWidth / count, formHeight / Convert.ToInt32(Math.Pow(2,x)));
                this.CreateGraphics().FillRectangle(randBrush, rect);
                this.CreateGraphics().DrawRectangle(blackPen, rect);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            drawRect();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            x++;
            label1.Text = x.ToString();
            drawRect();
        }
    }
}