using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d
{
    class Gradjevina : IObject
    {
        public Gradjevina(int xx, int yy): base(xx,yy, ObjectType.GRADJEVINA)
        {
        }

        public Gradjevina(Gradjevina g) : base(g.X, g.Y, ObjectType.GRADJEVINA) {

        }

    }
}
