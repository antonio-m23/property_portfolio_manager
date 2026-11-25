using System.Drawing;
using property_portfolio_manager.Presentation.Views;

namespace property_portfolio_manager.Presentation.Forms
{
    public partial class MainForm : Form
    {
        private readonly Font _activeNavigationFont;
        private readonly Font _inactiveNavigationFont;

        public MainForm()
        {
            InitializeComponent();

            _activeNavigationFont = dashboardButton.Font;
            _inactiveNavigationFont = propertiesButton.Font;

            ShowPage(new DashboardView(), "Dashboard");

            UpdateActiveNavigation(dashboardButton);
        }

        private void ShowPage(UserControl view, string title)
        {
            if (pageHostPanel.Controls.Count > 0)
            {
                Control previousView = pageHostPanel.Controls[0];

                pageHostPanel.Controls.Remove(previousView);

                previousView.Dispose();
            }

            view.Dock = DockStyle.Fill;
            pageHostPanel.Controls.Add(view);
            pageTitleLabel.Text = title;
        }

        private void UpdateActiveNavigation(Button selectedButton)
        {
            foreach (Control control in navigationPanel.Controls)
            {
                if (control is Button button)
                {
                    bool isActive = button == selectedButton;

                    button.BackColor = isActive
                        ? Color.FromArgb(51, 65, 85)
                        : Color.FromArgb(30, 41, 59);

                    button.Font = isActive
                        ? _activeNavigationFont
                        : _inactiveNavigationFont;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void propertiesButton_Click(object sender, EventArgs e)
        {
            ShowPage(new PropertiesView(), "Properties");

            UpdateActiveNavigation(propertiesButton);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            ShowPage(new DashboardView(), "Dashboard");

            UpdateActiveNavigation(dashboardButton);
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            ShowPage(new PaymentsView(), "Payments");

            UpdateActiveNavigation(paymentsButton);
        }

        private void maintenanceButton_Click(object sender, EventArgs e)
        {
            ShowPage(new MaintenanceView(), "Maintenance");

            UpdateActiveNavigation(maintenanceButton);
        }

        private void deadlinesButton_Click(object sender, EventArgs e)
        {
            ShowPage(new DeadlinesView(), "Deadlines");

            UpdateActiveNavigation(deadlinesButton);
        }

        private void performanceButton_Click(object sender, EventArgs e)
        {
            ShowPage(new PerformanceView(), "Performance");

            UpdateActiveNavigation(performanceButton);
        }
    }
}
