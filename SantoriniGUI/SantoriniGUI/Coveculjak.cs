using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d
{
    class Coveculjak : IObject
    {
        public Coveculjak(): base(0,0, ObjectType.COVECULJAK) { }
        public Coveculjak(int xx, int yy): base(xx,yy, ObjectType.COVECULJAK) {
            
        }
        public Coveculjak(Coveculjak c): base(c.X, c.Y, ObjectType.COVECULJAK) {

        }
    }
}
