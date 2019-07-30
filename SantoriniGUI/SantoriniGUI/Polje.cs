using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d
{
    class Polje
    {
        private Stack<IObject> stackObjekata;
        private int x;
        private int y;
        public Polje(int xx, int yy)
        {
            X = xx; Y = yy;
            StackObjekata = new Stack<IObject>();
        }

        internal Stack<IObject> StackObjekata
        {
            get
            {
                return stackObjekata;
            }

            set
            {
                stackObjekata = value;
            }
        }

        public int X {
            get {
                return x;
            }

            set {
                x = value;
            }
        }

        public int Y {
            get {
                return y;
            }

            set {
                y = value;
            }
        }

        public Polje(Polje p) {
            X = p.X; Y = p.Y;
            StackObjekata = new Stack<IObject>(p.StackObjekata);
            //for (int i=0; i<StackObjekata.Count; i++) {

            //}
        }
    }
}
