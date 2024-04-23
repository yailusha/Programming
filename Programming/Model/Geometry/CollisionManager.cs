using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal static class CollisionManager
    {
        static public bool IsCollision(Rectangle rectangle1,  Rectangle rectangle2)
        {
            int differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            int differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double halfWidth = (rectangle1.Width + rectangle2.Width) / 2;
            double halfLength = (rectangle1.Length + rectangle2.Length) / 2;
            return differenceX < halfWidth && differenceY < halfLength;
        }
        static public bool IsCollision(Ring ring1, Ring ring2)
        {
            double differenceX = Math.Abs(ring1.Center.X - ring2 .Center.X);
            double differenceY = Math.Abs(ring1.Center.Y - ring2 .Center.Y);
            double hypothesis = Math.Sqrt(differenceY * differenceY + differenceX * differenceX);
            double sumRadiuses = ring1.OuterRadius + ring2.OuterRadius;
            return hypothesis < sumRadiuses;
        }
    }
}
