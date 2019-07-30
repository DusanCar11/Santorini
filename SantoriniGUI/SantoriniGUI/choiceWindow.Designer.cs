namespace etf.santorini.nd160604d {
    partial class choiceWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExistingGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(67, 46);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExistingGame
            // 
            this.btnExistingGame.Location = new System.Drawing.Point(56, 116);
            this.btnExistingGame.Name = "btnExistingGame";
            this.btnExistingGame.Size = new System.Drawing.Size(99, 23);
            this.btnExistingGame.TabIndex = 1;
            this.btnExistingGame.Text = "Existing game";
            this.btnExistingGame.UseVisualStyleBackColor = true;
            this.btnExistingGame.Click += new System.EventHandler(this.btnExistingGame_Click);
            // 
            // choiceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 178);
            this.Controls.Add(this.btnExistingGame);
            this.Controls.Add(this.btnNewGame);
            this.Name = "choiceWindow";
            this.Text = "choiceWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExistingGame;
    }
}