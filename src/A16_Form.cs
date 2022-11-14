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
    public partial class A16_Form : Form
    {
        private readonly static int SCALE = 10;

        public int m, n;        // number of paths and number of points per path, respectively
        public double p;        // probability of success
        public int j;           // index of specting point (at which point)
        public double epsilon;      // no-matter-how-small-is value (neighbourhood) 
        public List<WalkingPath> paths;
        public Bitmap bitmap;
        public Graphics graphics;
        public Rectangle viewPort;

        private ProbabilityController PC;
        private GraphicsEngine GE;

        private void initialize()
        {
            paths = new List<WalkingPath>();

            for (int i = 0; i < m; i++)
            {
                paths.Add(new WalkingPath(PC.createListOfRademachers(n)));
            }
        }


        private void draw()
        {
            /*start*/

            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

                       

            viewPort = new Rectangle(0, 0, (pictureBox.Width * 3 / 4) - 1, pictureBox.Height - 1);
            graphics.FillRectangle(Brushes.Black, viewPort);

            double h = m / ((double)SCALE); // viewport height related to walking paths

            double maximumY = 0;
            foreach (WalkingPath path in paths)
            {
                double check = path.getMaximumY(maximumY);

                if (check > maximumY)
                {
                    maximumY = check;
                }
            }

            double minimumY = 0;
            foreach (WalkingPath path in paths)
            {
                double check = path.getMinimumY(minimumY);

                if (check < minimumY)
                {
                    minimumY = check;
                }
            }

            List<WalkingPath> viewPortPaths = GE.convertWalkingPathsToViewPort(paths, viewPort, 0, minimumY, n, maximumY - minimumY);
            GE.drawWalkingPaths(graphics, viewPortPaths);
            GE.drawLandscapeHistogram(graphics, pictureBox, viewPort, //to specting point
                PC.getSpecificWalkingDistributionNeg(paths, 3 * SCALE, j), n, j, minimumY, maximumY, 1);
            GE.drawLandscapeHistogram(graphics, pictureBox, viewPort, //to final point
                PC.getSpecificWalkingDistributionNeg(paths, 3 * SCALE, n - 1), n, n - 1, minimumY, maximumY, 1);
            /*end*/

            GE.drawMinMaxTicks(graphics, viewPort, paths, n, minimumY, maximumY);

            pictureBox.Image = bitmap;
        }


        public A16_Form()
        {
            InitializeComponent();
            pictureBox.Width = Screen.FromControl(this).Bounds.Width - pictureBox.Location.X - 10;
            pictureBox.Height = Screen.FromControl(this).Bounds.Height - pictureBox.Location.Y - 150;
            spectingPoint_trackbar.Width = (int)((3 / 4.0) * pictureBox.Width);

            m = noPaths_trackbar.Value;
            n = noPoints_trackbar.Value;
            p = 0.5;
            j = spectingPoint_trackbar.Value = n / 2;

            noPath_label.Text = m.ToString();
            noPoints_label.Text = n.ToString();

            specting_label.Text = j.ToString();

            PC = new ProbabilityController();
            GE = new GraphicsEngine();

            initialize();
            draw();
        }

        private void noPoints_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            n = noPoints_trackbar.Value;
            spectingPoint_trackbar.Maximum = n;
            j = spectingPoint_trackbar.Value = (int)Math.Ceiling((double)n / 2);
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
