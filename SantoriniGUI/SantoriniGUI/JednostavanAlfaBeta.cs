using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d {

    class JednostavanAlfaBeta : JednostavanIgrac {
        private static int broj;

        public static float alfaBeta(Tabla node, Potez potez, int depth, float alfa, float beta, bool igrac, out Potez naj) {
            naj = potez; broj++;
            if (depth == 0 || !node.noMoves()) {
                //naj = potez;
                return node.getValue(igrac, potez);
            }
            float pom;
            if (igrac) {
                pom = float.MinValue;
                List<Potez> potezi = node.generisiPoteze(true);
                foreach (Potez move in potezi) {
                    Tabla novCvor = new Tabla(node);
                    novCvor.odigrajPotez(move);
                    Potez noviNode = new Potez();
                    float ret = alfaBeta(novCvor, move, depth - 1, alfa, beta, false, out noviNode);
                    if (pom < ret) {
                        pom = ret;
                        naj = move;
                    }
                    alfa = Math.Max(alfa, pom);
                    if (beta <= alfa)
                        break;
                }
            }
            else {
                pom = float.MaxValue;
                List<Potez> potezi = node.generisiPoteze(false);
                foreach (Potez move in potezi) {
                    Tabla novCvor = new Tabla(node);
                    novCvor.odigrajPotez(move);
                    Potez noviNode = new Potez();
                    float ret = alfaBeta(novCvor, move, depth - 1, alfa, beta, true, out noviNode);
                    if (pom > ret) {
                        pom = ret;
                        naj = move;
                    }
                    beta = Math.Min(beta, pom);
                    if (beta <= alfa)
                        break;
                }
            }
            return pom;
        }

    }
}
