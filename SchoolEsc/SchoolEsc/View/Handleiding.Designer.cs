namespace SchoolEsc.View
{
    partial class Handleiding
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BackMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(400, 250);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(800, 450);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.AppendText("Dit spel is in opdracht van Thomas Boose, Ernst Bolt en Tijn Witsenburg gemaakt door BES-03.\n\n");
            this.richTextBox1.AppendText("In de huidige status van het spel zijn er twee verschillende soorten docenten. Een van de twee is een statische docent.");
            this.richTextBox1.AppendText("Deze docent blijft stilstaan en wanneer je tegen hem aan loopt zal je gepakt worden en verlies je 3 ECS's.\n");
            this.richTextBox1.AppendText("De andere soort is er eentje die je volgt. Ook wanneer deze vijand je pakt zal je 3 ECS's verliezen en moet je terug naar school.\n\n");
            this.richTextBox1.AppendText("Om te ontsnappen van deze docenten moet je gebruik maken van de pijltjestoetsen. Probeer bij het eindpunt te komen om je ECS's te verdienen en van Windesheim af te komen.\n\n");
            this.richTextBox1.AppendText("Veel succes!");

            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(86, 4);
            // 
            // BackMenu
            // 
            this.BackMenu.Location = new System.Drawing.Point(500, 775);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(600, 150);
            this.BackMenu.TabIndex = 2;
            this.BackMenu.Text = "Terug naar het hoofdmenu";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(550, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 100);
            this.label1.TabIndex = 3;
            this.label1.Text = "School Escape";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Handleiding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1039);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Handleiding";
            this.Text = "Handleiding";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Label label1;
    }
}