using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTasks
{
    static class Geometry
    {
        public static double GetLength( Vector vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }
       public static Vector Add ( Vector a, Vector b)
        {
            var vect = new Vector();
            vect.X = a.X + b.X;
            vect.Y = a.Y + b.Y;
            return vect;
        }
        public static double GetLength(Segment segment)
        {
            return (Math.Sqrt((segment.End.X - segment.Begin.X) * (segment.End.X - segment.Begin.X) + (segment.End.Y - segment.Begin.Y) * (segment.End.Y - segment.Begin.Y)));
        }
        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            if (vector.X == segment.Begin.X && vector.X == segment.End.X && vector.Y == segment.Begin.Y && vector.Y == segment.End.Y) return true;
            else
            { return ((vector.X - segment.Begin.X) * (segment.End.Y - segment.Begin.Y) == (segment.End.X - segment.Begin.X) * (vector.Y - segment.Begin.Y)) && (vector.X >= segment.Begin.X && vector.X <= segment.End.X && vector.Y >= segment.Begin.Y && vector.Y <= segment.End.Y); }
        }
        
    }
}
