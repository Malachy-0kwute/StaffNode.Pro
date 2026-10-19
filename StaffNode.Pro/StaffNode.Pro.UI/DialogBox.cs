using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic.Devices;

namespace StaffNode.Pro.UI
{
    public partial class DialogBox : MaterialForm
    {
        public DialogBox()
        {
            InitializeComponent();

            if (Owner is MainWindow window)
            {
                window.MaterialSkinManager.AddFormToManage(this);
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
