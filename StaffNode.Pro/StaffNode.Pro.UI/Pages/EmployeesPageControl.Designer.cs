namespace StaffNode.Pro.UI.Pages
{
    partial class EmployeesPageControl
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
            panel2 = new Panel();
            searchButton = new MaterialSkin.Controls.MaterialButton();
            searchTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            employeeList = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            emptyListLabel = new MaterialSkin.Controls.MaterialLabel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(searchTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1210, 60);
            panel2.TabIndex = 2;
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
            // 
            // employeeList
            // 
            employeeList.Alignment = ListViewAlignment.Default;
            employeeList.AutoArrange = false;
            employeeList.AutoSizeTable = false;
            employeeList.BackColor = Color.FromArgb(255, 255, 255);
            employeeList.BorderStyle = BorderStyle.None;
            employeeList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            employeeList.Depth = 0;
            employeeList.Dock = DockStyle.Fill;
            employeeList.FullRowSelect = true;
            employeeList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            employeeList.Location = new Point(0, 60);
            employeeList.MinimumSize = new Size(200, 100);
            employeeList.MouseLocation = new Point(-1, -1);
            employeeList.MouseState = MaterialSkin.MouseState.OUT;
            employeeList.MultiSelect = false;
            employeeList.Name = "employeeList";
            employeeList.OwnerDraw = true;
            employeeList.Size = new Size(1210, 795);
            employeeList.Sorting = SortOrder.Ascending;
            employeeList.TabIndex = 3;
            employeeList.UseCompatibleStateImageBehavior = false;
            employeeList.View = View.Details;
            employeeList.Click += employeeList_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Employee id";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First name";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Last name";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone number";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Job title";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "hire date";
            columnHeader7.Width = 130;
            // 
            // emptyListLabel
            // 
            emptyListLabel.BackColor = Color.Transparent;
            emptyListLabel.Depth = 0;
            emptyListLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            emptyListLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            emptyListLabel.Location = new Point(382, 225);
            emptyListLabel.MouseState = MaterialSkin.MouseState.HOVER;
            emptyListLabel.Name = "emptyListLabel";
            emptyListLabel.Size = new Size(339, 63);
            emptyListLabel.TabIndex = 2;
            emptyListLabel.Text = "List of employees goes here (currently empty)";
            emptyListLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmployeesPageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(emptyListLabel);
            Controls.Add(employeeList);
            Controls.Add(panel2);
            Name = "EmployeesPageControl";
            Size = new Size(1210, 855);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialTextBox2 searchTextBox;
        private MaterialSkin.Controls.MaterialListView employeeList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private MaterialSkin.Controls.MaterialLabel emptyListLabel;
    }
}
