namespace etf.santorini.nd160604d {
    partial class mainWindow {
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
            this.btnPlayervsPlayer = new System.Windows.Forms.Button();
            this.btnPlayervsBot = new System.Windows.Forms.Button();
            this.btnBotvsBot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayervsPlayer
            // 
            this.btnPlayervsPlayer.Location = new System.Drawing.Point(80, 47);
            this.btnPlayervsPlayer.Name = "btnPlayervsPlayer";
            this.btnPlayervsPlayer.Size = new System.Drawing.Size(129, 68);
            this.btnPlayervsPlayer.TabIndex = 0;
            this.btnPlayervsPlayer.Text = "Player vs Player";
            this.btnPlayervsPlayer.UseVisualStyleBackColor = true;
            this.btnPlayervsPlayer.Click += new System.EventHandler(this.btnPlayervsPlayer_Click);
            // 
            // btnPlayervsBot
            // 
            this.btnPlayervsBot.Location = new System.Drawing.Point(388, 50);
            this.btnPlayervsBot.Name = "btnPlayervsBot";
            this.btnPlayervsBot.Size = new System.Drawing.Size(131, 63);
            this.btnPlayervsBot.TabIndex = 1;
            this.btnPlayervsBot.Text = "Player vs Bot";
            this.btnPlayervsBot.UseVisualStyleBackColor = true;
            this.btnPlayervsBot.Click += new System.EventHandler(this.btnPlayervsBot_Click);
            // 
            // btnBotvsBot
            // 
            this.btnBotvsBot.Location = new System.Drawing.Point(80, 213);
            this.btnBotvsBot.Name = "btnBotvsBot";
            this.btnBotvsBot.Size = new System.Drawing.Size(129, 63);
            this.btnBotvsBot.TabIndex = 2;
            this.btnBotvsBot.Text = "Bot vs Bot";
            this.btnBotvsBot.UseVisualStyleBackColor = true;
            this.btnBotvsBot.Click += new System.EventHandler(this.btnBotvsBot_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bot vs Bot\r\nStep by step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBotvsBot);
            this.Controls.Add(this.btnPlayervsBot);
            this.Controls.Add(this.btnPlayervsPlayer);
            this.Name = "mainWindow";
            this.Text = "Santorini";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayervsPlayer;
        private System.Windows.Forms.Button btnPlayervsBot;
        private System.Windows.Forms.Button btnBotvsBot;
        private System.Windows.Forms.Button button1;
    }
}

