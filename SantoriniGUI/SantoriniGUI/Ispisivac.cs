using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.santorini.nd160604d {
    class Ispisivac {

        private static String path = "C:\\Users\\dusan\\Desktop\\SantoriniGUI\\OutputFile";

        public static void open() {
            System.IO.File.WriteAllText(path,"");
        }

        public static void writeNewLine() {
            String[] lines = { "" };
            System.IO.File.AppendAllLines(@path, lines);
        }

        public static void writeSpace() {
            System.IO.File.AppendAllText(@path, " ");
        }

        public static void writePosition(int x, int y) {
            char slovo='A';
            switch (x) {
                case 0: slovo = 'A'; break;
                case 1: slovo = 'B'; break;
                case 2: slovo = 'C'; break;
                case 3: slovo = 'D'; break;
                case 4: slovo = 'E'; break;
            }
            System.IO.File.AppendAllText(@path, slovo+""+y);
        }

        public static void writeMove(Potez p) {
            char slovo = 'A';
            switch (p.Odakle.X) {
                case 0: slovo = 'A'; break;
                case 1: slovo = 'B'; break;
                case 2: slovo = 'C'; break;
                case 3: slovo = 'D'; break;
                case 4: slovo = 'E'; break;
            }
            char slovo1 = 'A';
            switch (p.Gde.X) {
                case 0: slovo1 = 'A'; break;
                case 1: slovo1 = 'B'; break;
                case 2: slovo1 = 'C'; break;
                case 3: slovo1 = 'D'; break;
                case 4: slovo1 = 'E'; break;
            }
            char slovo2 = 'A';
            switch (p.GdeGradi.X) {
                case 0: slovo2 = 'A'; break;
                case 1: slovo2 = 'B'; break;
                case 2: slovo2 = 'C'; break;
                case 3: slovo2 = 'D'; break;
                case 4: slovo2 = 'E'; break;
            }
            System.IO.File.AppendAllText(@path, slovo + "" + p.Odakle.Y + " " + slovo1 + "" + p.Gde.Y + " " + slovo2 + "" + p.GdeGradi.Y);
            writeNewLine();
        }

        public static void writeHumanMove(int x, int y, int x1, int y1, int x2, int y2) {
            char slovo = 'A';
            switch (x) {
                case 0: slovo = 'A'; break;
                case 1: slovo = 'B'; break;
                case 2: slovo = 'C'; break;
                case 3: slovo = 'D'; break;
                case 4: slovo = 'E'; break;
            }
            char slovo1 = 'A';
            switch (x1) {
                case 0: slovo1 = 'A'; break;
                case 1: slovo1 = 'B'; break;
                case 2: slovo1 = 'C'; break;
                case 3: slovo1 = 'D'; break;
                case 4: slovo1 = 'E'; break;
            }
            char slovo2 = 'A';
            switch (x2) {
                case 0: slovo2 = 'A'; break;
                case 1: slovo2 = 'B'; break;
                case 2: slovo2 = 'C'; break;
                case 3: slovo2 = 'D'; break;
                case 4: slovo2 = 'E'; break;
            }
            System.IO.File.AppendAllText(@path, slovo + "" + y + " " + slovo1 + "" + y1 + " " + slovo2 + "" + y2);
            writeNewLine();
        }

    }
}
