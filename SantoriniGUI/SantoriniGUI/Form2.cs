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
    public partial class difficultyWindow : Form {
        public difficultyWindow() {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e) {
            choiceWindow c = new choiceWindow();
            gameWindow.dubina = 3;
            gameWindow.clickCounter = 0;
            gameWindow.gameStarted = false;
            gameWindow.odaklei = gameWindow.odaklej = gameWindow.gdei = gameWindow.gdej = gameWindow.gdegradii = gameWindow.gdegradij = 0;
            c.ShowDialog();
        }

        private void btnMedium_Click(object sender, EventArgs e) {
            choiceWindow c = new choiceWindow();
            gameWindow.dubina = 4;
            gameWindow.clickCounter = 0;
            gameWindow.gameStarted = false;
            gameWindow.odaklei = gameWindow.odaklej = gameWindow.gdei = gameWindow.gdej = gameWindow.gdegradii = gameWindow.gdegradij = 0;
            c.ShowDialog();
        }

        private void btnHard_Click(object sender, EventArgs e) {
            choiceWindow c = new choiceWindow();
            gameWindow.dubina = 5;
            gameWindow.clickCounter = 0;
            gameWindow.gameStarted = false;
            gameWindow.odaklei = gameWindow.odaklej = gameWindow.gdei = gameWindow.gdej = gameWindow.gdegradii = gameWindow.gdegradij = 0;
            c.ShowDialog();
        }
    }
}
