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
            this.SuspendLayout();
            // 
            // PW_TRON
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "PW_TRON";
            this.Load += new System.EventHandler(this.PW_TRON_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IntroInfo;
    }
}

