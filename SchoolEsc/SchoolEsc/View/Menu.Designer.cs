namespace SchoolEsc.View
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayGame = new System.Windows.Forms.Button();
            this.Handleiding = new System.Windows.Forms.Button();
            this.ExitGame = new System.Windows.Forms.Button();
            this.MenuNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayGame
            // 
            this.PlayGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayGame.Location = new System.Drawing.Point(500, 325);
            this.PlayGame.Margin = new System.Windows.Forms.Padding(6);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(600, 150);
            this.PlayGame.TabIndex = 0;
            this.PlayGame.Text = "Play Game";
            this.PlayGame.UseVisualStyleBackColor = true;
            this.PlayGame.Click += new System.EventHandler(this.PlayGame_Click);
            // 
            // Handleiding
            // 
            this.Handleiding.Location = new System.Drawing.Point(500, 550);
            this.Handleiding.Margin = new System.Windows.Forms.Padding(6);
            this.Handleiding.Name = "Handleiding";
            this.Handleiding.Size = new System.Drawing.Size(600, 150);
            this.Handleiding.TabIndex = 1;
            this.Handleiding.Text = "Handleiding";
            this.Handleiding.UseVisualStyleBackColor = true;
            this.Handleiding.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitGame
            // 
            this.ExitGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitGame.Location = new System.Drawing.Point(500, 775);
            this.ExitGame.Margin = new System.Windows.Forms.Padding(6);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(600, 150);
            this.ExitGame.TabIndex = 2;
            this.ExitGame.Text = "Exit Game";
            this.ExitGame.UseVisualStyleBackColor = true;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // MenuNaam
            // 
            this.MenuNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuNaam.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MenuNaam.Location = new System.Drawing.Point(550, 125);
            this.MenuNaam.Name = "MenuNaam";
            this.MenuNaam.Size = new System.Drawing.Size(500, 100);
            this.MenuNaam.TabIndex = 3;
            this.MenuNaam.Text = "School Escape";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 1035);
            this.Controls.Add(this.MenuNaam);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.Handleiding);
            this.Controls.Add(this.PlayGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayGame;
        private System.Windows.Forms.Button ExitGame;
        private System.Windows.Forms.Button Handleiding;
        private System.Windows.Forms.Label MenuNaam;
    }
}

