/*HEADER:
 *Author: Simon Wunderlich
 *For Unit 1 & 2 Computing
 * Date of last edit: 22/04/23
 * SUMMARY: Program recieves a number input and find the value at that index of the fibonacci sequence. It then draws the amaount of boxes as the fibonacci value, each with the height and width of the screen divided by the fibonacci value ontop of all the boxes for the previous indexes
 */

/*PSEUDOCODE
 * START
 *  DEFINE getFibValue(NUMERICAL index)
 *      LIST fib ADD 1
 *      fib ADD 1
 *      FOR COUNT index
 *          NUMERICAL x <- 1
 *          fib ADD (fib[x] PLUS fib[x MINUS 1]
 *          x PLUS 1
 *      return fib[index]
 *      
 *  DISPLAY "ENTER INDEX VALUE"
 *  NUMERICAL _index <- INPUT
 *  FOR COUNT _index
 *      NUMERICAL increment <- 1
 *      NUMERICAL count <- CALL getFibValue(increment)
 *      
 *      FOR COUNT count
 *          NUMERICAL i <- 0
 *          DRAW RECTANGLE: X Position <- (i MULTIPLIED BY Screen Width) DIVIDED BY count
 *                          Y Position <- 0
 *                          Width <- Screen Width DIVIDED BY count
 *                          Height <- Screen Height DIVIDED BY count
 *      increment PLUS 1
 *       
 */
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

        //Find value in fibonacci given index value
        public ulong fib(int index)
        {
            //Create a list to put the values in when calculated
            List<ulong> fib = new List<ulong>();

            //First two values have to be manually inputed otherwise line 33 would go out of the list's bounds
            fib.Add(1);
            fib.Add(1);

            //Loops through until it reaches the index value. Each iteration adds the previous two values from the 'fib' list
            for (int x = 1; x < index; x++)
            {
                fib.Add(fib[x] + fib[x - 1]);
            }

            //returns the last value in the list. Which will be the value at the given index
            return fib[index];
        }

        private void drawRect()
        {
            //Creates random number generator 'rand'
            var rand = new Random();

            //Gets the windows dimentions
            int formHeight = this.Height;
            int formWidth = this.Width;

            //Pen for outline
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);

            //Finds the fibonacci value for the given position in array.
            //NOTE: fib called with x-1 to convert from position to index 
            int count = Convert.ToInt32(fib(Convert.ToInt32(x) - 1));

            //Generates as many rectangles as in count
            for (int i = 0; i < count; i++)
            {
                SolidBrush randBrush = new SolidBrush(Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256)));

                //Defines reactange with:
                //x position which is one rectangle width from the previous
                //y position at top of screen
                //Width is window width divided by fibonacci value
                //Height is window height divided by fibonacci value
                Rectangle rect = new Rectangle(i * formWidth / count, 0, formWidth / count, formHeight / count);

                //Draws rectangle + outline
                this.CreateGraphics().FillRectangle(randBrush, rect);
                this.CreateGraphics().DrawRectangle(blackPen, rect);
            }
        }
        
        //Runs on start, defines public variable g
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
        }

        //When the label is clicked, x increments and the label changes to x
        //Then drawRect is called to add the new layer of rectangles
        private void label1_Click(object sender, EventArgs e)
        {
            x++;
            label1.Text = x.ToString();
            drawRect();
        }
    }
}