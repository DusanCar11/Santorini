using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etf.santorini.nd160604d {
    public partial class gameWindow : Form {
        public gameWindow() {
            InitializeComponent();
            Game = new Game();
            Ispisivac.open();
            hashTablica = new Dictionary<Tuple<int, ObjectType, Coveculjak>, Image>();
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(0, ObjectType.GRADJEVINA, null), SantoriniGUI.Properties.Resources.prazno);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(1, ObjectType.GRADJEVINA, null), SantoriniGUI.Properties.Resources.saJednom);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(1, ObjectType.COVECULJAK, Game.Tablica.Crni1), SantoriniGUI.Properties.Resources.valjak0);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(1, ObjectType.COVECULJAK, Game.Tablica.Crni2), SantoriniGUI.Properties.Resources.valjak01);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(1, ObjectType.COVECULJAK, Game.Tablica.Beli1), SantoriniGUI.Properties.Resources.kocka0);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(1, ObjectType.COVECULJAK, Game.Tablica.Beli2), SantoriniGUI.Properties.Resources.kocka01);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(2, ObjectType.GRADJEVINA, null), SantoriniGUI.Properties.Resources.saDve);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(2, ObjectType.COVECULJAK, Game.Tablica.Crni1), SantoriniGUI.Properties.Resources.valjak1);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(2, ObjectType.COVECULJAK, Game.Tablica.Crni2), SantoriniGUI.Properties.Resources.valjak11);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(2, ObjectType.COVECULJAK, Game.Tablica.Beli1), SantoriniGUI.Properties.Resources.kocka1);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(2, ObjectType.COVECULJAK, Game.Tablica.Beli2), SantoriniGUI.Properties.Resources.kocka11);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(3, ObjectType.GRADJEVINA, null), SantoriniGUI.Properties.Resources.saTri);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(3, ObjectType.COVECULJAK, Game.Tablica.Crni1), SantoriniGUI.Properties.Resources.valjak2);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(3, ObjectType.COVECULJAK, Game.Tablica.Crni2), SantoriniGUI.Properties.Resources.valjak21);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(3, ObjectType.COVECULJAK, Game.Tablica.Beli1), SantoriniGUI.Properties.Resources.kocka2);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(3, ObjectType.COVECULJAK, Game.Tablica.Beli2), SantoriniGUI.Properties.Resources.kocka21);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(4, ObjectType.GRADJEVINA, null), SantoriniGUI.Properties.Resources.saKupolom);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(4, ObjectType.COVECULJAK, Game.Tablica.Crni1), SantoriniGUI.Properties.Resources.valjak3);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(4, ObjectType.COVECULJAK, Game.Tablica.Crni2), SantoriniGUI.Properties.Resources.valjak31);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(4, ObjectType.COVECULJAK, Game.Tablica.Beli1), SantoriniGUI.Properties.Resources.kocka3);
            hashTablica.Add(new Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>(4, ObjectType.COVECULJAK, Game.Tablica.Beli2), SantoriniGUI.Properties.Resources.kocka31);
            if (!korakPoKorak)
                btnNextStep.Enabled = false;
            Game.KrajIgre = false;
            firstMove = 0;
        }

        private Game game;
        public static int dubina;
        public static int firstMove = 0;
        public static int clickCounter;
        public static bool gameStarted;
        public static int odaklei, odaklej, gdei, gdej, gdegradii, gdegradij;
        public static bool jeKliknuto = false, korakPoKorak = false;
        public static bool botvbot=false, botvplay=false, koIgra;
        Dictionary<Tuple<int, etf.santorini.nd160604d.ObjectType, etf.santorini.nd160604d.Coveculjak>, Image> hashTablica;

        internal Game Game {
            get {
                return game;
            }

            set {
                game = value;
            }
        }

        private void ucitajProzor() {
            tablica.Visible = false;
            tablica.Controls.Clear();
            int brojac = 0;
            for (int i=0; i<tablica.RowCount; i++) {
                for (int j=0; j<tablica.ColumnCount; j++) {
                    brojac++;
                    PictureBox pb = new PictureBox();
                    pb.Image = hashTablica[new Tuple<int, ObjectType, Coveculjak>(Game.Tablica.Matrica[i][j].StackObjekata.Count, ObjectType.GRADJEVINA, null)];
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Tag = brojac;
                    tablica.Controls.Add(pb, j, i);
                    pb.Dock = DockStyle.Fill;
                    pb.Click += PictureBox_Click;
                }
            }
            stampaj();
            tablica.Visible = true;
        }

        private void napraviBotvBotPocetak() {
            Random rnd = new Random();
            int i = rnd.Next(0, 5);
            int j = rnd.Next(0, 5);
            Game.Tablica.Beli1.X = i;
            Game.Tablica.Beli1.Y = j;
            Game.Tablica.postaviGa(i, j, Game.Tablica.Beli1);
            Ispisivac.writePosition(i, j);
            Ispisivac.writeSpace();
            i = rnd.Next(0, 5);
            j = rnd.Next(0, 5);
            while (i==Game.Tablica.Beli1.X && j==Game.Tablica.Beli1.Y) {
                i = rnd.Next(0, 5);
                j = rnd.Next(0, 5);
            }
            Game.Tablica.Beli2.X = i;
            Game.Tablica.Beli2.Y = j;
            Game.Tablica.postaviGa(i, j, Game.Tablica.Beli2);
            Ispisivac.writePosition(i, j);
            Ispisivac.writeNewLine();
            i = rnd.Next(0, 5);
            j = rnd.Next(0, 5);
            while ((i == Game.Tablica.Beli1.X && j == Game.Tablica.Beli1.Y) || (i==Game.Tablica.Beli2.X && j==Game.Tablica.Beli2.Y)) {
                i = rnd.Next(0, 5);
                j = rnd.Next(0, 5);
            }
            Game.Tablica.Crni1.X = i;
            Game.Tablica.Crni1.Y = j;
            Game.Tablica.postaviGa(i, j, Game.Tablica.Crni1);
            Ispisivac.writePosition(i, j);
            Ispisivac.writeSpace();
            i = rnd.Next(0, 5);
            j = rnd.Next(0, 5);
            while ((i == Game.Tablica.Beli1.X && j == Game.Tablica.Beli1.Y) || (i == Game.Tablica.Beli2.X && j == Game.Tablica.Beli2.Y) || (i == Game.Tablica.Crni1.X && j == Game.Tablica.Crni1.Y)) {
                i = rnd.Next(0, 5);
                j = rnd.Next(0, 5);
            }
            Game.Tablica.Crni2.X = i;
            Game.Tablica.Crni2.Y = j;
            Game.Tablica.postaviGa(i, j, Game.Tablica.Crni2);
            Ispisivac.writePosition(i, j);
            Ispisivac.writeNewLine();
            //clickCounter = 0;
            gameStarted = true;
        }

        private void btnNextStep_Click(object sender, EventArgs e) {
            jeKliknuto = true;
            igrajbotvbot();
            stampaj();
        }

        private void napraviPlayvPlayPocetak(int i, int j) {
            if (clickCounter == 0) {
                Game.Tablica.Beli1.X = i;
                Game.Tablica.Beli1.Y = j;
                Game.Tablica.postaviGa(i, j, Game.Tablica.Beli1);
                clickCounter++;
                stampaj();
                Ispisivac.writePosition(i, j);
                Ispisivac.writeSpace();
            }
            else if (clickCounter == 1) {
                if (i == Game.Tablica.Beli1.X && j == Game.Tablica.Beli1.Y) 
                    return;
                Game.Tablica.Beli2.X = i;
                Game.Tablica.Beli2.Y = j;
                Game.Tablica.postaviGa(i, j, Game.Tablica.Beli2);
                clickCounter++;
                stampaj();
                Ispisivac.writePosition(i, j);
                Ispisivac.writeNewLine();
            }
            else if (clickCounter == 2) {
                if ((i == Game.Tablica.Beli1.X && j == Game.Tablica.Beli1.Y) || (i == Game.Tablica.Beli2.X && j == Game.Tablica.Beli2.Y))
                    return;
                Game.Tablica.Crni1.X = i;
                Game.Tablica.Crni1.Y = j;
                Game.Tablica.postaviGa(i, j, Game.Tablica.Crni1);
                clickCounter++;
                stampaj();
                Ispisivac.writePosition(i, j);
                Ispisivac.writeSpace();
            }
            else {
                if ((i == Game.Tablica.Beli1.X && j == Game.Tablica.Beli1.Y) || (i == Game.Tablica.Beli2.X && j == Game.Tablica.Beli2.Y) || (i == Game.Tablica.Crni1.X && j == Game.Tablica.Crni1.Y))
                    return;
                Game.Tablica.Crni2.X=i;
                Game.Tablica.Crni2.Y = j;
                Game.Tablica.postaviGa(i, j, Game.Tablica.Crni2);
                clickCounter=0;
                stampaj();
                Ispisivac.writePosition(i, j);
                Ispisivac.writeNewLine();
                gameStarted = true;
                koIgra = true;
            }
        }

        private void PictureBox_Click(object sender, EventArgs e) {
            int ii=0, jj=0;
            for (int i=0; i<5; i++) {
                for (int j=0; j<5; j++) {
                    if (((PictureBox)sender) == ((PictureBox)tablica.GetControlFromPosition(j, i))) {
                        ii = i; jj = j;
                        break;
                    }
                }
            }
            if (botvbot && !gameStarted)
                napraviBotvBotPocetak();
            if (!botvbot && !botvplay && !gameStarted)
                napraviPlayvPlayPocetak(ii,jj);
            if (!gameStarted && clickCounter < 3 && botvplay) {
                if (clickCounter == 1) {
                    if ((ii == Game.Tablica.Crni1.X && jj == Game.Tablica.Crni1.Y) || (ii==Game.Tablica.Crni2.X && jj==Game.Tablica.Crni2.Y))
                        return;
                    Game.Tablica.Beli1.X = ii;
                    Game.Tablica.Beli1.Y = jj;
                    Ispisivac.writePosition(ii, jj);
                    Ispisivac.writeSpace();
                    Game.Tablica.postaviGa(ii, jj, Game.Tablica.Beli1);
                    clickCounter++;
                    stampaj();
                    return;
                }
                if (clickCounter == 2) {
                    if ((ii == Game.Tablica.Crni1.X && jj == Game.Tablica.Crni1.Y) || (ii == Game.Tablica.Crni2.X && jj == Game.Tablica.Crni2.Y) || (ii==Game.Tablica.Beli1.X && jj==Game.Tablica.Beli1.Y))
                        return;
                    Game.Tablica.Beli2.X = ii;
                    Game.Tablica.Beli2.Y = jj;
                    Ispisivac.writePosition(ii, jj);
                    Ispisivac.writeNewLine();
                    Game.Tablica.postaviGa(ii, jj, Game.Tablica.Beli2);
                    stampaj();
                    clickCounter = 3;
                    //igrajbotvplay(0, 0);
                    gameStarted = true;
                    return;
                }
            }
            if (!gameStarted && clickCounter==0 && botvplay) {
                Random rnd = new Random();
                int i = rnd.Next(0, 5);
                int j = rnd.Next(0, 5);
                Game.Tablica.Crni1.X = i;
                Game.Tablica.Crni1.Y = j;
                Game.Tablica.postaviGa(i,j,Game.Tablica.Crni1);
                Ispisivac.writePosition(i, j);
                Ispisivac.writeSpace();
                i = rnd.Next(0, 5);
                j = rnd.Next(0, 5);
                while (i == Game.Tablica.Crni1.X && j == Game.Tablica.Crni1.Y) {
                    i = rnd.Next(0, 5);
                    j = rnd.Next(0, 5);
                }
                Game.Tablica.Crni2.X = i;
                Game.Tablica.Crni2.Y = j;
                Ispisivac.writePosition(i, j);
                Ispisivac.writeNewLine();
                Game.Tablica.postaviGa(i, j, Game.Tablica.Crni2);
                clickCounter++;
            }
            stampaj();
            if (!gameStarted)
                return;
            if (botvbot)
                igrajbotvbot();
            else if (botvplay)
                igrajbotvplay(ii, jj);
            else
                igrajplayvplay(ii, jj);
        }

        private void igrajbotvbot() {
            if (firstMove==0) {
                firstMove++;
                return;
            }
            if (korakPoKorak)
                jeKliknuto = false;
            while (!Game.KrajIgre) {
                Potez pot = new Potez();
                JednostavanTakmicar.alfaBeta(Game.Tablica, null, dubina, float.MinValue, float.MaxValue, koIgra, out pot);
                Game.Tablica.odigrajPotez(pot);
                Ispisivac.writeMove(pot);
                stampaj();
                koIgra = !koIgra;
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 5; j++) {
                        if ((Game.Tablica.Matrica[i][j].StackObjekata.Count==4) && (Game.Tablica.Matrica[i][j].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)) {
                            Game.KrajIgre = true;
                        }
                    }
                }
                if (!jeKliknuto)
                    return;
            }
        }

        private void igrajbotvplay(int i, int j) {
            if (Game.KrajIgre)
                return;
            if (clickCounter==0 && Game.Tablica.Matrica[i][j].StackObjekata.Count!=0 && Game.Tablica.Matrica[i][j].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK) {
                odaklei = i; odaklej = j; clickCounter++;
                ((PictureBox)tablica.GetControlFromPosition(j, i)).BorderStyle = BorderStyle.Fixed3D;
            }
            else if (clickCounter==1) {
                ((PictureBox)tablica.GetControlFromPosition(odaklej, odaklei)).BorderStyle = BorderStyle.None;
                if ((Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.Count != 0) && (Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)) {
                    if (Game.Tablica.mozeDaPomeri(i, j, (Coveculjak)Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.First())) {
                        gdei = i; gdej = j;
                        Game.Tablica.pomeri(gdei, gdej, (Coveculjak)Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.First());
                        clickCounter++;
                        ((PictureBox)tablica.GetControlFromPosition(j, i)).BorderStyle = BorderStyle.Fixed3D;
                        stampaj();
                        return;
                    }
                }
                clickCounter = 0;
            }
            else if (clickCounter==2) {
                bool tuJePored = false;
                for (int ii=-1; ii<2; ii++) {
                    for (int jj=-1; jj<2; jj++) {
                        if ((i + ii == gdei) && (j + jj == gdej))
                            tuJePored = true;
                    }
                }
                if (!tuJePored) {
                    clickCounter = 2;
                    return;
                }
                if (Game.Tablica.mozeDaGradi(i, j, (Coveculjak)Game.Tablica.Matrica[gdei][gdej].StackObjekata.First())) {
                    ((PictureBox)tablica.GetControlFromPosition(gdej, gdei)).BorderStyle = BorderStyle.None;
                    Game.Tablica.gradi(i, j, (Coveculjak)Game.Tablica.Matrica[gdei][gdej].StackObjekata.First());
                    clickCounter++;
                    Ispisivac.writeHumanMove(odaklei, odaklej, gdei, gdej, gdegradii, gdegradij);
                    stampaj();
                }
            }
            proveriPobedu();
            if (Game.KrajIgre)
                return;
            if (clickCounter == 3) {
                Potez pot = new Potez();
                JednostavanTakmicar.alfaBeta(Game.Tablica, null, dubina, float.MinValue, float.MaxValue, false, out pot);
                Game.Tablica.odigrajPotez(pot);
                Ispisivac.writeMove(pot);
                clickCounter = 0;
                stampaj();
            }
            proveriPobedu();
        }

        public void proveriPobedu() {
            for (int i=0; i<5; i++) {
                for (int j=0; j<5; j++) {
                    if (Game.Tablica.Matrica[i][j].StackObjekata.Count == 4 && Game.Tablica.Matrica[i][j].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                        Game.KrajIgre = true;
                }
            }
        }

        private void igrajplayvplay(int i, int j) {
            if (Game.KrajIgre)
                return;
            if (koIgra == true) {
                if (clickCounter == 0 && Game.Tablica.Matrica[i][j].StackObjekata.Count != 0 && Game.Tablica.Matrica[i][j].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK) {
                    if (Game.Tablica.Matrica[i][j].StackObjekata.First() == Game.Tablica.Crni1 || Game.Tablica.Matrica[i][j].StackObjekata.First() == Game.Tablica.Crni2)
                        return;
                    odaklei = i; odaklej = j;
                    clickCounter++;
                    ((PictureBox)tablica.GetControlFromPosition(j, i)).BorderStyle = BorderStyle.Fixed3D;
                }
                else if (clickCounter == 1) {
                    ((PictureBox)tablica.GetControlFromPosition(odaklej, odaklei)).BorderStyle = BorderStyle.None;
                    if ((Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.Count != 0) && (Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)) {
                        if (Game.Tablica.mozeDaPomeri(i, j, (Coveculjak)Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.First())) {
                            gdei = i; gdej = j;
                            Game.Tablica.pomeri(gdei, gdej, (Coveculjak)Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.First());
                            clickCounter++;
                            ((PictureBox)tablica.GetControlFromPosition(j, i)).BorderStyle = BorderStyle.Fixed3D;
                            stampaj();
                            return;
                        }
                    }
                    clickCounter = 0;
                }
                else if (clickCounter == 2) {
                    bool tuJePored = false;
                    for (int ii = -1; ii < 2; ii++) {
                        for (int jj = -1; jj < 2; jj++) {
                            if ((i + ii == gdei) && (j + jj == gdej))
                                tuJePored = true;
                        }
                    }
                    if (!tuJePored) {
                        clickCounter = 2;
                        return;
                    }
                    if (Game.Tablica.mozeDaGradi(i, j, (Coveculjak)Game.Tablica.Matrica[gdei][gdej].StackObjekata.First())) {
                        ((PictureBox)tablica.GetControlFromPosition(gdej, gdei)).BorderStyle = BorderStyle.None;
                        Game.Tablica.gradi(i, j, (Coveculjak)Game.Tablica.Matrica[gdei][gdej].StackObjekata.First());
                        clickCounter++;
                        Ispisivac.writeHumanMove(odaklei, odaklej, gdei, gdej, gdegradii, gdegradij);
                        stampaj();
                        koIgra = !koIgra;
                        clickCounter = 0;
                    }
                }
            }
            else {
                if (clickCounter == 0 && Game.Tablica.Matrica[i][j].StackObjekata.Count != 0 && Game.Tablica.Matrica[i][j].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK) {
                    if (Game.Tablica.Matrica[i][j].StackObjekata.First() == Game.Tablica.Beli1 || Game.Tablica.Matrica[i][j].StackObjekata.First() == Game.Tablica.Beli2)
                        return;
                    odaklei = i; odaklej = j;
                    clickCounter++;
                    ((PictureBox)tablica.GetControlFromPosition(j, i)).BorderStyle = BorderStyle.Fixed3D;
                }
                else if (clickCounter == 1) {
                    ((PictureBox)tablica.GetControlFromPosition(odaklej, odaklei)).BorderStyle = BorderStyle.None;
                    if ((Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.Count != 0) && (Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)) {
                        if (Game.Tablica.mozeDaPomeri(i, j, (Coveculjak)Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.First())) {
                            gdei = i; gdej = j;
                            Game.Tablica.pomeri(gdei, gdej, (Coveculjak)Game.Tablica.Matrica[odaklei][odaklej].StackObjekata.First());
                            clickCounter++;
                            ((PictureBox)tablica.GetControlFromPosition(j, i)).BorderStyle = BorderStyle.Fixed3D;
                            stampaj();
                            return;
                        }
                    }
                    clickCounter = 0;
                }
                else if (clickCounter == 2) {
                    bool tuJePored = false;
                    for (int ii = -1; ii < 2; ii++) {
                        for (int jj = -1; jj < 2; jj++) {
                            if ((i + ii == gdei) && (j + jj == gdej))
                                tuJePored = true;
                        }
                    }
                    if (!tuJePored) {
                        clickCounter = 2;
                        return;
                    }
                    if (Game.Tablica.mozeDaGradi(i, j, (Coveculjak)Game.Tablica.Matrica[gdei][gdej].StackObjekata.First())) {
                        ((PictureBox)tablica.GetControlFromPosition(gdej, gdei)).BorderStyle = BorderStyle.None;
                        Game.Tablica.gradi(i, j, (Coveculjak)Game.Tablica.Matrica[gdei][gdej].StackObjekata.First());
                        clickCounter++;
                        Ispisivac.writeHumanMove(odaklei, odaklej, gdei, gdej, gdegradii, gdegradij);
                        stampaj();
                        koIgra = !koIgra;
                        clickCounter = 0;
                    }
                }
            }
            proveriPobedu();
        }

        private void stampaj() {
            for (int i = 0; i < tablica.RowCount; i++) {
                for (int j = 0; j < tablica.ColumnCount; j++) {
                    ObjectType tipPrvog = ObjectType.GRADJEVINA;
                    Coveculjak covec = null;
                    PictureBox pb = (PictureBox)tablica.GetControlFromPosition(j,i);
                    if (Game.Tablica.Matrica[i][j].StackObjekata.Count != 0) {
                        tipPrvog = Game.Tablica.Matrica[i][j].StackObjekata.First().TipObjekta;
                        if (Game.Tablica.Matrica[i][j].StackObjekata.First().TipObjekta == ObjectType.COVECULJAK)
                            covec = (Coveculjak)Game.Tablica.Matrica[i][j].StackObjekata.First();
                    }
                    else
                        tipPrvog = ObjectType.GRADJEVINA;
                    pb.Image = hashTablica[new Tuple<int, ObjectType, Coveculjak>(Game.Tablica.Matrica[i][j].StackObjekata.Count, tipPrvog, covec)];
                }
            }
        }

        private void gameWindow_Load(object sender, EventArgs e) {
            ucitajProzor();
        }
    }
}
