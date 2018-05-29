namespace FormUI
{
    partial class Dashboard
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaMlek = new System.Windows.Forms.ListBox();
            this.WpiszMleko = new System.Windows.Forms.TextBox();
            this.wpisz = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaMlek
            // 
            this.ListaMlek.FormattingEnabled = true;
            this.ListaMlek.ItemHeight = 16;
            this.ListaMlek.Location = new System.Drawing.Point(65, 115);
            this.ListaMlek.Name = "ListaMlek";
            this.ListaMlek.Size = new System.Drawing.Size(391, 388);
            this.ListaMlek.TabIndex = 0;
            // 
            // WpiszMleko
            // 
            this.WpiszMleko.Location = new System.Drawing.Point(197, 24);
            this.WpiszMleko.Name = "WpiszMleko";
            this.WpiszMleko.Size = new System.Drawing.Size(258, 22);
            this.WpiszMleko.TabIndex = 1;
            // 
            // wpisz
            // 
            this.wpisz.AutoSize = true;
            this.wpisz.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wpisz.Location = new System.Drawing.Point(38, 30);
            this.wpisz.Name = "wpisz";
            this.wpisz.Size = new System.Drawing.Size(143, 16);
            this.wpisz.TabIndex = 2;
            this.wpisz.Text = "Wpisz nazwę mleka";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(380, 64);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Szukaj";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 535);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.wpisz);
            this.Controls.Add(this.WpiszMleko);
            this.Controls.Add(this.ListaMlek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "INPG Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaMlek;
        private System.Windows.Forms.TextBox WpiszMleko;
        private System.Windows.Forms.Label wpisz;
        private System.Windows.Forms.Button SearchButton;
    }
}

