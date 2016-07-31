using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Path
    {
        private List<Point3D> pointList;

        
        public Path()
        {
            this.PointList = new List<Point3D>();
        }

        
        public List<Point3D> PointList
        {
            get { return this.pointList; }
            set { this.pointList = value; }
        }

        
        public void AddPoint(Point3D point)
        {
            this.pointList.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.pointList.Remove(point);
        }
    }
}
