using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d
{
    class Tabla
    {
        private Polje[][] matrica;
        private Coveculjak beli1, beli2, crni1, crni2;

        internal Coveculjak Beli1
        {
            get
            {
                return beli1;
            }

            set
            {
                beli1 = value;
            }
        }

        internal Coveculjak Beli2
        {
            get
            {
                return beli2;
            }

            set
            {
                beli2 = value;
            }
        }

        internal Coveculjak Crni1
        {
            get
            {
                return crni1;
            }

            set
            {
                crni1 = value;
            }
        }

        internal Coveculjak Crni2
        {
            get
            {
                return crni2;
            }

            set
            {
                crni2 = value;
            }
        }

        internal Polje[][] Matrica {
            get {
                return matrica;
            }

            set {
                matrica = value;
            }
        }

        public Tabla() {
            Beli1 = Beli2 = Crni1 = Crni2 = null;
            Matrica = new Polje[5][];
            for (int i = 0; i < 5; i++)
                Matrica[i] = new Polje[5];
            
            for (int i=0; i<5; i++) {
                for (int j=0; j<5; j++) {
                    Matrica[i][j] = new Polje(i, j);
                }
            }
        }
        public Tabla(Tabla t) {
            Beli1 = new Coveculjak(t.Beli1);
            Beli2 = new Coveculjak(t.Beli2);
            Crni1 = new Coveculjak(t.Crni1);
            Crni2 = new Coveculjak(t.Crni2);
            Matrica = new Polje[5][];
            for (int i = 0; i < 5; i++)
                Matrica[i] = new Polje[5];

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    Matrica[i][j] = new Polje(t.Matrica[i][j]);
                }
            }
         
        }
        public bool mozeDaPomeri(int x, int y, Coveculjak koSePomera) {
            if (x < 0 || x > 4 || y < 0 || y > 4)
                return false;
            int visina = Matrica[x][y].StackObjekata.Count;
            if (visina == 4)
                return false;
            if (Matrica[koSePomera.X][koSePomera.Y].StackObjekata.Count <= visina - 1)
                return false;
            if (Matrica[x][y].StackObjekata.Count != 0) {
                if (Matrica[x][y].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                    return false;
            }
            bool tuJePored = false;
            for (int i=-1; i<2; i++) {
                for (int j=-1; j<2; j++) {
                    if (x == koSePomera.X + i && y == koSePomera.Y + j)
                        tuJePored = true;
                }
            }
            if (x == koSePomera.X && y == koSePomera.Y)
                return false;
            return tuJePored;
        }
        public bool mozeDaGradi(int x, int y, Coveculjak koGradi) {
            if (x < 0 || x > 4 || y < 0 || y > 4)
                return false;
            int visina = Matrica[x][y].StackObjekata.Count;
            if (visina == 4)
                return false;
            if (Matrica[x][y].StackObjekata.Count != 0) {
                if (Matrica[x][y].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                    return false;
            }
            bool tuJePored = false;
            for (int i = -1; i < 2; i++) {
                for (int j = -1; j < 2; j++) {
                    if (x == koGradi.X + i && y == koGradi.Y + j)
                        tuJePored = true;
                }
            }
            return tuJePored;
        }
        public void pomeri(int x, int y, Coveculjak koSePomera) {
            if (mozeDaPomeri(x,y,koSePomera)) {
                Matrica[koSePomera.X][koSePomera.Y].StackObjekata.Pop();
                Matrica[x][y].StackObjekata.Push(koSePomera);
                koSePomera.X = x;
                koSePomera.Y = y;
            }
        }
        public void gradi(int x, int y, Coveculjak koGr) {
            if (mozeDaGradi(x, y, koGr))
            {
                Gradjevina nova = new Gradjevina(x, y);
                Matrica[x][y].StackObjekata.Push(nova);
            }
            else
                Console.WriteLine("Ne moze tu da gradis");
        }
        public void postaviGa(int x, int y, Coveculjak kosePostavlja)
        {
            Matrica[x][y].StackObjekata.Push(kosePostavlja);
            kosePostavlja.X = x;
            kosePostavlja.Y = y;
        }
        public void odigrajPotez(Potez p) {
            if (mozeDaPomeri(p.Gde.X,p.Gde.Y,p.Ko)) {
                Matrica[p.Ko.X][p.Ko.Y].StackObjekata.Pop();
                Matrica[p.Gde.X][p.Gde.Y].StackObjekata.Push(p.Ko);
                if (p.Ko.X == Beli1.X && p.Ko.Y == Beli1.Y) {
                    Beli1.X = p.Gde.X;
                    Beli1.Y = p.Gde.Y;
                }
                else if (p.Ko.X == Beli2.X && p.Ko.Y == Beli2.Y) {
                    Beli2.X = p.Gde.X;
                    Beli2.Y = p.Gde.Y;
                }
                else if (p.Ko.X == Crni1.X && p.Ko.Y == Crni1.Y) {
                    Crni1.X = p.Gde.X;
                    Crni1.Y = p.Gde.Y;
                }
                else if (p.Ko.Y == Crni2.Y && p.Ko.Y == Crni2.Y) {
                    Crni2.X = p.Gde.X;
                    Crni2.Y = p.Gde.Y;
                }

            }
            gradi(p.GdeGradi.X, p.GdeGradi.Y, p.Ko);
        }
        public void stampaj() {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Matrica[i][j].StackObjekata.Count == 0)
                    {
                        Console.Write("_");
                        Console.Write("  ");
                        continue;
                    }
                    foreach (IObject pom in Matrica[i][j].StackObjekata)
                    {
                        if (pom.TipObjekta.Equals(ObjectType.GRADJEVINA))
                            Console.Write("g");
                        else
                            Console.Write("c");
                    }
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public List<Potez> generisiPoteze(bool koIgra) {
            List<Potez> lista = new List<Potez>();
            List<Potez> lista2 = new List<Potez>();
            Coveculjak covec1 = null, covec2 = null;
            if (koIgra == true) {
                covec1 = beli1; covec2 = beli2;
            }
            else {
                covec1 = crni1; covec2 = crni2;
            }

            for (int i = -1; i < 2; i++) {
                for (int j = -1; j < 2; j++) {
                    if (i == 0 && j == 0)
                        continue;
                    if (mozeDaPomeri(i + covec1.X, j + covec1.Y, covec1)) // Za figuricu proveravam na koja sve polja u krug moze da stane i pravim listu svih tih poteza
                        lista.Add(new Potez(covec1, matrica[covec1.X][covec1.Y], matrica[i + covec1.X][j + covec1.Y]));
                    if (mozeDaPomeri(i + covec2.X, j + covec2.Y, covec2))
                        lista.Add(new Potez(covec2, matrica[covec2.X][covec2.Y], matrica[i + covec2.X][j + covec2.Y]));
                }
            }
            foreach (Potez pom in lista) {
                int x = pom.Gde.X; int y = pom.Gde.Y;
                for (int i = -1; i < 2; i++) {
                    for (int j = -1; j < 2; j++) {
                        if (i == 0 && j == 0)
                            continue;
                        matrica[pom.Ko.X][pom.Ko.Y].StackObjekata.Pop(); // Kad proverava da l moze da gradi moram da ga izvadim da bi video da moze da gradi na mestu na kom bio jer nije fizicki izvadjen stvarno s tog mesta
                        if (mozeDaGradi(i + x, j + y, pom.Ko)) {
                            Potez pomocniPotez = new Potez(pom.Ko, pom.Odakle, pom.Gde, matrica[i + x][j + y]);
                            lista2.Add(pomocniPotez);
                        }
                        matrica[pom.Ko.X][pom.Ko.Y].StackObjekata.Push(pom.Ko); // Tu ga vratim
                    }
                }
            }
            return lista2;
        }
        public bool noMoves() {
            bool canMove = false;
            for (int i = -1; i < 2; i++) {
                for (int j = -1; j < 2; j++) {
                    if (beli1.X + i < 0 || beli1.X + i >= 5 || beli1.Y + j < 0 || beli1.Y + j >= 5)
                        continue;
                    if ((matrica[beli1.X][beli1.Y].StackObjekata.Count - matrica[beli1.X + i][beli1.Y + j].StackObjekata.Count < 1) && (matrica[beli1.X + i][beli1.Y + j].StackObjekata.Count < 4))
                        canMove = true;
                    if (beli2.X + i < 0 || beli2.X + i >= 5 || beli2.Y + j < 0 || beli2.Y + j >= 5)
                        continue;
                    if ((matrica[beli2.X][beli2.Y].StackObjekata.Count - matrica[beli2.X + i][beli2.Y + j].StackObjekata.Count < 1) && (matrica[beli2.X + i][beli2.Y + j].StackObjekata.Count < 4))
                        canMove = true;
                    if (canMove == true)
                        break;
                }
                if (canMove == true)
                    break;
            }
            bool canMove2 = false;
            for (int i = -1; i < 2; i++) {
                for (int j = -1; j < 2; j++) {
                    if (crni1.X + i < 0 || crni1.X + i >= 5 || crni1.Y + j < 0 || crni1.Y + j >= 5)
                        continue;
                    if ((matrica[crni1.X][crni1.Y].StackObjekata.Count - matrica[crni1.X + i][crni1.Y + j].StackObjekata.Count < 1) && (matrica[crni1.X + i][crni1.Y + j].StackObjekata.Count < 4))
                        canMove2 = true;
                    if (crni2.X + i < 0 || crni2.X + i >= 5 || crni2.Y + j < 0 || crni2.Y + j >= 5)
                        continue;
                    if ((matrica[crni2.X][crni2.Y].StackObjekata.Count - matrica[crni2.X + i][crni2.Y + j].StackObjekata.Count < 1) && (matrica[crni2.X + i][crni2.Y + j].StackObjekata.Count < 4))
                        canMove2 = true;
                    if (canMove2 == true)
                        break;
                }
                if (canMove2 == true)
                    break;
            }
            return (canMove || canMove2);
        }
        public float getValue(bool koIgra, Potez move=null) {
            return JednostavanTakmicar.statickaProcena(koIgra, this);
        }
    }
}
