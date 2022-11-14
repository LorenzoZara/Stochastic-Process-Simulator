using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StochasticProcessSimulator
{
    public partial class A13_Form : Form
    {

        private readonly static int SCALE = 10;

        private int m, n;        // number of paths and number of points per path, respectively
        private double p;        // probability of success
        private int j;           // index of specting point (at which point)
        private double epsilon;      // no-matter-how-small-is value (neighbourhood) 
        private List<Path> paths;
        private Bitmap bitmap;
        private Graphics graphics;
        private Rectangle viewPort;

        private ProbabilityController PC;
        private GraphicsEngine GE;

        private void initialize()
        {
            paths = new List<Path>();

            for (int i = 0; i < m; i++)
            {
                paths.Add(new Path(PC.createListOfBernoullis(n, p)));
            }
        }

        private void draw()
        {
            /*start*/

            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);                      

            viewPort = new Rectangle(0, 0, (pictureBox.Width * 3 / 4) - 1, pictureBox.Height - 1);
            graphics.FillRectangle(Brushes.Black, viewPort);

            List<Path> viewPortPaths = GE.convertPathsToViewPort(paths, viewPort, 0, 0, n, 1);
            GE.drawPaths(graphics, viewPortPaths);
            GE.drawLandscapeHistogram(graphics, pictureBox, viewPort, //to specting point
                PC.getSpecificDistribution(paths, m / SCALE, j), n, j);
            GE.drawLandscapeHistogram(graphics, pictureBox, viewPort, //to final point
                PC.getSpecificDistribution(paths, m / SCALE, n), n, n);


            GE.drawMinMaxTicks(graphics, viewPort, paths, n, 0, 1);

            Interval p_neighbourhood = new Interval(p - epsilon, p + epsilon);

            int absolute_frequency = 0;
            double relative_frequency;

            foreach (Path path in paths)
            {
                for (int i = 0; i < path.getPath().Count; i++)
                {
                    if (
                        (path.getPath()[i].x == n)
                        &&
                        (path.getPath()[i].y >= p_neighbourhood.LowerBound)
                        &&
                        (path.getPath()[i].y < p_neighbourhood.UpperBound)
                        )
                    {
                        absolute_frequency++;
                    }
                }
            }

            relative_frequency = (double)absolute_frequency / (double)m;

            string s = "Number of paths that converge into (p - ε, p + ε):" + Environment.NewLine +
                        "abs_freq = " + absolute_frequency + Environment.NewLine +
                        "rel_freq = " + relative_frequency * 100 + "%";

            graphics.DrawString(s,
                new Font("Calibri", 10),
                Brushes.White,
                (float)GE.convertXToViewPort(n, viewPort, 0, n),
                (float)GE.convertYToViewPort(1 - p, viewPort, 0, 1)
                );

            graphics.DrawLine(Pens.White,
                (float)GE.convertXToViewPort(0, viewPort, 0, n),
                (float)GE.convertYToViewPort(p - epsilon, viewPort, 0, 1),
                (float)GE.convertXToViewPort(n, viewPort, 0, n),
                (float)GE.convertYToViewPort(p - epsilon, viewPort, 0, 1)
                );

            graphics.DrawLine(Pens.White,
                (float)GE.convertXToViewPort(0, viewPort, 0, n),
                (float)GE.convertYToViewPort(p + epsilon, viewPort, 0, 1),
                (float)GE.convertXToViewPort(n, viewPort, 0, n),
                (float)GE.convertYToViewPort(p + epsilon, viewPort, 0, 1)
                );

            /*end*/

            pictureBox.Image = bitmap;
        }


        public A13_Form()
        {
            InitializeComponent();
                        
            pictureBox.Width =  Screen.FromControl(this).Bounds.Width - pictureBox.Location.X - 10;
            pictureBox.Height = Screen.FromControl(this).Bounds.Height - pictureBox.Location.Y - 150;
            spectingPoint_trackbar.Width = (int)((3 / 4.0) * pictureBox.Width);

            m = noPaths_trackbar.Value;
            n = noPoints_trackbar.Value;
            p = (double)probability_trackbar.Value / (double)probability_trackbar.Maximum;
            j = spectingPoint_trackbar.Value = n / 2;
            epsilon = (double)1 / ((double)epsilon_trackbar.Value); ;

            noPath_label.Text = m.ToString();
            noPoints_label.Text = n.ToString();
            probability_label.Text = p.ToString();
            specting_label.Text = j.ToString();
            epsilon_label.Text = "(p - " + epsilon.ToString() + ", p + " + epsilon.ToString() + ")";

            PC = new ProbabilityController();
            GE = new GraphicsEngine();

            initialize();
            draw();
        }

        private void probability_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            p = (double)probability_trackbar.Value / (double)probability_trackbar.Maximum;
            probability_label.Text = p.ToString();
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

        private void epsilon_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            epsilon = (double)1 / ((double)epsilon_trackbar.Value);
            epsilon_label.Text = "(p - " + Math.Round(epsilon, 6).ToString() + ", p + " + Math.Round(epsilon, 6).ToString() + ")";

            draw();
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
            draw();
        }
    }
}
