using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d
{
    class Game
    {
        private static Tabla tablica;
        private bool koIgra;
        private bool krajIgre;

        internal static Tabla Tablica {
            get {
                return tablica;
            }

            set {
                tablica = value;
            }
        }
        public bool KrajIgre {
            get {
                return krajIgre;
            }

            set {
                krajIgre = value;
            }
        }

        public Game() {
            Tablica = new Tabla();
            koIgra = false;
            KrajIgre = false;
            Tablica.Beli1 = new Coveculjak();
            Tablica.Beli2 = new Coveculjak();
            Tablica.Crni1 = new Coveculjak();
            Tablica.Crni2 = new Coveculjak();
        }
        /*public void pokreniIgruIgracXKomp() {
            while (true) {
                Tablica.stampaj();
                if (koIgra==true) {
                    Console.WriteLine("Kazi s kojim covekom oces da ides");
                    int g = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kazi gde ces da ides");
                    int prvi = int.Parse(Console.ReadLine());
                    int drugi = int.Parse(Console.ReadLine());
                    if (koIgra == true) {
                        if (g == 1)
                            Tablica.pomeri(prvi, drugi, Tablica.Beli1);
                        else
                            Tablica.pomeri(prvi, drugi, Tablica.Beli2);
                    }
                    Console.WriteLine("Kazi gde ce da gradis");
                    int prva = int.Parse(Console.ReadLine());
                    int druga = int.Parse(Console.ReadLine());
                    Tablica.gradi(prva, druga);
                    koIgra = !koIgra;
                }
                else {
                    Potez pot = new Potez();
                    JednostavanAlfaBeta.alfaBeta(Tablica, null, 3, float.MinValue, float.MaxValue, koIgra, out pot);
                    Tablica.odigrajPotez(pot);
                    koIgra = !koIgra;
                }
            }
        }*/
       /*public void pokreniIgruIgracXIgrac() {
            while (true) {
                Tablica.stampaj();
                if (koIgra == true)
                    Console.WriteLine("Igra beli");
                else
                    Console.WriteLine("Igra crni");
                Console.WriteLine("Kazi s kojim covekom oces da ides");
                int g = int.Parse(Console.ReadLine());
                Console.WriteLine("Kazi gde ces da ides");
                int prvi = int.Parse(Console.ReadLine());
                int drugi = int.Parse(Console.ReadLine());
                if (koIgra==true)
                {
                    if (g == 1)
                        Tablica.pomeri(prvi, drugi, Tablica.Beli1);
                    else
                        Tablica.pomeri(prvi, drugi, Tablica.Beli2);
                }
                else
                {
                    if (g == 1)
                        Tablica.pomeri(prvi, drugi, Tablica.Crni1);
                    else
                        Tablica.pomeri(prvi, drugi, Tablica.Crni2);
                }
                Console.WriteLine("Kazi gde ce da gradis");
                int prva = int.Parse(Console.ReadLine());
                int druga = int.Parse(Console.ReadLine());
                Tablica.gradi(prva, druga);
                koIgra = !koIgra;
            }
        }*/     
    }
}
