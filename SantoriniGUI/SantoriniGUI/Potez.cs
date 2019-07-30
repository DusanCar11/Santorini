using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d {
    class Potez {
        private Coveculjak ko;
        private Polje odakle;
        private Polje gde;
        private Polje gdeGradi;

        internal Polje GdeGradi {
            get {
                return gdeGradi;
            }

            set {
                gdeGradi = value;
            }
        }

        internal Polje Gde {
            get {
                return gde;
            }

            set {
                gde = value;
            }
        }

        internal Polje Odakle {
            get {
                return odakle;
            }

            set {
                odakle = value;
            }
        }

        internal Coveculjak Ko {
            get {
                return ko;
            }

            set {
                ko = value;
            }
        }

        public Potez() {
            ko = null; odakle = gde = gdeGradi = null;
        }

        public Potez(Coveculjak kk, Polje oo, Polje gg, Polje gdeg=null) {
            Ko = kk; Odakle = oo; Gde = gg; GdeGradi = gdeg;
        }

        public String toString() {
            return Odakle.X + " " + Odakle.Y + "::::" + Gde.X + " " + Gde.Y + "::::" + GdeGradi.X + " " + GdeGradi.Y;
        }
    }
}
