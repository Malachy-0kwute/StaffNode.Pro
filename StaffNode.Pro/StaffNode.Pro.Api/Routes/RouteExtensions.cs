using MongoDB.Bson;
using StaffNode.Pro.Application.Contracts.Persistence;
using StaffNode.Pro.Domain;

namespace StaffNode.Pro.Api.Routes
{
    public static class RouteExtensions
    {
        private readonly static string _basePath = "/api/v1";

        /// <summary>
        /// Contacts api routes
        /// </summary>
        public static void MapContactRoutes(this IEndpointRouteBuilder app)
        {
            // Get all contacts
            app.MapGet(_basePath + "/contacts", async (IContactRepository contactRepo) => await contactRepo.GetAllAsync());

            // Get contact by ID
            app.MapGet(_basePath + "/contact/{id}", async (IContactRepository contactRepo, string id) => await contactRepo.GetByIdAsync(id));

            // Create new contact
            app.MapPost(_basePath + "/contact", async (IContactRepository contactRepo, ContactDataModel contact) => await contactRepo.CreateAsync(contact));

            // Update contact information
            app.MapPut(_basePath + "/contact", async (IContactRepository contactRepo, ContactDataModel contact) => await contactRepo.UpdateAsync(contact));

            // Delete contact using ID
            app.MapDelete(_basePath + "/contact/{id}", async (IContactRepository contactRepo, string id) => await contactRepo.DeleteAsync(id));
        }

        /// <summary>
        /// Employee api routes
        /// </summary>
        public static void MapEmployeeRoutes(this IEndpointRouteBuilder app)
        {
            // Get all employees
            app.MapGet(_basePath + "/employees", async (IEmployeeRepository employeeRepo) => await employeeRepo.GetAllAsync());

            // Get employee by ID
            app.MapGet(_basePath + "/employee/{id}", async (IEmployeeRepository employeeRepo, string id) => await employeeRepo.GetByIdAsync(id));

            // Create new employee
            app.MapPost(_basePath + "/employee", async (IEmployeeRepository employeeRepo, EmployeeDataModel employee) =>
            {
                await employeeRepo.CreateAsync(employee);
            });

            // Update employee information
            app.MapPut(_basePath + "/employee", async (IEmployeeRepository employeeRepo, EmployeeDataModel employee) => await employeeRepo.UpdateAsync(employee));

            // Delete employee using ID
            app.MapDelete(_basePath + "/employee/{id}", async (IEmployeeRepository employeeRepo, string id) => await employeeRepo.DeleteAsync(id));
        }

        /// <summary>
        /// Profile api routes
        /// </summary>
        public static void MapProfileRoutes(this IEndpointRouteBuilder app)
        {
            // Get all profiles
            app.MapGet(_basePath + "/profiles", async (IProfileRepository profileRepo) => await profileRepo.GetAllAsync());

            // Get profile by ID
            app.MapGet(_basePath + "/profile/{id}", async (IProfileRepository profileRepo, string id) => await profileRepo.GetByIdAsync(id));

            // Create new profile
            app.MapPost(_basePath + "/profile", async (IProfileRepository profileRepo, ProfileDataModel profile) => await profileRepo.CreateAsync(profile));

            // Update profile information
            app.MapPut(_basePath + "/profile", async (IProfileRepository profileRepo, ProfileDataModel profile) => await profileRepo.UpdateAsync(profile));

            // Delete profile using ID
            app.MapDelete(_basePath + "/profile/{id}", async (IProfileRepository profileRepo, string id) => await profileRepo.DeleteAsync(id));
        }
    }
}
