namespace TicTacToe
{
    partial class mainGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGame));
            this.playFieldPanel = new System.Windows.Forms.Panel();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.restartPanel = new System.Windows.Forms.Panel();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.goToMainMenu = new System.Windows.Forms.Button();
            this.playFieldPanel.SuspendLayout();
            this.restartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playFieldPanel
            // 
            this.playFieldPanel.Controls.Add(this.button_8);
            this.playFieldPanel.Controls.Add(this.button_7);
            this.playFieldPanel.Controls.Add(this.button_6);
            this.playFieldPanel.Controls.Add(this.button_5);
            this.playFieldPanel.Controls.Add(this.button_4);
            this.playFieldPanel.Controls.Add(this.button_3);
            this.playFieldPanel.Controls.Add(this.button_2);
            this.playFieldPanel.Controls.Add(this.button_1);
            this.playFieldPanel.Controls.Add(this.button_0);
            this.playFieldPanel.Location = new System.Drawing.Point(12, 12);
            this.playFieldPanel.Name = "playFieldPanel";
            this.playFieldPanel.Size = new System.Drawing.Size(318, 318);
            this.playFieldPanel.TabIndex = 0;
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(215, 215);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(100, 100);
            this.button_8.TabIndex = 8;
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(109, 215);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(100, 100);
            this.button_7.TabIndex = 7;
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(3, 215);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(100, 100);
            this.button_6.TabIndex = 6;
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(215, 109);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(100, 100);
            this.button_5.TabIndex = 5;
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(109, 109);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(100, 100);
            this.button_4.TabIndex = 4;
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(3, 109);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(100, 100);
            this.button_3.TabIndex = 3;
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(215, 3);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(100, 100);
            this.button_2.TabIndex = 2;
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(109, 3);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(100, 100);
            this.button_1.TabIndex = 1;
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(3, 3);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(100, 100);
            this.button_0.TabIndex = 0;
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // restartPanel
            // 
            this.restartPanel.Controls.Add(this.winnerLabel);
            this.restartPanel.Controls.Add(this.goToMainMenu);
            this.restartPanel.Location = new System.Drawing.Point(12, 12);
            this.restartPanel.Name = "restartPanel";
            this.restartPanel.Size = new System.Drawing.Size(317, 317);
            this.restartPanel.TabIndex = 9;
            this.restartPanel.Visible = false;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winnerLabel.Location = new System.Drawing.Point(68, 53);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(0, 30);
            this.winnerLabel.TabIndex = 2;
            // 
            // goToMainMenu
            // 
            this.goToMainMenu.Location = new System.Drawing.Point(110, 215);
            this.goToMainMenu.Name = "goToMainMenu";
            this.goToMainMenu.Size = new System.Drawing.Size(100, 65);
            this.goToMainMenu.TabIndex = 0;
            this.goToMainMenu.Text = "Go To Menu";
            this.goToMainMenu.UseVisualStyleBackColor = true;
            this.goToMainMenu.Click += new System.EventHandler(this.goToMainMenu_Click);
            // 
            // mainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 341);
            this.Controls.Add(this.restartPanel);
            this.Controls.Add(this.playFieldPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainGame";
            this.Text = "TicTacToe";
            this.playFieldPanel.ResumeLayout(false);
            this.restartPanel.ResumeLayout(false);
            this.restartPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel playFieldPanel;
        private Button button_0;
        private Button button_2;
        private Button button_1;
        private Button button_3;
        private Button button_8;
        private Button button_7;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Panel restartPanel;
        private Button goToMainMenu;
        private Label winnerLabel;
    }
}