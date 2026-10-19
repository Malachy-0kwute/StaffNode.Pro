using System.ComponentModel;

namespace StaffNode.Pro.UI.Popup
{
    public partial class EmployeeDetailPopupControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string FirstName { get => firstName.Text; set => firstName.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string LastName { get => lastName.Text; set => lastName.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Email { get => email.Text; set => email.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string JobTitle { get => jobTitle.Text; set => jobTitle.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string PhoneNumber { get => phoneNumber.Text; set => phoneNumber.Text = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Address { get => address.Text; set => address.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string City { get => city.Text; set => city.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string State { get => state.Text; set => state.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string ZipCode { get => zipCode.Text; set => zipCode.Text = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string EmployeeId { get => empId.Text; set => empId.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Department { get => department.Text; set => department.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Salary { get => salary.Text; set => salary.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string HireDate { get => hireDate.Text; set => hireDate.Text = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string TerminationDate { get => terminationDate.Text; set => terminationDate.Text = value; }

        public EmployeeDetailPopupControl()
        {
            InitializeComponent();
        }
    }
}
