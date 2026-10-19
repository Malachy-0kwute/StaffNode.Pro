namespace StaffNode.Pro.UI.Pages
{
    partial class SettingsPageControl
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            themeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel1.Location = new Point(2, 19);
            materialLabel1.Margin = new Padding(20, 0, 20, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(50, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Theme";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(themeComboBox);
            panel1.Controls.Add(materialLabel1);
            panel1.Location = new Point(77, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 57);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(75, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 1);
            panel2.TabIndex = 2;
            // 
            // themeComboBox
            // 
            themeComboBox.AutoResize = true;
            themeComboBox.BackColor = Color.FromArgb(255, 255, 255);
            themeComboBox.Depth = 0;
            themeComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            themeComboBox.DropDownHeight = 174;
            themeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            themeComboBox.DropDownWidth = 121;
            themeComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            themeComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            themeComboBox.FormattingEnabled = true;
            themeComboBox.IntegralHeight = false;
            themeComboBox.ItemHeight = 43;
            themeComboBox.Items.AddRange(new object[] { "Light", "Dark" });
            themeComboBox.Location = new Point(946, 3);
            themeComboBox.MaxDropDownItems = 4;
            themeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            themeComboBox.Name = "themeComboBox";
            themeComboBox.Size = new Size(121, 49);
            themeComboBox.StartIndex = 0;
            themeComboBox.TabIndex = 2;
            // 
            // SettingsPageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Name = "SettingsPageControl";
            Size = new Size(1216, 855);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialComboBox themeComboBox;
        private Panel panel2;
    }
}
