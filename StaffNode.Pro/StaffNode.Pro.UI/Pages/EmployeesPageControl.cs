using Microsoft.Extensions.DependencyInjection;
using StaffNode.Pro.UI.Helpers;
using StaffNode.Pro.UI.Models;
using StaffNode.Pro.UI.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace StaffNode.Pro.UI.Pages
{
    public partial class EmployeesPageControl : UserControl
    {
        private IServiceProvider _provider;
        private IHttpClientFactory _httpClientFactory;
        private List<EmployeeDataModel>? _employees;
        private List<ContactDataModel>? _employeeContacts;
        private List<ProfileDataModel>? _employeesProfile;

        public EmployeesPageControl(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;
            _employees = [];
            _employeeContacts = [];

            _httpClientFactory = _provider.GetRequiredService<IHttpClientFactory>();

            Load += (s, e) =>
            {
                var client = _httpClientFactory.CreateClient(HttpClientHelpers.CLIENTNAME);

                var empResponse = client.SendAsync(new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(client.BaseAddress, HttpClientHelpers.CURRENT_API_VERSION + "/employees")
                });

                var empContactResponse = client.SendAsync(new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(client.BaseAddress, HttpClientHelpers.CURRENT_API_VERSION + "/contacts")
                });

                var empProfileResponse = client.SendAsync(new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(client.BaseAddress, HttpClientHelpers.CURRENT_API_VERSION + "/contacts")
                });


                Task.Run(async () => await Task.WhenAll(empResponse, empContactResponse, empProfileResponse).ContinueWith(async result =>
                {
                    if (result.IsCompletedSuccessfully)
                    {
                        _employees.Clear();
                        _employeeContacts.Clear();
                        _employeesProfile?.Clear();

                        _employees = await empResponse.Result.Content.ReadFromJsonAsync<List<EmployeeDataModel>>();
                        _employeeContacts = await empContactResponse.Result.Content.ReadFromJsonAsync<List<ContactDataModel>>();
                        _employeesProfile = await empProfileResponse.Result.Content.ReadFromJsonAsync<List<ProfileDataModel>>();
                    }

                    if (_employees?.Count > 0 && _employeeContacts?.Count > 0)
                    {
                        // Jump on to UI thread to set properties
                        BeginInvoke(() =>
                        {
                            emptyListLabel.Visible = false;

                            employeeList.Items.Clear();

                            _employees.ForEach(emp =>
                            {
                                var empId = emp.EmployeeId.Substring(0, 6);
                                var contact = _employeeContacts.FirstOrDefault(e => e.Id == emp.ContactId);
                                var employee = new ListViewItem([empId, emp.FirstName, emp.LastName, contact?.Email ?? "n/a", contact?.PhoneNumber ?? "n/a", emp.JobTitle, emp.HireDate.ToShortDateString()]);
                                employeeList.Items.Add(employee);
                            });
                        });
                    }
                }));
            };
        }

        private void employeeList_Click(object sender, EventArgs e)
        {
            if (ParentForm is MainWindow window)
            {
                var dialog = new DialogBox();
                dialog.Owner = window;
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.Text = "Employee profile";

                var profile = new EmployeeDetailPopupControl();

                foreach (var item in employeeList.Items)
                {
                    if (item is ListViewItem listItem && listItem.Focused)
                    {
                        var empId = listItem.SubItems[0].Text;
                        var employee = _employees?.FirstOrDefault(x => x.Id.Substring(0, 6) == empId);
                        var empContact = _employeeContacts?.FirstOrDefault(x => x.Id == employee?.ContactId);

                        if (employee is not null)
                        {
                            profile.FirstName = employee.FirstName;
                            profile.LastName = employee.LastName;
                            profile.Email = empContact?.Email ?? "n/a";
                            profile.PhoneNumber = empContact?.PhoneNumber ?? "n/a";
                            profile.JobTitle= employee.JobTitle;
                            profile.Address = empContact?.Address ?? "n/a";
                            profile.City = empContact?.City ?? "n/a";
                            profile.State = empContact?.State?? "n/a";
                            profile.ZipCode = empContact?.ZipCode ?? "n/a";
                            profile.EmployeeId = empId;
                            profile.Department = employee.Department;
                            profile.Salary = employee.Salary.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                            profile.HireDate = employee.HireDate.ToShortDateString();
                            profile.TerminationDate = string.IsNullOrEmpty(employee.TerminationDate.ToString()) ? "n/a" : employee.TerminationDate.ToString();
                        }

                    }
                }

                dialog.panel.Controls.Add(profile);

                dialog.ShowDialog();
            }
        }
    }
}
