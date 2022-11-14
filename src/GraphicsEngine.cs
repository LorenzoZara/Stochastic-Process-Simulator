using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace StochasticProcessSimulator
{
    public class GraphicsEngine
    {
        private Random R;

        public GraphicsEngine()
        {
            R = new Random();
        }        

        public void drawMinMaxTicks(Graphics graphics, Rectangle viewport, List<Path> paths, int n, double minY, double maxY)
        {
            double point_minY = paths[0].getPath()[paths[0].getPath().Count - 1].y;

            for (int i = 0; i < paths.Count; i++)
            {
                if (paths[i].getPath()[paths[i].getPath().Count - 1].y < point_minY)
                {
                    point_minY = paths[i].getPath()[paths[i].getPath().Count - 1].y;
                }
            }

            double point_maxY = paths[0].getPath()[paths[0].getPath().Count - 1].y;

            for (int i = 0; i < paths.Count; i++)
            {
                if (paths[i].getPath()[paths[i].getPath().Count - 1].y > point_maxY)
                {
                    point_maxY = paths[i].getPath()[paths[i].getPath().Count - 1].y;
                }
            }

            float x_toDraw = (float)convertXToViewPort((double)n, viewport, 0, n);
            float point_minY_toDraw = (float)convertYToViewPort(point_minY, viewport, minY, maxY - minY);
            float point_maxY_toDraw = (float)convertYToViewPort(point_maxY, viewport, minY, maxY - minY);
            float minY_toDraw = (float)convertYToViewPort(minY, viewport, minY, maxY - minY);
            float maxY_toDraw = (float)convertYToViewPort(maxY, viewport, minY, maxY - minY);

            Font font = new Font(new FontFamily("Calibri Light"), 13, FontStyle.Regular, GraphicsUnit.Point);

            graphics.DrawString(Math.Round(minY, 2).ToString(), font, Brushes.White, x_toDraw + 20, minY_toDraw - 20);
            graphics.DrawString(Math.Round(maxY, 2).ToString(), font, Brushes.White, x_toDraw + 20, maxY_toDraw);
            graphics.DrawString(Math.Round(point_minY, 2).ToString(), font, Brushes.White, x_toDraw + 20, point_minY_toDraw + 10);
            graphics.DrawString(Math.Round(point_maxY, 2).ToString(), font, Brushes.White, x_toDraw + 20, point_maxY_toDraw - 10);            
        }

        public void drawMinMaxTicks(Graphics graphics, Rectangle viewport, List<WalkingPath> paths, int n, double minY, double maxY)
        {
            double point_minY = paths[0].getPath()[paths[0].getPath().Count - 1].y;

            for (int i = 0; i < paths.Count; i++)
            {
                if (paths[i].getPath()[paths[i].getPath().Count - 1].y < point_minY)
                {
                    point_minY = paths[i].getPath()[paths[i].getPath().Count - 1].y;
                }
            }

            double point_maxY = paths[0].getPath()[paths[0].getPath().Count - 1].y;

            for (int i = 0; i < paths.Count; i++)
            {
                if (paths[i].getPath()[paths[i].getPath().Count - 1].y > point_maxY)
                {
                    point_maxY = paths[i].getPath()[paths[i].getPath().Count - 1].y;
                }
            }

            float x_toDraw = (float)convertXToViewPort((double)n, viewport, 0, n);
            float point_minY_toDraw = (float)convertYToViewPort(point_minY, viewport, minY, maxY - minY);
            float point_maxY_toDraw = (float)convertYToViewPort(point_maxY, viewport, minY, maxY - minY);
            float minY_toDraw = (float)convertYToViewPort(minY, viewport, minY, maxY - minY);
            float maxY_toDraw = (float)convertYToViewPort(maxY, viewport, minY, maxY - minY);

            Font font = new Font(new FontFamily("Calibri Light"), 13, FontStyle.Regular, GraphicsUnit.Point);

            graphics.DrawString(Math.Round(minY, 2).ToString(), font, Brushes.White, x_toDraw + 20, minY_toDraw - 20);
            graphics.DrawString(Math.Round(maxY, 2).ToString(), font, Brushes.White, x_toDraw + 20, maxY_toDraw);
        }

        public void drawPaths(Graphics graphics, List<Path> viewPortPaths)
        {
            for (int i = 0; i < viewPortPaths.Count; i++)
            {

                Pen pen = new Pen(Color.FromArgb(R.Next(15, 255), R.Next(15, 255), R.Next(15, 255)));


                for (int j = 0; j < viewPortPaths[i].getPath().Count - 1; j++)
                {
                    graphics.DrawLine(pen, (float)viewPortPaths[i].getPath()[j].x, (float)viewPortPaths[i].getPath()[j].y,
                        (float)viewPortPaths[i].getPath()[j + 1].x, (float)viewPortPaths[i].getPath()[j + 1].y);
                }
            }                     
        }

        public void drawWalkingPaths(Graphics graphics, List<WalkingPath> viewPortPaths)
        {
            for (int i = 0; i < viewPortPaths.Count; i++)
            {

                Pen pen = new Pen(Color.FromArgb(R.Next(15, 255), R.Next(15, 255), R.Next(15, 255)));


                for (int j = 0; j < viewPortPaths[i].getPath().Count - 1; j++)
                {          
                 
                    graphics.DrawLine(pen, (float)viewPortPaths[i].getPath()[j].x, (float)viewPortPaths[i].getPath()[j].y,
                    (float)viewPortPaths[i].getPath()[j + 1].x, (float)viewPortPaths[i].getPath()[j + 1].y);
                    
                    
                }
            }
        }      

        public void drawCDF(Graphics graphics, Rectangle viewPort, List<double> means)
        {
            means.Sort();
            double minimum = means.Min();
            double maximum = means.Max();
            double rangeX = maximum - minimum;
            double rangeY = means.Count();

            double currentY = convertYToViewPort(0, viewPort, 0, rangeY); ;
            double newY;

            int jumpCounter = 0;

            for (int i = 0; i < means.Count() - 1; i++)
            {
                if (means[i] == means[i + 1])
                {
                    jumpCounter++;
                    double convertedMean = convertXToViewPort(means[i], viewPort, minimum, rangeX);
                    double convertedMeanNext = convertXToViewPort(means[i + 1], viewPort, minimum, rangeX);
                    graphics.DrawLine(Pens.Black, (float)convertedMean, (float)currentY, (float)convertedMeanNext, (float)currentY);
                }
                else
                {
                    double convertedMean = convertXToViewPort(means[i], viewPort, minimum, rangeX);
                    double convertedMeanNext = convertXToViewPort(means[i + 1], viewPort, minimum, rangeX);

                    newY = convertViewPortToY(currentY, viewPort, 0, rangeY);
                    newY += jumpCounter + 1;
                    newY = convertYToViewPort(newY, viewPort, 0, rangeY);
                    graphics.DrawLine(Pens.Violet, (float)convertedMean, (float)currentY, (float)convertedMean, (float)newY);
                    graphics.DrawLine(Pens.Violet, (float)convertedMean, (float)newY, (float)convertedMeanNext, (float)newY);

                    currentY = newY;
                    jumpCounter = 0;

                }
            }
        }

        public void drawHistogram(Graphics graphics, Rectangle viewPort, List<Interval> intervals, double SCALE)
        {
            double minimum = intervals[0].LowerBound;
            double maximum = intervals[intervals.Count - 1].UpperBound;
            double rangeY = convertYToViewPort(0, viewPort, 0, viewPort.Height);

            double intervalSize = (maximum - minimum) / (double)intervals.Count;

            for (int i = 0; i < intervals.Count; i++)
            {
                int x, y;
                int width, height;

                double rectLowerBound = intervals[i].LowerBound;

                double upper = convertXToViewPort(intervals[i].UpperBound, viewPort, minimum, maximum - minimum);
                double lower = convertXToViewPort(intervals[i].LowerBound, viewPort, minimum, maximum - minimum);

                width = (int)(upper - lower);
                height = (int)(intervals[i].Counter * SCALE);

                x = (int)convertXToViewPort(rectLowerBound, viewPort, minimum, maximum - minimum);
                y = (int)convertYToViewPort(height, viewPort, 0, rangeY);

                Rectangle rectangle = new Rectangle(x, y, width, height);

                graphics.DrawRectangle(Pens.White, rectangle);
                SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 150, 0, 0));
                graphics.FillRectangle(semiTransBrush, rectangle);
            }

        }

        public void drawHistogram(Graphics graphics, Rectangle viewPort, List<Interval> intervals, double SCALE, SolidBrush semiTransBrush)
        {
            double minimum, maximum;
            try
            {
                minimum = intervals[0].LowerBound;
            }catch (OverflowException)
            {
                minimum = 0;
            }catch (ArgumentOutOfRangeException)
            {
                minimum = 0;
            }

            try
            {
                maximum = intervals[intervals.Count - 1].UpperBound;
            }catch (OverflowException)
            {
                maximum = 1;
            }catch (ArgumentOutOfRangeException)
            {
                maximum = 1;
            }

            double rangeY = convertYToViewPort(0, viewPort, 0, viewPort.Height);

            double intervalSize = (maximum - minimum) / (double)intervals.Count;

            for (int i = 0; i < intervals.Count; i++)
            {
                int x, y;
                int width, height;

                double rectLowerBound = intervals[i].LowerBound;

                double upper = convertXToViewPort(intervals[i].UpperBound, viewPort, minimum, maximum - minimum);
                double lower = convertXToViewPort(intervals[i].LowerBound, viewPort, minimum, maximum - minimum);

                width = (int)(upper - lower);
                height = (int)(intervals[i].Counter * SCALE);

                x = (int)convertXToViewPort(rectLowerBound, viewPort, minimum, maximum - minimum);
                y = (int)convertYToViewPort(height, viewPort, 0, rangeY);

                Rectangle rectangle = new Rectangle(x, y, width, height);

                graphics.DrawRectangle(Pens.White, rectangle);

                graphics.FillRectangle(semiTransBrush, rectangle);
            }

        }

        public void drawLandscapeHistogram(Graphics graphics, PictureBox pictureBox, Rectangle viewPort, List<Interval> intervals, int n, int j)
        {
            graphics.DrawLine(Pens.Black,
                (float)convertXToViewPort(j, viewPort, 0, n),
                (float)convertYToViewPort(0, viewPort, 0, 1),
                (float)convertXToViewPort(j, viewPort, 0, n),
                (float)convertYToViewPort(1, viewPort, 0, 1)); // vertical line

            for (int i = 0; i < intervals.Count; i++)
            {
                int x, y;
                int width, height;

                x = (int)convertXToViewPort(j, viewPort, 0, n);
                y = (int)convertYToViewPort(intervals[i].UpperBound * 100, viewPort, 0, 100);

                width = intervals[i].Counter;
                height = pictureBox.Height / intervals.Count;

                Rectangle rectangle = new Rectangle(x, y, width, height);

                graphics.DrawRectangle(Pens.Black, rectangle);
                SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 150, 0, 0));
                graphics.FillRectangle(semiTransBrush, rectangle);

                graphics.FillRectangle(Brushes.Red, rectangle);
            }
        }

        public void drawLandscapeHistogram(Graphics graphics, PictureBox pictureBox, Rectangle viewPort, List<Interval> intervals, int n, int j, double maximum)
        {
            double minY = 100;
            double maxY = 0;

            for (int i = 0; i < intervals.Count(); i++)
            {
                if (intervals[i].Counter > 0)
                {
                    maxY = intervals[i].UpperBound;

                    if (intervals[i].LowerBound < minY)
                    {
                        minY = intervals[i].LowerBound;
                    }
                }
            }

            graphics.DrawLine(Pens.Black,
                (float)convertXToViewPort(j, viewPort, 0, n),
                (float)convertYToViewPort(0, viewPort, 0, 1),
                (float)convertXToViewPort(j, viewPort, 0, n),
                (float)convertYToViewPort(1, viewPort, 0, 1)); // vertical line

            for (int i = 0; i < intervals.Count; i++)
            {
                double intervalSize = (int)convertYToViewPort(intervals[i].LowerBound, viewPort, 0, maximum)
                    - (int)convertYToViewPort(intervals[i].UpperBound, viewPort, 0, maximum);

                int x, y;
                int width, height;

                x = (int)convertXToViewPort(j, viewPort, 0, n);
                y = (int)convertYToViewPort(intervals[i].UpperBound, viewPort, 0, maximum);

                width = intervals[i].Counter;
                height = (int)(intervalSize);

                Rectangle rectangle = new Rectangle(x, y, width, height);

                graphics.DrawRectangle(Pens.Black, rectangle);
                SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 150, 0, 0));
                graphics.FillRectangle(semiTransBrush, rectangle);

                graphics.FillRectangle(Brushes.Red, rectangle);
            }
        }

        public void drawLandscapeHistogram(Graphics graphics, PictureBox pictureBox, Rectangle viewPort, List<Interval> intervals, int n, int j, double minimum, double maximum, double SCALE)
        {
            double minY = 100;
            double maxY = 0;

            for (int i = 0; i < intervals.Count(); i++)
            {
                if (intervals[i].Counter > 0)
                {
                    maxY = intervals[i].UpperBound;

                    if (intervals[i].LowerBound < minY)
                    {
                        minY = intervals[i].LowerBound;
                    }
                }
            }

            graphics.DrawLine(Pens.Black,
                (float)convertXToViewPort(j, viewPort, 0, n),
                (float)convertYToViewPort(0, viewPort, 0, 1),
                (float)convertXToViewPort(j, viewPort, 0, n),
                (float)convertYToViewPort(1, viewPort, 0, 1)); // vertical line

            for (int i = 0; i < intervals.Count; i++)
            {
                double intervalSize = (int)convertYToViewPort(intervals[i].LowerBound, viewPort, minimum, maximum - minimum)
                    - (int)convertYToViewPort(intervals[i].UpperBound, viewPort, minimum, maximum - minimum);

                int x, y;
                int width, height;

                x = (int)convertXToViewPort(j, viewPort, 0, n);
                y = (int)convertYToViewPort(intervals[i].UpperBound, viewPort, minimum, maximum - minimum);

                width = (int)(intervals[i].Counter * SCALE);
                height = (int)(intervalSize);

                Rectangle rectangle = new Rectangle(x, y, width, height);


                SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 150, 0, 0));
                graphics.FillRectangle(semiTransBrush, rectangle);
                graphics.FillRectangle(Brushes.Red, rectangle);
                graphics.DrawRectangle(Pens.Black, rectangle);
            }
        }
        
        public List<Path> convertPathsToViewPort(List<Path> paths, Rectangle viewPort, double minX, double minY, double rangeX, double rangeY)
        {
            List<Path> viewPortPaths = new List<Path>();

            foreach (Path path in paths)
            {
                List<Point> viewPortPoints = new List<Point>();

                foreach (Point point in path.getPath())
                {
                    viewPortPoints.Add(convertPointToViewPort(point, viewPort, minX, minY, rangeX, rangeY));
                }

                viewPortPaths.Add(new Path(viewPortPoints));
            }

            return viewPortPaths;
        }

        public List<WalkingPath> convertWalkingPathsToViewPort(List<WalkingPath> paths, Rectangle viewPort, double minX, double minY, double rangeX, double rangeY)
        {
            List<WalkingPath> viewPortPaths = new List<WalkingPath>();

            foreach (WalkingPath path in paths)
            {
                List<Point> viewPortPoints = new List<Point>();

                foreach (Point point in path.getPath())
                {
                    viewPortPoints.Add(convertPointToViewPort(point, viewPort, minX, minY, rangeX, rangeY));
                }

                viewPortPaths.Add(new WalkingPath(viewPortPoints));
            }

            return viewPortPaths;
        }

        public Point convertPointToViewPort(Point point, Rectangle viewPort, double minX, double minY, double rangeX, double rangeY)
        {
            Point vpoint;

            vpoint = new Point(

                (int)(viewPort.Left + viewPort.Width * ((point.x - minX) / rangeX)),  // viewport x

                viewPort.Top + viewPort.Height - (viewPort.Height * ((point.y - minY) / rangeY)) // viewport y

                );

            return vpoint;
        }

        public double convertXToViewPort(double x, Rectangle viewPort, double minX, double rangeX)
        {
            return viewPort.Left + viewPort.Width * ((x - minX) / rangeX);
        }

        public double convertYToViewPort(double y, Rectangle viewPort, double minY, double rangeY)
        {
            return viewPort.Top + viewPort.Height - viewPort.Height * ((y - minY) / rangeY);
        }

        public double convertViewPortToY(double y, Rectangle viewPort, double minY, double rangeY)
        {
            return ((viewPort.Top + viewPort.Height - y) * rangeY / viewPort.Height) + minY;
        }

    }
}
