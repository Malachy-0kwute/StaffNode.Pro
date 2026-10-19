namespace StaffNode.Pro.UI.Pages
{
    partial class HomePageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageControl));
            panel1 = new Panel();
            getStartedButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            panel2 = new Panel();
            searchButton = new MaterialSkin.Controls.MaterialButton();
            searchTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(getStartedButton);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 855);
            panel1.TabIndex = 0;
            // 
            // getStartedButton
            // 
            getStartedButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            getStartedButton.AutoSize = false;
            getStartedButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            getStartedButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            getStartedButton.Depth = 0;
            getStartedButton.HighEmphasis = true;
            getStartedButton.Icon = null;
            getStartedButton.Location = new Point(484, 542);
            getStartedButton.Margin = new Padding(4, 6, 4, 6);
            getStartedButton.MouseState = MaterialSkin.MouseState.HOVER;
            getStartedButton.Name = "getStartedButton";
            getStartedButton.NoAccentTextColor = Color.Empty;
            getStartedButton.Size = new Size(243, 71);
            getStartedButton.TabIndex = 3;
            getStartedButton.Text = "Get Started";
            getStartedButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            getStartedButton.UseAccentColor = false;
            getStartedButton.UseVisualStyleBackColor = true;
            getStartedButton.Click += getStartedButton_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel2.Location = new Point(54, 335);
            materialLabel2.Margin = new Padding(54, 0, 54, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(1103, 97);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = resources.GetString("materialLabel2.Text");
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(searchTextBox);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1207, 60);
            panel2.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.AutoSize = false;
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchButton.Depth = 0;
            searchButton.HighEmphasis = true;
            searchButton.Icon = null;
            searchButton.Location = new Point(728, 5);
            searchButton.Margin = new Padding(4, 6, 4, 6);
            searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchButton.Name = "searchButton";
            searchButton.NoAccentTextColor = Color.Empty;
            searchButton.Size = new Size(120, 50);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchButton.UseAccentColor = false;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Visible = false;
            // 
            // searchTextBox
            // 
            searchTextBox.AnimateReadOnly = false;
            searchTextBox.BackgroundImageLayout = ImageLayout.None;
            searchTextBox.CharacterCasing = CharacterCasing.Normal;
            searchTextBox.Depth = 0;
            searchTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchTextBox.HideSelection = true;
            searchTextBox.Hint = "Search Employee, Dept. etc.";
            searchTextBox.LeadingIcon = null;
            searchTextBox.Location = new Point(221, 7);
            searchTextBox.MaxLength = 32767;
            searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.PrefixSuffixText = null;
            searchTextBox.ReadOnly = false;
            searchTextBox.RightToLeft = RightToLeft.No;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.ShortcutsEnabled = true;
            searchTextBox.Size = new Size(500, 48);
            searchTextBox.TabIndex = 0;
            searchTextBox.TabStop = false;
            searchTextBox.TextAlign = HorizontalAlignment.Left;
            searchTextBox.TrailingIcon = null;
            searchTextBox.UseSystemPasswordChar = false;
            searchTextBox.Visible = false;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel1.Location = new Point(54, 200);
            materialLabel1.Margin = new Padding(54, 0, 54, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(370, 58);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Welcome aboard,";
            // 
            // HomePageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Name = "HomePageControl";
            Size = new Size(1210, 855);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox2 searchTextBox;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton getStartedButton;
    }
}
