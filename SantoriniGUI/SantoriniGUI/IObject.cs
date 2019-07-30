using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d {
    class IObject {
        private int x;
        private int y;
        private ObjectType tipObjekta;

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

        public ObjectType TipObjekta {
            get {
                return tipObjekta;
            }

            set {
                tipObjekta = value;
            }
        }

        public IObject(int xx, int yy, ObjectType tip) {
            X = xx; Y = yy; TipObjekta = tip;
        }
    }
}
