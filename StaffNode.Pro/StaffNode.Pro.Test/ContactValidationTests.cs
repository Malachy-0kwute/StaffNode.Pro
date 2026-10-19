using MongoDB.Bson;
using StaffNode.Pro.Domain;
using StaffNode.Pro.Persistence.Validation;

namespace StaffNode.Pro.Test
{
    [TestFixture]
    public class ContactValidationTests
    {
        [Test]
        public void ValidateContactData_ReturnsTrue_WhenContactDataAreValid()
        {
            // Arrange
            var mockValidator = new Validator();

            var contact = new ContactDataModel
            {
                Id = ObjectId.GenerateNewId(),
                Email = "john.doe@example.com",
                PhoneNumber = "1234567890",
                Address = "123 Main St",
                ZipCode = "12345",
                City = "Anytown",
                State = "CA"
            };

            // Act
            var testResult = mockValidator.Validate(contact);

            // Assert
            Assert.That(testResult.IsValid, Is.True);
        }

        [Test]
        public void ValidateContactData_ReturnsFalse_WhenContactDataAreInvalid()
        {
            // Arrange
            var mockValidator = new Validator();

            var contact = new ContactDataModel
            {
                Id = ObjectId.GenerateNewId(),
                Email = "",
                PhoneNumber = "1234567890",
                Address = "123 Main St",
                ZipCode = "12345",
                City = "Anytown",
                State = "CA"
            };


            // Act
            var testResult = mockValidator.Validate(contact);

            // Assert
            Assert.That(testResult.IsValid, Is.False);
        }

        [Test]
        public void ValidateContactData_ReturnsListOfValidationErrors_WhenContactDataAreInvalid()
        {
            // Arrange
            var mockValidator = new Validator();

            var contact = new ContactDataModel
            {
                Id = ObjectId.GenerateNewId(),
                Email = "", // Invalid email address
                PhoneNumber = "1234567890",
                Address = "123 Main St",
                ZipCode = "12345",
                City = "Anytown",
                State = "CA"
            };

            // Act
            var testResult = mockValidator.Validate(contact);

            // Assert
            Assert.That(testResult.Errors.Count, Is.EqualTo(3));
        }
    }
}
