using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etf.santorini.nd160604d {
    public partial class mainWindow : Form {
        public mainWindow() {
            InitializeComponent();
        }

        private void btnPlayervsBot_Click(object sender, EventArgs e) {
            difficultyWindow f = new difficultyWindow();
            gameWindow.botvplay = true;
            gameWindow.botvbot = false;
            f.ShowDialog();
        }

        private void btnBotvsBot_Click(object sender, EventArgs e) {
            difficultyWindow f = new difficultyWindow();
            gameWindow.botvbot = true;
            gameWindow.botvplay = false;
            gameWindow.jeKliknuto = true;
            f.ShowDialog();
        }

        private void btnPlayervsPlayer_Click(object sender, EventArgs e) {
            gameWindow f = new gameWindow();
            gameWindow.clickCounter = 0;
            gameWindow.gameStarted = false;
            gameWindow.odaklei = gameWindow.odaklej = gameWindow.gdei = gameWindow.gdej = gameWindow.gdegradii = gameWindow.gdegradij = 0;
            gameWindow.botvbot = false;
            gameWindow.botvplay = false;
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            difficultyWindow f = new difficultyWindow();
            gameWindow.botvbot = true;
            gameWindow.botvplay = false;
            gameWindow.korakPoKorak = true;
            gameWindow.jeKliknuto = false;
            f.ShowDialog();
        }

        private void btnLoadFrom_Click(object sender, EventArgs e) {
            Ucitavac.ucitajPoziciju();
        }
    }
}
