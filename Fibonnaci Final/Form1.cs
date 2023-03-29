namespace Fibonnaci_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public ulong fib(int index)
        {
            index--;
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
            int count = Convert.ToInt32(fib(Convert.ToInt32(numericUpDown1.Value)));
            int formHeight = this.Height;
            int formWidth = this.Width;
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            Rectangle rect = new Rectangle(0, 0, formWidth / count, formHeight);

        }

        private void drawRect(PaintEventArgs e)
        {
            int count = Convert.ToInt32(fib(Convert.ToInt32(numericUpDown1.Value)));
            int formHeight = this.Height;
            int formWidth = this.Width;
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            e.Graphics.DrawRectangle(blackPen, 0, 0, formWidth / count, formHeight);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawRect(e);
        }
    }
}