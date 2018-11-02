using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaciLaci.Backend
{
    public class Basket : FieldObject
    {
        readonly int pont = 10;
        public Coordinate BasketCoordinate = new Coordinate();

        public Basket(int x, int y)
        {
            BasketCoordinate.Row = x;
            BasketCoordinate.Column = y;
        }

        public int PontAdas()
        {
            return pont;
        }
    }
}
