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
    public partial class A22GBM_Form : Form
    {
        private readonly static int SCALE = 10;

        public int m, n;        // number of paths and number of points per path, respectively
        public double p;       // probability of success
        public int j;           // index of specting point (at which point)
        public double mi;      // no-matter-how-small-is value (neighbourhood) 
        public double sig;
        public List<List<double>> values = new List<List<double>>();
        public List<WalkingPath> paths;
        public Bitmap bitmap;
        public Graphics graphics;
        public Rectangle viewPort;

        List<double> values_i = new List<double>();

        ProbabilityController PC;
        GraphicsEngine GE;

        private void initialize()
        {
            paths = new List<WalkingPath>();

            if (values != null)
            {
                values.Clear();
            }

            for (int i = 0; i < m; i++)
            {
                values_i = PC.createListOfNormals(n, 0, 1);
                values.Add(values_i);
                paths.Add(new WalkingPath(values_i, mi, sig, "geometric", 50));
            }
        }

        private void draw()
        {
            /*start*/

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

            double minimumY = 0;
            foreach (WalkingPath path in paths)
            {
                double check = path.getMinimumY(minimumY);

                if (check < minimumY)
                {
                    minimumY = check;
                }
            }
            viewPort = new Rectangle(0, 0, (pictureBox.Width * 3 / 4) - 1, pictureBox.Height - 1);

            graphics.FillRectangle(Brushes.Black, viewPort);

            double h = m / ((double)SCALE); // viewport height related to walking paths

            //put 2*h instead of maximumY in order to not have bound of height
            List<WalkingPath> viewPortPaths = GE.convertWalkingPathsToViewPort(paths, viewPort, 0, minimumY, n, maximumY - minimumY);


            GE.drawWalkingPaths(graphics, viewPortPaths);
            GE.drawLandscapeHistogram(graphics, pictureBox, viewPort, //to specting point
                PC.getSpecificWalkingDistributionNeg(paths, 3 * SCALE, j), n, j, minimumY, maximumY, 1);
            GE.drawLandscapeHistogram(graphics, pictureBox, viewPort, //to final point
                PC.getSpecificWalkingDistributionNeg(paths, 3 * SCALE, n - 1), n, n, minimumY, maximumY, 1);

            SolidBrush semiTransBrush1 = new SolidBrush(Color.FromArgb(128, 150, 0, 0));
            SolidBrush semiTransBrush2 = new SolidBrush(Color.FromArgb(128, 200, 200, 200));

            /*end*/

            GE.drawMinMaxTicks(graphics, viewPort, paths, n, minimumY, maximumY);

            pictureBox.Image = bitmap;
        }


        public A22GBM_Form()
        {
            InitializeComponent();
            pictureBox.Width = Screen.FromControl(this).Bounds.Width - pictureBox.Location.X - 10;
            pictureBox.Height = Screen.FromControl(this).Bounds.Height - pictureBox.Location.Y - 150;
            spectingPoint_trackbar.Width = (int)((3 / 4.0) * pictureBox.Width);

            m = noPaths_trackbar.Value;
            n = noPoints_trackbar.Value;
            sig = deviation_trackbar.Value;
            p = sig / Math.Sqrt((double)n);
            j = spectingPoint_trackbar.Value = n / 2;
            mi = mean_trackbar.Value;

            noPath_label.Text = m.ToString();
            noPoints_label.Text = n.ToString();
            deviation_label.Text = "σ =" + sig.ToString();
            specting_label.Text = j.ToString();
            mean_label.Text = "μ = " + mi.ToString();

            PC = new ProbabilityController();
            GE = new GraphicsEngine();
            initialize();
            draw();
        }

        private void deviation_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            sig = (double)deviation_trackbar.Value;
            p = sig / Math.Sqrt(n);
            deviation_label.Text = "σ =" + sig.ToString();
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

        private void mean_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            mi = mean_trackbar.Value;
            mean_label.Text = "μ = " + mi.ToString();

            initialize();
            draw();
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
            initialize();
            draw();
        }
    }
}
