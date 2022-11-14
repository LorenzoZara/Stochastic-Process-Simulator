using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StochasticProcessSimulator
{
    public partial class A18_Form : Form
    {

        private readonly static int SCALE = 10;

        public int m, n;        // number of paths and number of points per path, respectively
        public double p;       // probability of success
        public int j;           // index of specting point (at which point)
        public double epsilon;      // no-matter-how-small-is value (neighbourhood) 
        public double lam;
        public List<List<int>> values = new List<List<int>>();
        public List<WalkingPath> paths;
        public Bitmap bitmap;
        public Graphics graphics;
        public Rectangle viewPort;

        List<int> values_i = new List<int>();

        private List<Interval> consecutiveDistancesIntervals;
        private List<Interval> fromOriginDistancesIntervals;

        private List<List<int>> consecutiveDistances = new List<List<int>>();
        private List<List<int>> fromOriginDistances = new List<List<int>>();

        private ProbabilityController PC;
        private GraphicsEngine GE;

        private void initialize()
        {
            paths = new List<WalkingPath>();

            if (values != null)
            {
                values.Clear();
                consecutiveDistances.Clear();
                fromOriginDistances.Clear();
            }
            
            for (int i = 0; i < m; i++)
            {
                values_i = PC.createListOfBernoullis(n, p);
                values.Add(values_i);
                paths.Add(new WalkingPath(values_i));
            }

            foreach (List<int> value in values)
            {
                consecutiveDistances.Add(PC.getConsecutiveDistances(value));
                fromOriginDistances.Add(PC.getFromOriginDistances(value));
            }

            consecutiveDistancesIntervals = PC.getDistancesDistribution(consecutiveDistances, 30);
            fromOriginDistancesIntervals = PC.getDistancesDistribution(fromOriginDistances, 30);
        }

        private void draw()
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);            

            double maximumY = 0;
            foreach (WalkingPath path in paths)
            {
                double check = path.getMaximumY(maximumY);

                if (check > maximumY)
                {
                    maximumY = check;

                }
            }

            viewPort = new Rectangle(0, 0, (pictureBox.Width * 3 / 4) - 1, pictureBox.Height - 1);

            graphics.FillRectangle(Brushes.Black, viewPort);

            double h = m / ((double)SCALE); // viewport height related to walking paths

            //put 2*h instead of maximumY in order to not have bound of height
            List<WalkingPath> viewPortPaths = GE.convertWalkingPathsToViewPort(paths, viewPort, 0, 0, n, maximumY);

            SolidBrush semiTransBrush1 = new SolidBrush(Color.FromArgb(128, 150, 0, 0));
            SolidBrush semiTransBrush2 = new SolidBrush(Color.FromArgb(128, 200, 200, 200));


            try
            {
                GE.drawWalkingPaths(graphics, viewPortPaths);
                GE.drawLandscapeHistogram(graphics, pictureBox, viewPort, //to specting point
                    PC.getSpecificWalkingDistribution(paths, 3 * SCALE, j), n, j, maximumY);
                GE.drawLandscapeHistogram(graphics, pictureBox, viewPort, //to final point
                    PC.getSpecificWalkingDistribution(paths, 3 * SCALE, n - 1), n, n, maximumY);
                GE.drawHistogram(graphics, viewPort, consecutiveDistancesIntervals, 1 / lam, semiTransBrush1);
                GE.drawHistogram(graphics, viewPort, fromOriginDistancesIntervals, 1 / lam, semiTransBrush2);
                GE.drawMinMaxTicks(graphics, viewPort, paths, n, 0, maximumY);
            }
            catch (OverflowException)
            {

            }

            pictureBox.Image = bitmap;
        }


        public A18_Form()
        {
            InitializeComponent();
            pictureBox.Width = Screen.FromControl(this).Bounds.Width - pictureBox.Location.X - 10;
            pictureBox.Height = Screen.FromControl(this).Bounds.Height - pictureBox.Location.Y - 150;
            spectingPoint_trackbar.Width = (int)((3 / 4.0) * pictureBox.Width);

            m = noPaths_trackbar.Value;
            n = noPoints_trackbar.Value;
            lam = probability_trackbar.Value;
            p = lam / (double)n;
            j = spectingPoint_trackbar.Value = n / 2;

            noPath_label.Text = m.ToString();
            noPoints_label.Text = n.ToString();
            probability_label.Text = "λ =" + lam.ToString();
            specting_label.Text = j.ToString();

            PC = new ProbabilityController();
            GE = new GraphicsEngine();
            initialize();
            draw();
        }

        private void probability_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            lam = (double)probability_trackbar.Value;

            if (lam > n)
            {
                n = noPoints_trackbar.Value = (int)lam + 1;
            }
            noPoints_label.Text = n.ToString();

            p = lam / n;
            probability_label.Text = "λ =" + lam.ToString();
            initialize();
            draw();
        }

        private void noPoints_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            n = noPoints_trackbar.Value;
            spectingPoint_trackbar.Maximum = n;
            j = spectingPoint_trackbar.Value = (int)Math.Ceiling((double)n / 2);

            if (lam > n)
            {                
                lam = probability_trackbar.Value = probability_trackbar.Maximum = n - 1;
            }
            else
            {                
                lam = probability_trackbar.Value = probability_trackbar.Maximum = 100;
            }
            probability_label.Text = "λ =" + lam.ToString();


            noPoints_label.Text = n.ToString();
            specting_label.Text = j.ToString();
            spectingPoint_trackbar.TickFrequency = spectingPoint_trackbar.Maximum / 10;
            initialize();
            draw();
        }

        private void noPaths_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            m = noPaths_trackbar.Value;
            noPath_label.Text = m.ToString();
            lam = probability_trackbar.Value = probability_trackbar.Maximum;
            initialize();
            draw();
        }

        private void spectingPoint_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            j = spectingPoint_trackbar.Value;
            specting_label.Text = j.ToString();

            draw();
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
            initialize();
            draw();
        }
    }
}
