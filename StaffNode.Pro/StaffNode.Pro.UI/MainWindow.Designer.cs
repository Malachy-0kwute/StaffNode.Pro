using MaterialSkin.Controls;

namespace StaffNode.Pro.UI
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            menuButton = new MaterialButton();
            employeesButton = new MaterialButton();
            settingsButton = new MaterialButton();
            onboardButton = new MaterialButton();
            reportBugButton = new MaterialButton();
            homeButton = new MaterialButton();
            supportButton = new MaterialButton();
            sideMenuDrawer = new Panel();
            mainView = new Panel();
            sideMenuDrawer.SuspendLayout();
            SuspendLayout();
            // 
            // menuButton
            // 
            menuButton.AutoSize = false;
            menuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            menuButton.Density = MaterialButton.MaterialButtonDensity.Default;
            menuButton.Depth = 0;
            menuButton.DrawShadows = false;
            menuButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            menuButton.HighEmphasis = true;
            menuButton.Icon = (Image)resources.GetObject("menuButton.Icon");
            menuButton.Location = new Point(7, 24);
            menuButton.Margin = new Padding(4, 6, 4, 6);
            menuButton.MouseState = MaterialSkin.MouseState.HOVER;
            menuButton.Name = "menuButton";
            menuButton.NoAccentTextColor = Color.Empty;
            menuButton.Size = new Size(40, 40);
            menuButton.TabIndex = 1;
            menuButton.Type = MaterialButton.MaterialButtonType.Contained;
            menuButton.UseAccentColor = false;
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // employeesButton
            // 
            employeesButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeesButton.AutoSize = false;
            employeesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            employeesButton.Density = MaterialButton.MaterialButtonDensity.Default;
            employeesButton.Depth = 0;
            employeesButton.DrawShadows = false;
            employeesButton.Font = new Font("Segoe UI", 12F);
            employeesButton.HighEmphasis = true;
            employeesButton.Icon = (Image)resources.GetObject("employeesButton.Icon");
            employeesButton.ImageAlign = ContentAlignment.MiddleLeft;
            employeesButton.Location = new Point(5, 94);
            employeesButton.Margin = new Padding(4, 6, 4, 6);
            employeesButton.MouseState = MaterialSkin.MouseState.HOVER;
            employeesButton.Name = "employeesButton";
            employeesButton.NoAccentTextColor = Color.Empty;
            employeesButton.Size = new Size(42, 41);
            employeesButton.TabIndex = 5;
            employeesButton.Text = "Employees";
            employeesButton.TextAlign = ContentAlignment.MiddleLeft;
            employeesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            employeesButton.Type = MaterialButton.MaterialButtonType.Text;
            employeesButton.UseAccentColor = false;
            employeesButton.UseVisualStyleBackColor = true;
            employeesButton.Click += employeesButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingsButton.AutoSize = false;
            settingsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            settingsButton.Density = MaterialButton.MaterialButtonDensity.Default;
            settingsButton.Depth = 0;
            settingsButton.DrawShadows = false;
            settingsButton.Font = new Font("Segoe UI", 12F);
            settingsButton.HighEmphasis = true;
            settingsButton.Icon = (Image)resources.GetObject("settingsButton.Icon");
            settingsButton.ImageAlign = ContentAlignment.MiddleLeft;
            settingsButton.Location = new Point(5, 138);
            settingsButton.Margin = new Padding(4, 6, 4, 6);
            settingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            settingsButton.Name = "settingsButton";
            settingsButton.NoAccentTextColor = Color.Empty;
            settingsButton.Size = new Size(42, 41);
            settingsButton.TabIndex = 6;
            settingsButton.Text = "Settings";
            settingsButton.TextAlign = ContentAlignment.MiddleLeft;
            settingsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            settingsButton.Type = MaterialButton.MaterialButtonType.Text;
            settingsButton.UseAccentColor = false;
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // onboardButton
            // 
            onboardButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            onboardButton.AutoSize = false;
            onboardButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            onboardButton.Density = MaterialButton.MaterialButtonDensity.Default;
            onboardButton.Depth = 0;
            onboardButton.DrawShadows = false;
            onboardButton.Font = new Font("Segoe UI", 12F);
            onboardButton.HighEmphasis = true;
            onboardButton.Icon = (Image)resources.GetObject("onboardButton.Icon");
            onboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            onboardButton.Location = new Point(5, 50);
            onboardButton.Margin = new Padding(4, 6, 4, 6);
            onboardButton.MouseState = MaterialSkin.MouseState.HOVER;
            onboardButton.Name = "onboardButton";
            onboardButton.NoAccentTextColor = Color.Empty;
            onboardButton.Size = new Size(42, 41);
            onboardButton.TabIndex = 4;
            onboardButton.Text = "Onboard";
            onboardButton.TextAlign = ContentAlignment.MiddleLeft;
            onboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            onboardButton.Type = MaterialButton.MaterialButtonType.Text;
            onboardButton.UseAccentColor = false;
            onboardButton.UseVisualStyleBackColor = true;
            onboardButton.Click += onboardButton_Click;
            // 
            // reportBugButton
            // 
            reportBugButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportBugButton.AutoSize = false;
            reportBugButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reportBugButton.Density = MaterialButton.MaterialButtonDensity.Default;
            reportBugButton.Depth = 0;
            reportBugButton.DrawShadows = false;
            reportBugButton.Font = new Font("Segoe UI", 12F);
            reportBugButton.HighEmphasis = true;
            reportBugButton.Icon = (Image)resources.GetObject("reportBugButton.Icon");
            reportBugButton.ImageAlign = ContentAlignment.MiddleLeft;
            reportBugButton.Location = new Point(5, 537);
            reportBugButton.Margin = new Padding(4, 6, 4, 6);
            reportBugButton.MouseState = MaterialSkin.MouseState.HOVER;
            reportBugButton.Name = "reportBugButton";
            reportBugButton.NoAccentTextColor = Color.Empty;
            reportBugButton.Size = new Size(42, 41);
            reportBugButton.TabIndex = 7;
            reportBugButton.Text = "Report a bug";
            reportBugButton.TextAlign = ContentAlignment.MiddleLeft;
            reportBugButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            reportBugButton.Type = MaterialButton.MaterialButtonType.Text;
            reportBugButton.UseAccentColor = false;
            reportBugButton.UseVisualStyleBackColor = true;
            reportBugButton.Click += reportBugButton_Click;
            // 
            // homeButton
            // 
            homeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homeButton.AutoSize = false;
            homeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            homeButton.Density = MaterialButton.MaterialButtonDensity.Default;
            homeButton.Depth = 0;
            homeButton.DrawShadows = false;
            homeButton.Font = new Font("Segoe UI", 12F);
            homeButton.HighEmphasis = true;
            homeButton.Icon = (Image)resources.GetObject("homeButton.Icon");
            homeButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeButton.Location = new Point(5, 6);
            homeButton.Margin = new Padding(4, 6, 4, 6);
            homeButton.MouseState = MaterialSkin.MouseState.HOVER;
            homeButton.Name = "homeButton";
            homeButton.NoAccentTextColor = Color.Empty;
            homeButton.Size = new Size(42, 41);
            homeButton.TabIndex = 3;
            homeButton.Text = "Home";
            homeButton.TextAlign = ContentAlignment.MiddleLeft;
            homeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeButton.Type = MaterialButton.MaterialButtonType.Text;
            homeButton.UseAccentColor = false;
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // supportButton
            // 
            supportButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            supportButton.AutoSize = false;
            supportButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            supportButton.Density = MaterialButton.MaterialButtonDensity.Default;
            supportButton.Depth = 0;
            supportButton.DrawShadows = false;
            supportButton.Font = new Font("Segoe UI", 12F);
            supportButton.HighEmphasis = true;
            supportButton.Icon = (Image)resources.GetObject("supportButton.Icon");
            supportButton.ImageAlign = ContentAlignment.MiddleLeft;
            supportButton.Location = new Point(5, 581);
            supportButton.Margin = new Padding(4, 6, 4, 6);
            supportButton.MouseState = MaterialSkin.MouseState.HOVER;
            supportButton.Name = "supportButton";
            supportButton.NoAccentTextColor = Color.Empty;
            supportButton.Size = new Size(42, 41);
            supportButton.TabIndex = 8;
            supportButton.Text = "Support";
            supportButton.TextAlign = ContentAlignment.MiddleLeft;
            supportButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            supportButton.Type = MaterialButton.MaterialButtonType.Text;
            supportButton.UseAccentColor = false;
            supportButton.UseVisualStyleBackColor = true;
            supportButton.Click += supportButton_Click;
            // 
            // sideMenuDrawer
            // 
            sideMenuDrawer.BorderStyle = BorderStyle.FixedSingle;
            sideMenuDrawer.Controls.Add(homeButton);
            sideMenuDrawer.Controls.Add(supportButton);
            sideMenuDrawer.Controls.Add(employeesButton);
            sideMenuDrawer.Controls.Add(settingsButton);
            sideMenuDrawer.Controls.Add(reportBugButton);
            sideMenuDrawer.Controls.Add(onboardButton);
            sideMenuDrawer.Dock = DockStyle.Left;
            sideMenuDrawer.Location = new Point(0, 64);
            sideMenuDrawer.Name = "sideMenuDrawer";
            sideMenuDrawer.Size = new Size(54, 697);
            sideMenuDrawer.TabIndex = 11;
            // 
            // mainView
            // 
            mainView.Dock = DockStyle.Fill;
            mainView.Location = new Point(54, 64);
            mainView.Name = "mainView";
            mainView.Size = new Size(1210, 697);
            mainView.TabIndex = 12;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1264, 761);
            Controls.Add(menuButton);
            Controls.Add(mainView);
            Controls.Add(sideMenuDrawer);
            MaximizeBox = false;
            Name = "MainWindow";
            Padding = new Padding(0, 64, 0, 0);
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            sideMenuDrawer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton menuButton;
        private MaterialButton employeesButton;
        private MaterialButton settingsButton;
        private MaterialButton onboardButton;
        private MaterialButton reportBugButton;
        private MaterialButton homeButton;
        private MaterialButton supportButton;
        private Panel sideMenuDrawer;
        private Panel mainView;
    }
}