using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d {
    class JednostavanIgrac {
        public static float statickaProcena(bool koIgra, Potez potez, Tabla node) {
            float vrednost = 0; Coveculjak moj1 = null, moj2=null, neprijatelj1 = null, neprijatelj2 = null;
            if (koIgra==true) {
                moj1 = node.Beli1;
                moj2 = node.Beli2;
                neprijatelj1 = node.Crni1;
                neprijatelj2 = node.Crni2;
            }
            else {
                moj1 = node.Crni1;
                moj2 = node.Crni2;
                neprijatelj1 = node.Beli1;
                neprijatelj2 = node.Beli2;
            }
            vrednost += potez.Gde.StackObjekata.Count;
            float rastojanje11 = (float)Math.Sqrt(Math.Pow(moj1.X - potez.GdeGradi.X, 2) + Math.Pow(moj1.Y - potez.GdeGradi.Y, 2));
            float rastojanje12 = (float)Math.Sqrt(Math.Pow(moj2.X - potez.GdeGradi.X, 2) + Math.Pow(moj2.Y - potez.GdeGradi.Y, 2));
            float rastojanje21 = (float)Math.Sqrt(Math.Pow(neprijatelj1.X - potez.GdeGradi.X, 2) + Math.Pow(neprijatelj1.Y - potez.GdeGradi.Y, 2));
            float rastojanje22 = (float)Math.Sqrt(Math.Pow(neprijatelj2.X - potez.GdeGradi.X, 2) + Math.Pow(neprijatelj2.Y - potez.GdeGradi.Y, 2));
            float pomVrednost = potez.GdeGradi.StackObjekata.Count * (rastojanje11 + rastojanje12 - rastojanje21 - rastojanje22);
            vrednost += pomVrednost;
            return vrednost;
        }
        public static float minimax(Tabla node, Potez potez, int depth, bool igrac, out Potez naj) {
            naj = potez;
            if (depth == 0 || !node.noMoves()) {
                //naj = potez;
                return node.getValue(igrac, potez);
            }
            float pom;
            if (igrac) {
                pom = float.MinValue;
                List<Potez> potezi = node.generisiPoteze(true);
                foreach (Potez move in potezi) {
                    //broj++;
                    Tabla novCvor = new Tabla(node);
                    novCvor.odigrajPotez(move);
                    Potez noviNode = new Potez();
                    float ret = minimax(novCvor, move, depth - 1, false, out noviNode);
                    if (pom < ret) {
                        pom = ret;
                        naj = move;
                    }
                }
            }
            else {
                pom = float.MaxValue;
                List<Potez> potezi = node.generisiPoteze(false);
                foreach (Potez move in potezi) {
                    Tabla novCvor = new Tabla(node);
                    novCvor.odigrajPotez(move);
                    Potez noviNode = new Potez();
                    float ret = minimax(novCvor, move, depth - 1, true, out noviNode);
                    if (pom > ret) {
                        pom = ret;
                        naj = move;
                    }
                }
            }
            return pom;
        }
    }
}
