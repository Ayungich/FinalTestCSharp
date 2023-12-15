namespace Utilities.DataModels.Var4
{
    public class PointSet
    {
        private List<Point> _points;

        public PointSet()
        {
            _points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            if (point != null && !_points.Contains(point))
            {
                _points.Add(point);
            }
        }
        double Distance(Point a, Point b) => Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));

        public double Diameter
        {
            get
            {
                double maxDistance = 0;
                for (int i = 0; i < _points.Count; i++)
                {
                    for (int j = i + 1; j < _points.Count; j++)
                    {
                        double distance = Distance(_points[i], _points[j]);
                        if (distance > maxDistance)
                        {
                            maxDistance = distance;
                        }
                    }
                }
                return maxDistance;
            }
        }
    }
}
