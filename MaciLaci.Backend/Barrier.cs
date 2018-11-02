using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaciLaci.Backend
{
    public class Barrier : FieldObject
    {
        public Coordinate BarrierCoordinate = new Coordinate();

        public Barrier(int x, int y)
        {
            BarrierCoordinate.Row = x;
            BarrierCoordinate.Column = y;
        }
    }
}
