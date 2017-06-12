namespace Tron_PG_WPA
{
    partial class PW_TRON
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.IntroInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntroInfo
            // 
            this.IntroInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntroInfo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IntroInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IntroInfo.Location = new System.Drawing.Point(0, 0);
            this.IntroInfo.Name = "IntroInfo";
            this.IntroInfo.Size = new System.Drawing.Size(539, 516);
            this.IntroInfo.TabIndex = 0;
            this.IntroInfo.Text = "Klon gdy Tron\r\nProjekt C# WPA PG lato 2017 \r\nAutor: Patryk Wyżgowski\r\n\r\nWciśnij E" +
    "nter, by rozpocząć grę.\r\n\r\nSterowanie:\r\nGracz 1: Strzałki\r\nGracz 2: WSAD\r\nPauza:" +
    " Spacja";
            this.IntroInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IntroInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // PW_TRON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 516);
            this.Controls.Add(this.IntroInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PW_TRON";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IntroInfo;
    }
}

