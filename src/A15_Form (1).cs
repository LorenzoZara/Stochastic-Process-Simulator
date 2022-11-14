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
    public partial class A15_Form : Form
    {

        private readonly int NUMBER_OF_RVs = 2;
        private readonly int NUMBER_OF_PROCESSES = 60;
        private int NUMBER_OF_INTERVALS;
        private readonly Brush VIEWPORT_COLOR = Brushes.Black;
        private double SCALE;

        //if RANDOM_UNIFORMS == 0 all Uniform Distributions will be U(UNIFORM_LOWERBOUND, UNIFORM_UPPERBOUND)
        //if RANDOM_UNIFORMS == 1 all Uniform Distributions will have random bounds included in [UNIFORM_LOWERBOUND, UNIFORM_UPPERBOUND]
        private readonly int UNIFORM_LOWERBOUND = 0, UNIFORM_UPPERBOUND = 1000;
        private readonly int RANDOM_UNIFORMS = 0;

        private int n; // number of random variables
        private int m; // number of stochastic processes
        private List<UniformRandomVariable> variables;
        private List<List<int>> processes = new List<List<int>>();
        private List<double> means;
        private List<Interval> intervals;


        public A15_Form()
        {
            InitializeComponent();
            pictureBox.Width = Screen.FromControl(this).Bounds.Width - pictureBox.Location.X - 10;
            pictureBox.Height = Screen.FromControl(this).Bounds.Height - pictureBox.Location.Y - 50;
            timer_button.Enabled = false;

            n_label.Text = (n = rv_trackbar.Value = NUMBER_OF_RVs).ToString();
            m_label.Text = (m = sp_trackbar.Value = NUMBER_OF_PROCESSES).ToString();

            //NUMBER_OF_INTERVALS = m / 5;

            SCALE = 0.4;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            draw();

        }

        private void draw()
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle viewPort = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
            graphics.FillRectangle(VIEWPORT_COLOR, viewPort);

            /*start*/

            ProbabilityController PC = new ProbabilityController();
            variables = PC.getUniformRandomVariables(n, UNIFORM_LOWERBOUND, UNIFORM_UPPERBOUND, RANDOM_UNIFORMS);
            means = PC.getMeans(m, n, variables, processes);
            NUMBER_OF_INTERVALS = Math.Max(20, n * m / 30000);
            intervals = PC.getDistribution(means, NUMBER_OF_INTERVALS);

            GraphicsEngine GE = new GraphicsEngine();
            GE.drawHistogram(graphics, viewPort, intervals, SCALE);
            GE.drawCDF(graphics, viewPort, means);

            /*end*/

            pictureBox.Image = bitmap;

            timer_button.Enabled = true;

        }

        private void drawWithTimer()
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle viewPort = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
            graphics.FillRectangle(VIEWPORT_COLOR, viewPort);

            /*start*/

            ProbabilityController PC = new ProbabilityController();

            //adding new variables

            //calculate number of variables to be added
            int newRVs = (int)Math.Ceiling(n * 1.1);

            //creating new uniform distributions
            List<UniformRandomVariable> toAdd = PC.getUniformRandomVariables(newRVs, UNIFORM_LOWERBOUND,
                UNIFORM_UPPERBOUND, RANDOM_UNIFORMS);

            //adding new variables to existing ones
            foreach (UniformRandomVariable var in toAdd)
                variables.Add(var);

            means = PC.getMeans(m, n, variables, processes);

            //NUMBER_OF_INTERVALS = Math.Max(20, n*m/30000);
            intervals = PC.getDistribution(means, NUMBER_OF_INTERVALS);

            GraphicsEngine GE = new GraphicsEngine();
            GE.drawHistogram(graphics, viewPort, intervals, SCALE);
            GE.drawCDF(graphics, viewPort, means);

            /*end*/

            pictureBox.Image = bitmap;
        }

        private void rv_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            n_label.Text = (n = rv_trackbar.Value).ToString();
            timer_button.Enabled = false;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            n = (int)Math.Ceiling(n * 1.1);
            if (n >= rv_trackbar.Maximum) timer_button_Click(sender, e);
            else
            {
                m = n * 30;

                if (m >= sp_trackbar.Maximum) timer_button_Click(sender, e);
                else
                {
                    m_label.Text = (sp_trackbar.Value = m).ToString();
                    n_label.Text = (rv_trackbar.Value = n).ToString();
                    NUMBER_OF_INTERVALS = Math.Max(20, n * m / 30000);
                    drawWithTimer();
                }
            }
        }

        private void timer_button_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled) timer.Enabled = true;
            else timer.Enabled = false;
        }

        private void A15_Form_Deactivate(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void sp_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            m_label.Text = (m = sp_trackbar.Value).ToString();
        }
    }
}
