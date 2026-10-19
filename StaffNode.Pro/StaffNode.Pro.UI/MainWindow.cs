using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using StaffNode.Pro.UI.Pages;
using static MaterialSkin.MaterialSkinManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StaffNode.Pro.UI
{
    public partial class MainWindow : MaterialForm
    {
        public MaterialSkinManager MaterialSkinManager;
        private IServiceProvider _provider;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public MainWindow(IServiceProvider provider)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();
            InitializeMaterialSkin();

            _provider = provider;

            var client = provider.GetRequiredService<IHttpClientFactory>();

            Load += (s, e) => NavigateToView(new HomePageControl(_provider));
        }

        private void InitializeMaterialSkin()
        {
            MaterialSkinManager = Instance;
            MaterialSkinManager.AddFormToManage(this);
            MaterialSkinManager.Theme = Themes.LIGHT;
            MaterialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (sideMenuDrawer.Width.Equals(54))
            {
                mainView.Padding = new Padding(54, 0, 0, 0);
                mainView.SendToBack();
                sideMenuDrawer.Width = 200;
            }
            else
            {
                sideMenuDrawer.Width = 54;
                mainView.Padding = new Padding(0);
                mainView.BringToFront();
            }
        }

        public void NavigateToView(UserControl page)
        {
            if (mainView.Controls.Count > 0 && mainView.Controls[0].Name.Equals(page.Name))
            {
                return;
            }

            mainView.Controls.Clear();
            mainView.Controls.Add(page);
        }

        public void ChangeTheme(Themes theme)
        {
            if (MaterialSkinManager.Theme.Equals(theme) is false)
            {
                MaterialSkinManager.Theme = theme;
            }
        }

        #region Side Menu Button Events

        private void settingsButton_Click(object sender, EventArgs e)
        {
            NavigateToView(new SettingsPageControl());
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            NavigateToView(new HomePageControl(_provider));
        }

        private void onboardButton_Click(object sender, EventArgs e)
        {
            NavigateToView(new OnBoardPageControl(_provider));
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            NavigateToView(new EmployeesPageControl(_provider));
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            NavigateToView(new SupportPageControl());
        }

        private void reportBugButton_Click(object sender, EventArgs e)
        {
            NavigateToView(new BugReportPageControl());
        }

        #endregion
    }
}
