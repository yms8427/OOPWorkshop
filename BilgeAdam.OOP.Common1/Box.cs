using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Common1
{
    public class Box
    {
        public Box(int edge) : this(edge, edge, edge)
        {
        }

        public Box(int edge1, int edge2, int edge3)
        {
            Edge1 = edge1;
            Edge2 = edge2;
            Edge3 = edge3;
        }

        public int Edge1 { get; }
        public int Edge2 { get; }
        public int Edge3 { get; }

        public int Volume
        {
            get
            {
                return Edge1 * Edge2 * Edge3;
            }
        }

        public static int operator +(Box left, Box right)
        {
            return left.Volume + right.Volume;
        }

        public static int operator -(Box left, Box right)
        {
            if (right.Volume > left.Volume)
            {
                return 0;
            }
            return left.Volume - right.Volume;
        }

        public static implicit operator Box(int edge)
        {
            return new Box(edge);
        }

        public static implicit operator Box(string edge)
        {
            int.TryParse(edge, out int essentialEdge);
            return new Box(essentialEdge);
        }
    }
}
