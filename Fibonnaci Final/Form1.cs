using System.Windows.Forms;

namespace Fibonnaci_Final
{
    public partial class Form1 : Form
    {
        Graphics g;
        long x = 0;
        List<Label> labels = new List<Label>();

        public Form1()
        {
            InitializeComponent();
        }

        public ulong fib(long index)
        {
            List<ulong> fib = new List<ulong>();
            fib.Add(1);
            fib.Add(1);
            for (int x = 1; x < index; x++)
            {
                fib.Add(fib[x] + fib[x - 1]);
            }
            return fib[Convert.ToInt32(index)];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void drawRect()
        {
            var rand = new Random();
            long formHeight = Convert.ToInt64(this.Height);
            long formWidth = Convert.ToInt64(this.Width);
            long max = Convert.ToInt64(fib(x - 1));
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            for (long j = 0; j < x; j++)
            {
                long count = Convert.ToInt64(fib(j));
                SolidBrush randBrush = new SolidBrush(Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256)));
                Rectangle rect = new Rectangle(Convert.ToInt32(100 + (j * (formWidth - 200) / x)), Convert.ToInt32(formHeight - 200 - (formHeight - 200) * count / max + 100), Convert.ToInt32((formWidth - 200) / x), Convert.ToInt32((formHeight - 200) * count / max));
                this.CreateGraphics().FillRectangle(randBrush, rect);
                this.CreateGraphics().DrawRectangle(blackPen, rect);

                Label newLabel = new Label();
                newLabel.AutoSize = true;
                newLabel.ForeColor = Color.Black;
                newLabel.Location = new Point(rect.X, rect.Y - 30);
                newLabel.Text = count.ToString();
                newLabel.Visible = false;
                this.Controls.Add(newLabel);
                labels.Add(newLabel);

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Maximum = 89;
            hScrollBar1.Minimum = 1;
            x = hScrollBar1.Value;
            label1.Text = hScrollBar1.Value.ToString();
            Refresh();
            foreach (Label label in labels)
            {
                this.Controls.Remove(label);
            }
            drawRect();
        }
    }
}