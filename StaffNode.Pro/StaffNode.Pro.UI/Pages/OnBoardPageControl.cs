using FluentValidation.Results;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using StaffNode.Pro.UI.Helpers;
using StaffNode.Pro.UI.Models;
using StaffNode.Pro.UI.Validations;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace StaffNode.Pro.UI.Pages
{
    public partial class OnBoardPageControl : UserControl
    {
        private IServiceProvider _provider;
        private IHttpClientFactory _httpClientFactory;

        public OnBoardPageControl(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;

            phoneNumber.TextChanged += (s, e) =>
            {
                if (string.IsNullOrEmpty(phoneNumber.Text) is false && 
                    Char.IsDigit(phoneNumber.Text.Last()) is false)
                {
                    phoneNumber.Text = phoneNumber.Text.Remove(phoneNumber.Text.Length - 1);
                }

                phoneNumber.SelectionStart = phoneNumber.Text.Length;
            };
            
            _httpClientFactory = _provider.GetRequiredService<IHttpClientFactory>();
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (Parent?.Parent is MainWindow mainWindow)
            {
                mainWindow.NavigateToView(new EmployeesPageControl(_provider));
            }
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            var client = _httpClientFactory.CreateClient(HttpClientHelpers.CLIENTNAME);

            var employee = new EmployeeDataModel
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Department = department.SelectedItem?.ToString() ?? string.Empty,
                JobTitle = jobTitle.SelectedItem?.ToString() ?? string.Empty,
                Salary = double.Parse(string.IsNullOrEmpty(salary.Text) ? "0" : salary.Text)
            };

            var employeeContactInfo = new ContactDataModel
            {
                Address = address.Text,
                Email = email.Text,
                PhoneNumber = phoneNumber.Text,
                City = city.Text,
                State = state.SelectedItem?.ToString() ?? string.Empty,
                ZipCode = zip.Text,
            };

            var profileInfo = new ProfileDataModel { Bio = bio.Text };

            var employeeValidation = new EmployeeValidation();
            var employeeValidationResult = employeeValidation.Validate(employee);

            var contactInfoValidation = new ContactValidations();
            var contactInfoValidationResult = contactInfoValidation.Validate(employeeContactInfo);

            if (employeeValidationResult.IsValid && contactInfoValidationResult.IsValid)
            {
                var employeeContactInfoContent = new StringContent(JsonSerializer.Serialize(employeeContactInfo), Encoding.UTF8, MediaTypeNames.Application.Json); 
                var employeeProfileContent = new StringContent(JsonSerializer.Serialize(profileInfo), Encoding.UTF8, MediaTypeNames.Application.Json);

#pragma warning disable CS8604 // Possible null reference argument.
                
                var profileTask = client.SendAsync(new HttpRequestMessage
                {
                    Content = employeeProfileContent,
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(client.BaseAddress, HttpClientHelpers.CURRENT_API_VERSION + "/profile")
                });

                var contactTask = client.SendAsync(new HttpRequestMessage
                {
                    Content = employeeContactInfoContent,
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(client.BaseAddress, HttpClientHelpers.CURRENT_API_VERSION + "/contact")
                });

                Task.Run(async () => await Task.WhenAll(contactTask, profileTask).ContinueWith(async result =>
                {
                    employee.ContactId = employeeContactInfo.Id;
                    employee.ProfileId = profileInfo.Id;

                    if (result.IsCompletedSuccessfully)
                    {
                        var employeeContent = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, MediaTypeNames.Application.Json);

                        var employeeTask = await client.SendAsync(new HttpRequestMessage
                        {
                            Content = employeeContent,
                            Method = HttpMethod.Post,
                            RequestUri = new Uri(client.BaseAddress, HttpClientHelpers.CURRENT_API_VERSION + "/employee")
                        });

                    }

                    BeginInvoke(() =>
                    {
                        if (Parent?.Parent is MainWindow mainWindow)
                        {
                            mainWindow.NavigateToView(new EmployeesPageControl(_provider));
                        }
                    });
                }));
#pragma warning restore CS8604 // Possible null reference argument.
             }
            else
            {
                List<ValidationFailure> errors = [];
                errors.Clear();
                errors.AddRange(employeeValidationResult.Errors);
                errors.AddRange(contactInfoValidationResult.Errors);

                // Broadcast errors
                errors.ForEach(error =>
                {
                    switch(error.ErrorCode.ToLower())
                    {
                        case "firstname":
                            SetError(firstNameErrorMsg, error.ErrorMessage);
                            break;

                        case "lastname":
                            SetError(lastNameErrorMsg, error.ErrorMessage);
                            break;

                        case "email":
                            SetError(emailErrorMsg, error.ErrorMessage);
                            break;

                        case "phonenumber":
                            SetError(phoneNumberErrorMsg, error.ErrorMessage);
                            break;

                        case "address":
                            SetError(addressErrorMsg, error.ErrorMessage);
                            break;

                        case "city":
                            SetError(cityErrorMsg, error.ErrorMessage);
                            break;

                        case "state":
                            SetError(stateErrorMsg, error.ErrorMessage);
                            break;

                        case "zipcode":
                            SetError(zipCodeErrorMsg, error.ErrorMessage);
                            break;

                        case "jobtitle":
                            SetError(jobTitleErrorMsg, error.ErrorMessage);
                            break;

                        case "department":
                            SetError(departmentErrorMsg, error.ErrorMessage);
                            break;

                        case "salary":
                            SetError(salaryErrorMsg, error.ErrorMessage);
                            break;

                        default:
                            break;
                    }
                });
            }
        }

        private void SetError(Label errorLabel, string errorMessage)
        {
            errorLabel.Text = errorMessage;
            errorLabel.Visible = true;
        }
    }
}
