namespace SchoolEsc.View
{
    partial class Speelveld
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Editor = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Pauze = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Eindpunt = new System.Windows.Forms.PictureBox();
            this.speelveldPanel1 = new SchoolEsc.View.SpeelveldPanel();

            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pauze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Editor);
            this.panel2.Location = new System.Drawing.Point(789, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 537);
            this.panel2.TabIndex = 1;
            // 
            // Editor
            // 
            this.Editor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Editor.AutoSize = true;
            this.Editor.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editor.Location = new System.Drawing.Point(73, 15);
            this.Editor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(102, 32);
            this.Editor.TabIndex = 0;
            this.Editor.Text = "Editor:";
            this.Editor.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Pauze);
            this.panel3.Controls.Add(this.Play);
            this.panel3.Controls.Add(this.Stop);
            this.panel3.Controls.Add(this.Score);
            this.panel3.Location = new System.Drawing.Point(16, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 64);
            this.panel3.TabIndex = 2;
            // 
            // Pauze
            // 
            this.Pauze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pauze.Image = global::SchoolEsc.Properties.Resources.pause_symbol;
            this.Pauze.Location = new System.Drawing.Point(672, 14);
            this.Pauze.Margin = new System.Windows.Forms.Padding(4);
            this.Pauze.Name = "Pauze";
            this.Pauze.Size = new System.Drawing.Size(33, 31);
            this.Pauze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pauze.TabIndex = 3;
            this.Pauze.TabStop = false;
            this.Pauze.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Play
            // 
            this.Play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Play.Image = global::SchoolEsc.Properties.Resources.play_button;
            this.Play.Location = new System.Drawing.Point(631, 14);
            this.Play.Margin = new System.Windows.Forms.Padding(4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(33, 31);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 2;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Image = global::SchoolEsc.Properties.Resources.stop;
            this.Stop.Location = new System.Drawing.Point(713, 14);
            this.Stop.Margin = new System.Windows.Forms.Padding(4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(33, 31);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stop.TabIndex = 1;
            this.Stop.TabStop = false;
            this.Stop.Click += new System.EventHandler(this.pictureBox3_Click);

            // 
            // Eindpunt
            // 
            this.Eindpunt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Eindpunt.Image = global::SchoolEsc.Properties.Resources.open_exit_door;
            this.Eindpunt.Location = new System.Drawing.Point(517, 389);
            this.Eindpunt.MaximumSize = new System.Drawing.Size(69, 60);
            this.Eindpunt.Name = "Eindpunt";
            this.Eindpunt.Size = new System.Drawing.Size(69, 60);
            this.Eindpunt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Eindpunt.TabIndex = 4;
            this.Eindpunt.TabStop = false;

            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(295, 15);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(67, 32);
            this.Score.TabIndex = 0;
            this.Score.Text = "EC: ";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // speelveldPanel1
            // 
            this.speelveldPanel1.Location = new System.Drawing.Point(16, 89);
            this.speelveldPanel1.Name = "speelveldPanel1";
            this.speelveldPanel1.Size = new System.Drawing.Size(765, 466);
            this.speelveldPanel1.TabIndex = 3;
            // 
            // Speelveld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.speelveldPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Speelveld";
            this.Text = "Speelveld";
            this.Load += new System.EventHandler(this.Speelveld_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pauze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Editor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox Stop;
        private System.Windows.Forms.PictureBox Pauze;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox Eindpunt;
        private SpeelveldPanel speelveldPanel1;
    }
}