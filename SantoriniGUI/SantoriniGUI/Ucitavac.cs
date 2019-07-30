using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d {
    class Ucitavac {

        private static String path = "C:\\Users\\etf.santorini.nd160604d\\Desktop\\SantoriniGUI\\InputFile";

        public static void ucitajPoziciju() {
            String[] lines = System.IO.File.ReadAllLines(path);
            int brojac = 0;
            foreach (String line in lines) {
                if (brojac < 2) {
                    char[] karak = line.ToCharArray();
                    int x1 = 0;
                    switch (karak[0]) {
                        case 'A': x1 = 0; break;
                        case 'B': x1 = 1; break;
                        case 'C': x1 = 2; break;
                        case 'D': x1 = 3; break;
                        case 'E': x1 = 4; break;
                    }
                    int y1 = karak[1] - 48;
                    int x2 = 0;
                    switch (karak[3]) {
                        case 'A': x2 = 0; break;
                        case 'B': x2 = 1; break;
                        case 'C': x2 = 2; break;
                        case 'D': x2 = 3; break;
                        case 'E': x2 = 4; break;
                    }
                    int y2 = karak[4] - 48;
                    if (brojac == 0) {
                        Game.Tablica.Beli1.X = x1; Game.Tablica.Beli1.Y = y1; Game.Tablica.postaviGa(x1, y1, Game.Tablica.Beli1);
                        Game.Tablica.Beli2.X = x2; Game.Tablica.Beli2.Y = y2; Game.Tablica.postaviGa(x2, y2, Game.Tablica.Beli2);
                        brojac++;
                    }
                    else if (brojac == 1) {
                        Game.Tablica.Crni1.X = x1; Game.Tablica.Crni1.Y = y1; Game.Tablica.postaviGa(x1, y1, Game.Tablica.Crni1);
                        Game.Tablica.Crni2.X = x2; Game.Tablica.Crni2.Y = y2; Game.Tablica.postaviGa(x2, y2, Game.Tablica.Crni2);
                        brojac++;
                    }
                }
                else {
                    char[] karak3 = line.ToCharArray();
                    int x1 = 0;
                    switch (karak3[0]) {
                        case 'A': x1 = 0; break;
                        case 'B': x1 = 1; break;
                        case 'C': x1 = 2; break;
                        case 'D': x1 = 3; break;
                        case 'E': x1 = 4; break;
                    }
                    int y1 = karak3[1] - 48;
                    int x2 = 0;
                    switch (karak3[3]) {
                        case 'A': x2 = 0; break;
                        case 'B': x2 = 1; break;
                        case 'C': x2 = 2; break;
                        case 'D': x2 = 3; break;
                        case 'E': x2 = 4; break;
                    }
                    int y2 = karak3[4] - 48;
                    int x3 = 0;
                    switch (karak3[6]) {
                        case 'A': x3 = 0; break;
                        case 'B': x3 = 1; break;
                        case 'C': x3 = 2; break;
                        case 'D': x3 = 3; break;
                        case 'E': x3 = 4; break;
                    }
                    int y3 = karak3[7] - 48;
                    Game.Tablica.odigrajPotez(new Potez((Coveculjak)Game.Tablica.Matrica[x1][y1].StackObjekata.First(), Game.Tablica.Matrica[x1][y1], Game.Tablica.Matrica[x2][y2], Game.Tablica.Matrica[x3][y3]));
                    gameWindow.koIgra = !gameWindow.koIgra;
                    gameWindow.gameStarted = true;
                    if (gameWindow.koIgra)
                        gameWindow.clickCounter = 3;
                    else
                        gameWindow.clickCounter = 0;
                }
            }
        }
    }
}
