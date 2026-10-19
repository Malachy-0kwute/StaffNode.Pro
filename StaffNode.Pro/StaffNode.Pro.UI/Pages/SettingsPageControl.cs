using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static MaterialSkin.MaterialSkinManager;

namespace StaffNode.Pro.UI.Pages
{
    public partial class SettingsPageControl : UserControl
    {
        public SettingsPageControl()
        {
            InitializeComponent();

            themeComboBox.SelectedValueChanged += (s, e) =>
            {
                if (Parent?.Parent is MainWindow mainWindow)
                {
                    mainWindow.ChangeTheme(
                        themeComboBox.SelectedItem?.ToString()?
                        .Equals("light", StringComparison.InvariantCultureIgnoreCase) is true ? Themes.LIGHT : Themes.DARK);
                }
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            if (Parent?.Parent is MainWindow mainWindow)
            {
                themeComboBox.Text = Instance.Theme == Themes.LIGHT ? "Light" : "Dark";
            }

            base.OnLoad(e);
        }
    }
}
