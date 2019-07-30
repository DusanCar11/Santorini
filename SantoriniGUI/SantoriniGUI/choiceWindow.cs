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
    public partial class choiceWindow : Form {
        public choiceWindow() {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e) {
            gameWindow f = new gameWindow();
            f.ShowDialog();
        }

        private void btnExistingGame_Click(object sender, EventArgs e) {
            gameWindow f = new etf.santorini.nd160604d.gameWindow();
            Ucitavac.ucitajPoziciju();
            f.proveriPobedu();
            f.ShowDialog();
        }
    }
}
