namespace StaffNode.Pro.UI
{
    partial class DialogBox
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
            doneButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            panel = new Panel();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // doneButton
            // 
            doneButton.AutoSize = false;
            doneButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            doneButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            doneButton.Depth = 0;
            doneButton.HighEmphasis = true;
            doneButton.Icon = null;
            doneButton.Location = new Point(725, 575);
            doneButton.Margin = new Padding(4, 6, 4, 6);
            doneButton.MouseState = MaterialSkin.MouseState.HOVER;
            doneButton.Name = "doneButton";
            doneButton.NoAccentTextColor = Color.Empty;
            doneButton.Size = new Size(158, 36);
            doneButton.TabIndex = 62;
            doneButton.Text = "OK";
            doneButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            doneButton.UseAccentColor = false;
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.Location = new Point(-9, -44);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(202, 29);
            materialLabel2.TabIndex = 50;
            materialLabel2.Text = "Student Informtion";
            // 
            // panel
            // 
            panel.Controls.Add(materialLabel2);
            panel.Location = new Point(3, 64);
            panel.Name = "panel";
            panel.Size = new Size(883, 500);
            panel.TabIndex = 0;
            // 
            // DialogBox
            // 
            AcceptButton = doneButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = doneButton;
            ClientSize = new Size(890, 620);
            Controls.Add(doneButton);
            Controls.Add(panel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            Sizable = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "DialogBox";
            TopMost = true;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton doneButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public Panel panel;
    }
}