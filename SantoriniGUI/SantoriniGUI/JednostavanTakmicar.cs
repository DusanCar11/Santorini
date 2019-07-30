using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d {
    class JednostavanTakmicar {
        public static float ss = 0;
        public static bool dobreKoord(int x, int y) {
            if (x < 0 || x > 4 || y < 0 || y > 4)
                return false;
            return true;
        }
        public static float statickaProcena(bool koIgra, Tabla node) {
            float vrednost = 0; Coveculjak moj1 = null, moj2 = null, neprijatelj1 = null, neprijatelj2 = null;
            if (koIgra == true) {
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
            
            vrednost += (float)Math.Pow(100, node.Matrica[moj1.X][moj1.Y].StackObjekata.Count);
            vrednost += (float)Math.Pow(100, node.Matrica[moj2.X][moj2.Y].StackObjekata.Count);
            vrednost -= (float)Math.Pow(25, node.Matrica[neprijatelj1.X][neprijatelj1.Y].StackObjekata.Count);
            vrednost -= (float)Math.Pow(25, node.Matrica[neprijatelj2.X][neprijatelj2.Y].StackObjekata.Count);
            if (node.Matrica[moj1.X][moj1.Y].StackObjekata.Count == 4 && node.Matrica[moj1.X][moj1.Y].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                return float.MaxValue;
            if (node.Matrica[moj2.X][moj2.Y].StackObjekata.Count == 4 && node.Matrica[moj2.X][moj2.Y].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                return float.MaxValue;
            if (node.Matrica[neprijatelj1.X][neprijatelj1.Y].StackObjekata.Count == 4 && node.Matrica[neprijatelj1.X][neprijatelj1.Y].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                return float.MinValue;
            if (node.Matrica[neprijatelj2.X][neprijatelj2.Y].StackObjekata.Count == 4 && node.Matrica[neprijatelj2.X][neprijatelj2.Y].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                return float.MinValue;

            /*for (int i=-1; i<2; i++) {
                for (int j = -1; j < 2; j++) {
                    int visinaOkoMog = 0;
                    if (dobreKoord(moj1.X + i, moj1.Y + j) && (node.Matrica[moj1.X + i][moj1.Y + j].StackObjekata.Count != 0)) {
                        if (node.Matrica[moj1.X + i][moj1.Y + j].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                            visinaOkoMog = node.Matrica[moj1.X][moj1.Y].StackObjekata.Count - 1;
                        else
                            visinaOkoMog = node.Matrica[moj1.X][moj1.Y].StackObjekata.Count;
                        vrednost += (float)Math.Pow(1, visinaOkoMog);
                        // Provereno to polje za oko prvog igraca koje je visine
                    }
                    else
                        vrednost += (float)Math.Pow(1, 0);
                    if (dobreKoord(moj2.X + i, moj2.Y + j) && (node.Matrica[moj2.X + i][moj2.Y + j].StackObjekata.Count != 0)) {
                        if (node.Matrica[moj2.X + i][moj2.Y + j].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                            visinaOkoMog = node.Matrica[moj2.X][moj2.Y].StackObjekata.Count - 1;
                        else
                            visinaOkoMog = node.Matrica[moj2.X][moj2.Y].StackObjekata.Count;
                        vrednost += (float)Math.Pow(1, visinaOkoMog);
                        // Provereno to polje za oko drugog igraca koje je visine
                    }
                    else
                        vrednost += (float)Math.Pow(1, 0);
                    /*if (dobreKoord(neprijatelj1.X + i, neprijatelj1.Y + j) && (Game.Tablica.Matrica[neprijatelj1.X + i][neprijatelj1.Y + j].StackObjekata.Count != 0)) {
                        if (Game.Tablica.Matrica[neprijatelj1.X + i][neprijatelj1.Y + j].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                            visinaOkoMog = Game.Tablica.Matrica[neprijatelj1.X][neprijatelj1.Y].StackObjekata.Count - 1;
                        else
                            visinaOkoMog = Game.Tablica.Matrica[neprijatelj1.X][neprijatelj1.Y].StackObjekata.Count;
                        vrednost -= (float)Math.Pow(9, visinaOkoMog);
                        // Provereno to polje za oko prvog neprijatlejskog igraca koje je visine
                    }
                    if (dobreKoord(neprijatelj2.X + i, neprijatelj2.Y + j) && (Game.Tablica.Matrica[neprijatelj2.X + i][neprijatelj2.Y + j].StackObjekata.Count!=0)) {
                        if (Game.Tablica.Matrica[neprijatelj2.X + i][neprijatelj2.Y + j].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                            visinaOkoMog = Game.Tablica.Matrica[neprijatelj2.X][neprijatelj2.Y].StackObjekata.Count - 1;
                        else
                            visinaOkoMog = Game.Tablica.Matrica[neprijatelj2.X][neprijatelj2.Y].StackObjekata.Count;
                        vrednost -= (float)Math.Pow(9, visinaOkoMog);
                        // Provereno to polje za oko prvog neprijatlejskog igraca koje je visine
                    }

                    //if (Game.Tablica.Matrica[neprijatelj1.X][neprijatelj1.Y].StackObjekata.Count == 3 && (Game.Tablica.Matrica[neprijatelj1.X + i][neprijatelj1.Y + j].StackObjekata.Count == 3 && Game.Tablica.Matrica[neprijatelj1.X + i][neprijatelj1.Y+j].StackObjekata.First().TipObjekta != ObjectType.COVECULJAK) && ()
                }
            }*/
            
            return vrednost;
        }

        public static float alfaBeta(Tabla node, Potez potez, int depth, float alfa, float beta, bool igrac, out Potez naj) {
            naj = potez;
            if (depth == 0 || !node.noMoves()) {
                //naj = potez;
                return node.getValue(igrac);
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
