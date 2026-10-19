using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaffNode.Pro.UI.Pages
{
    public partial class HomePageControl : UserControl
    {
        private IServiceProvider _provider;

        public HomePageControl(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;
        }

        private void getStartedButton_Click(object sender, EventArgs e)
        {
            (Parent?.Parent as MainWindow)?.NavigateToView(new OnBoardPageControl(_provider));
        }
    }
}
