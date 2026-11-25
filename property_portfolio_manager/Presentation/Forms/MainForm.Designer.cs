namespace property_portfolio_manager.Presentation.Forms
{
    partial class MainForm
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
            sidebarPanel = new Panel();
            navigationPanel = new FlowLayoutPanel();
            dashboardButton = new Button();
            propertiesButton = new Button();
            paymentsButton = new Button();
            maintenanceButton = new Button();
            deadlinesButton = new Button();
            performanceButton = new Button();
            brandTitleLabel = new Label();
            mainContentPanel = new Panel();
            pageHostPanel = new Panel();
            headerPanel = new Panel();
            pageTitleLabel = new Label();
            sidebarPanel.SuspendLayout();
            navigationPanel.SuspendLayout();
            mainContentPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(30, 41, 59);
            sidebarPanel.Controls.Add(navigationPanel);
            sidebarPanel.Controls.Add(brandTitleLabel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(220, 774);
            sidebarPanel.TabIndex = 0;
            // 
            // navigationPanel
            // 
            navigationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navigationPanel.AutoScroll = true;
            navigationPanel.Controls.Add(dashboardButton);
            navigationPanel.Controls.Add(propertiesButton);
            navigationPanel.Controls.Add(paymentsButton);
            navigationPanel.Controls.Add(maintenanceButton);
            navigationPanel.Controls.Add(deadlinesButton);
            navigationPanel.Controls.Add(performanceButton);
            navigationPanel.FlowDirection = FlowDirection.TopDown;
            navigationPanel.Location = new Point(12, 110);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(196, 500);
            navigationPanel.TabIndex = 1;
            navigationPanel.WrapContents = false;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.FromArgb(51, 65, 85);
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(71, 85, 105);
            dashboardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Location = new Point(0, 0);
            dashboardButton.Margin = new Padding(0, 0, 0, 8);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(16, 0, 0, 0);
            dashboardButton.Size = new Size(196, 46);
            dashboardButton.TabIndex = 0;
            dashboardButton.Text = "Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // propertiesButton
            // 
            propertiesButton.BackColor = Color.FromArgb(30, 41, 59);
            propertiesButton.Cursor = Cursors.Hand;
            propertiesButton.FlatAppearance.BorderSize = 0;
            propertiesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(71, 85, 105);
            propertiesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            propertiesButton.FlatStyle = FlatStyle.Flat;
            propertiesButton.Font = new Font("Segoe UI", 10F);
            propertiesButton.ForeColor = Color.White;
            propertiesButton.Location = new Point(0, 54);
            propertiesButton.Margin = new Padding(0, 0, 0, 8);
            propertiesButton.Name = "propertiesButton";
            propertiesButton.Padding = new Padding(16, 0, 0, 0);
            propertiesButton.Size = new Size(196, 46);
            propertiesButton.TabIndex = 1;
            propertiesButton.Text = "Properties";
            propertiesButton.TextAlign = ContentAlignment.MiddleLeft;
            propertiesButton.UseVisualStyleBackColor = false;
            propertiesButton.Click += propertiesButton_Click;
            // 
            // paymentsButton
            // 
            paymentsButton.BackColor = Color.FromArgb(30, 41, 59);
            paymentsButton.Cursor = Cursors.Hand;
            paymentsButton.FlatAppearance.BorderSize = 0;
            paymentsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(71, 85, 105);
            paymentsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            paymentsButton.FlatStyle = FlatStyle.Flat;
            paymentsButton.Font = new Font("Segoe UI", 10F);
            paymentsButton.ForeColor = Color.White;
            paymentsButton.Location = new Point(0, 108);
            paymentsButton.Margin = new Padding(0, 0, 0, 8);
            paymentsButton.Name = "paymentsButton";
            paymentsButton.Padding = new Padding(16, 0, 0, 0);
            paymentsButton.Size = new Size(196, 46);
            paymentsButton.TabIndex = 2;
            paymentsButton.Text = "Payments";
            paymentsButton.TextAlign = ContentAlignment.MiddleLeft;
            paymentsButton.UseVisualStyleBackColor = false;
            paymentsButton.Click += paymentsButton_Click;
            // 
            // maintenanceButton
            // 
            maintenanceButton.BackColor = Color.FromArgb(30, 41, 59);
            maintenanceButton.Cursor = Cursors.Hand;
            maintenanceButton.FlatAppearance.BorderSize = 0;
            maintenanceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(71, 85, 105);
            maintenanceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            maintenanceButton.FlatStyle = FlatStyle.Flat;
            maintenanceButton.Font = new Font("Segoe UI", 10F);
            maintenanceButton.ForeColor = Color.White;
            maintenanceButton.Location = new Point(0, 162);
            maintenanceButton.Margin = new Padding(0, 0, 0, 8);
            maintenanceButton.Name = "maintenanceButton";
            maintenanceButton.Padding = new Padding(16, 0, 0, 0);
            maintenanceButton.Size = new Size(196, 46);
            maintenanceButton.TabIndex = 3;
            maintenanceButton.Text = "Maintenance";
            maintenanceButton.TextAlign = ContentAlignment.MiddleLeft;
            maintenanceButton.UseVisualStyleBackColor = false;
            maintenanceButton.Click += maintenanceButton_Click;
            // 
            // deadlinesButton
            // 
            deadlinesButton.BackColor = Color.FromArgb(30, 41, 59);
            deadlinesButton.Cursor = Cursors.Hand;
            deadlinesButton.FlatAppearance.BorderSize = 0;
            deadlinesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(71, 85, 105);
            deadlinesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            deadlinesButton.FlatStyle = FlatStyle.Flat;
            deadlinesButton.Font = new Font("Segoe UI", 10F);
            deadlinesButton.ForeColor = Color.White;
            deadlinesButton.Location = new Point(0, 216);
            deadlinesButton.Margin = new Padding(0, 0, 0, 8);
            deadlinesButton.Name = "deadlinesButton";
            deadlinesButton.Padding = new Padding(16, 0, 0, 0);
            deadlinesButton.Size = new Size(196, 46);
            deadlinesButton.TabIndex = 4;
            deadlinesButton.Text = "Deadlines";
            deadlinesButton.TextAlign = ContentAlignment.MiddleLeft;
            deadlinesButton.UseVisualStyleBackColor = false;
            deadlinesButton.Click += deadlinesButton_Click;
            // 
            // performanceButton
            // 
            performanceButton.BackColor = Color.FromArgb(30, 41, 59);
            performanceButton.Cursor = Cursors.Hand;
            performanceButton.FlatAppearance.BorderSize = 0;
            performanceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(71, 85, 105);
            performanceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            performanceButton.FlatStyle = FlatStyle.Flat;
            performanceButton.Font = new Font("Segoe UI", 10F);
            performanceButton.ForeColor = Color.White;
            performanceButton.Location = new Point(0, 270);
            performanceButton.Margin = new Padding(0, 0, 0, 8);
            performanceButton.Name = "performanceButton";
            performanceButton.Padding = new Padding(16, 0, 0, 0);
            performanceButton.Size = new Size(196, 46);
            performanceButton.TabIndex = 5;
            performanceButton.Text = "Performance";
            performanceButton.TextAlign = ContentAlignment.MiddleLeft;
            performanceButton.UseVisualStyleBackColor = false;
            performanceButton.Click += performanceButton_Click;
            // 
            // brandTitleLabel
            // 
            brandTitleLabel.BackColor = Color.Transparent;
            brandTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            brandTitleLabel.ForeColor = Color.White;
            brandTitleLabel.Location = new Point(20, 18);
            brandTitleLabel.Name = "brandTitleLabel";
            brandTitleLabel.Size = new Size(180, 56);
            brandTitleLabel.TabIndex = 0;
            brandTitleLabel.Text = "PROPERTY PORTFOLIO";
            brandTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainContentPanel
            // 
            mainContentPanel.Controls.Add(pageHostPanel);
            mainContentPanel.Controls.Add(headerPanel);
            mainContentPanel.Dock = DockStyle.Fill;
            mainContentPanel.Location = new Point(220, 0);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(1110, 774);
            mainContentPanel.TabIndex = 1;
            // 
            // pageHostPanel
            // 
            pageHostPanel.Dock = DockStyle.Fill;
            pageHostPanel.Location = new Point(0, 76);
            pageHostPanel.Name = "pageHostPanel";
            pageHostPanel.Size = new Size(1110, 698);
            pageHostPanel.TabIndex = 1;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(pageTitleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(24, 12, 24, 12);
            headerPanel.Size = new Size(1110, 76);
            headerPanel.TabIndex = 0;
            // 
            // pageTitleLabel
            // 
            pageTitleLabel.AutoSize = true;
            pageTitleLabel.BackColor = Color.Transparent;
            pageTitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            pageTitleLabel.ForeColor = Color.FromArgb(30, 41, 59);
            pageTitleLabel.Location = new Point(24, 20);
            pageTitleLabel.Name = "pageTitleLabel";
            pageTitleLabel.Size = new Size(171, 41);
            pageTitleLabel.TabIndex = 0;
            pageTitleLabel.Text = "Dashboard";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 246, 250);
            ClientSize = new Size(1330, 774);
            Controls.Add(mainContentPanel);
            Controls.Add(sidebarPanel);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1123, 729);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Portfolio Dashboard";
            Load += MainForm_Load;
            sidebarPanel.ResumeLayout(false);
            navigationPanel.ResumeLayout(false);
            mainContentPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private Panel mainContentPanel;
        private Panel headerPanel;
        private Panel pageHostPanel;
        private Label pageTitleLabel;
        private Label brandTitleLabel;
        private FlowLayoutPanel navigationPanel;
        private Button dashboardButton;
        private Button propertiesButton;
        private Button paymentsButton;
        private Button maintenanceButton;
        private Button deadlinesButton;
        private Button performanceButton;
    }
}
