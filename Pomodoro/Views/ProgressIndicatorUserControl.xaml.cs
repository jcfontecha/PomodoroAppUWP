using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Pomodoro.Views
{
    public sealed partial class ProgressIndicatorUserControl : UserControl
    {
        public float Radius { get; set; } = 80;
        public float Increment { get; set; } = 0.07f;
        public double Completion { get; set; } = 0.5;

        public ProgressIndicatorUserControl()
        {
            this.InitializeComponent();

            var circle = CreateCircle();

            Canvas.Children.Add(circle);
        }

        private Shape CreateCircle()
        {
            var circle = new Polyline();
            circle.Stroke = Application.Current.Resources["PomodoroColorBrush"] as Brush;
            circle.StrokeThickness = 10;
            var points = new PointCollection();

            for (double i = (-Math.PI / 2) * (1.0 - Completion); i <= (3 * Math.PI / 2 + Increment); i += Increment)
            {
                var point = GetCircleCoordinates(i);
                points.Add(point);
            }

            circle.Points = points;

            return circle;
        }

        private Point GetCircleCoordinates(double pi)
        {
            var point = new Point();
            point.X = Radius * (Math.Cos(pi) + 1);
            point.Y = Radius * (Math.Sin(pi) + 1);

            return point;
        }
    }
}
