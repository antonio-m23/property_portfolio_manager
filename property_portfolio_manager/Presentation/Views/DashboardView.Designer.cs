namespace property_portfolio_manager.Presentation.Views
{
    partial class DashboardView
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            portfolioSummaryLabel = new Label();
            SuspendLayout();
            // 
            // portfolioSummaryLabel
            // 
            portfolioSummaryLabel.AutoSize = true;
            portfolioSummaryLabel.BackColor = Color.Transparent;
            portfolioSummaryLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            portfolioSummaryLabel.ForeColor = Color.FromArgb(30, 41, 59);
            portfolioSummaryLabel.Location = new Point(24, 24);
            portfolioSummaryLabel.Name = "portfolioSummaryLabel";
            portfolioSummaryLabel.Size = new Size(232, 32);
            portfolioSummaryLabel.TabIndex = 0;
            portfolioSummaryLabel.Text = "Portfolio Summary";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            Controls.Add(portfolioSummaryLabel);
            Name = "DashboardView";
            Size = new Size(900, 550);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label portfolioSummaryLabel;
    }
}
