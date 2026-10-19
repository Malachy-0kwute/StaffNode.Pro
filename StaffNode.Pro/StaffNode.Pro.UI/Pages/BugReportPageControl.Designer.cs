namespace StaffNode.Pro.UI.Pages
{
    partial class BugReportPageControl
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
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialMultiLineTextBox21 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Issue subject";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(205, 180);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(800, 48);
            materialTextBox21.TabIndex = 0;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialMultiLineTextBox21
            // 
            materialMultiLineTextBox21.AnimateReadOnly = false;
            materialMultiLineTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialMultiLineTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialMultiLineTextBox21.Depth = 0;
            materialMultiLineTextBox21.HideSelection = true;
            materialMultiLineTextBox21.Hint = "Bug description";
            materialMultiLineTextBox21.Location = new Point(205, 272);
            materialMultiLineTextBox21.MaxLength = 32767;
            materialMultiLineTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialMultiLineTextBox21.Name = "materialMultiLineTextBox21";
            materialMultiLineTextBox21.PasswordChar = '\0';
            materialMultiLineTextBox21.ReadOnly = false;
            materialMultiLineTextBox21.ScrollBars = ScrollBars.None;
            materialMultiLineTextBox21.SelectedText = "";
            materialMultiLineTextBox21.SelectionLength = 0;
            materialMultiLineTextBox21.SelectionStart = 0;
            materialMultiLineTextBox21.ShortcutsEnabled = true;
            materialMultiLineTextBox21.Size = new Size(800, 287);
            materialMultiLineTextBox21.TabIndex = 1;
            materialMultiLineTextBox21.TabStop = false;
            materialMultiLineTextBox21.TextAlign = HorizontalAlignment.Left;
            materialMultiLineTextBox21.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel1.Location = new Point(205, 83);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(800, 54);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Found a glitch or something not working as expected? Help us fix it! \r\nPlease provide as much detail as possible so our engineering team can investigate and deploy a fix.";
            materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(480, 607);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(250, 68);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Submit report";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // BugReportPageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialButton1);
            Controls.Add(materialLabel1);
            Controls.Add(materialMultiLineTextBox21);
            Controls.Add(materialTextBox21);
            Name = "BugReportPageControl";
            Size = new Size(1210, 855);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox21;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}
