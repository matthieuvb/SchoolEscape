namespace SchoolEsc.View
{
    partial class SpeelveldPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Eindpunt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Eindpunt)).BeginInit();
            this.SuspendLayout();
            // 
            // Eindpunt
            // 
            this.Eindpunt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Eindpunt.BackColor = System.Drawing.Color.Transparent;
            this.Eindpunt.Image = global::SchoolEsc.Properties.Resources.open_exit_door;
            this.Eindpunt.Location = new System.Drawing.Point(669, 389);
            this.Eindpunt.Margin = new System.Windows.Forms.Padding(4);
            this.Eindpunt.MaximumSize = new System.Drawing.Size(92, 74);
            this.Eindpunt.Name = "Eindpunt";
            this.Eindpunt.Size = new System.Drawing.Size(90, 72);
            this.Eindpunt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Eindpunt.TabIndex = 0;
            this.Eindpunt.TabStop = false;
            // 
            // SpeelveldPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolEsc.Properties.Resources.Windesheim7_748x478;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Eindpunt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SpeelveldPanel";
            this.Size = new System.Drawing.Size(763, 464);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Eindpunt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Eindpunt;
    }
}
