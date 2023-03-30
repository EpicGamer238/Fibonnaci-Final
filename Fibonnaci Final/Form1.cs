using System.Windows.Forms;

namespace Fibonnaci_Final
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = 0;

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
            for (int j = 0; j < x; j++)
            {
                int count = Convert.ToInt32(fib(Convert.ToInt32(j)));
                SolidBrush randBrush = new SolidBrush(Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256)));
                Rectangle rect = new Rectangle(formWidth-(j * formWidth / x), formHeight - (formHeight / count), formWidth / x, formHeight - (formHeight / count) - 10);
                this.CreateGraphics().FillRectangle(randBrush, rect);
                this.CreateGraphics().DrawRectangle(blackPen, rect);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Refresh();
            x++;
            label1.Text = x.ToString();
            drawRect();
        }
    }
}