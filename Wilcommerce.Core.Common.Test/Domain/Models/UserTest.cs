using Xunit;
using Wilcommerce.Core.Common.Domain.Models;
using System;
using Microsoft.AspNetCore.Identity;
using Moq;

namespace Wilcommerce.Core.Common.Test.Domain.Models
{
    public class UserTest
    {
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserTest()
        {
            _passwordHasher = new Mock<IPasswordHasher<User>>().Object;
        }

        #region Administrator Tests

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AdministratorFactory_Should_Throw_ArgumentNull_Exception_If_Name_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsAdministrator(
                value,
                "admin@email.com",
                "admin",
                _passwordHasher));

            Assert.Equal("name", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AdministratorFactory_Should_Throw_ArgumentNull_Exception_If_Email_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsAdministrator(
                "Administrator",
                value,
                "admin",
                _passwordHasher));

            Assert.Equal("email", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AdministratorFactory_Should_Throw_ArgumentNull_Exception_If_Password_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsAdministrator(
                "Administrator",
                "admin@email.com",
                value,
                _passwordHasher));

            Assert.Equal("password", ex.ParamName);
        }

        [Fact]
        public void AdministratorFactory_Should_Create_Administrator()
        {
            var user = User.CreateAsAdministrator(
                "Administrator",
                "admin@email.com",
                "admin",
                _passwordHasher);

            Assert.Equal(User.Roles.ADMINISTRATOR, user.Role);
        }

        #endregion

        #region Customer Tests

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void CustomerFactory_Should_Throw_ArgumentNull_Exception_If_Name_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsCustomer(
                value,
                "customer@email.com",
                "customer",
                _passwordHasher));

            Assert.Equal("name", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void CustomerFactory_Should_Throw_ArgumentNull_Exception_If_Email_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsCustomer(
                "Customer",
                value,
                "customer",
                _passwordHasher));

            Assert.Equal("email", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void CustomerFactory_Should_Throw_ArgumentNull_Exception_If_Password_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsCustomer(
                "Customer",
                "customer@email.com",
                value,
                _passwordHasher));

            Assert.Equal("password", ex.ParamName);
        }

        [Fact]
        public void CustomerFactory_Should_Create_Customer()
        {
            var user = User.CreateAsCustomer(
                "Customer",
                "customer@email.com",
                "customer",
                _passwordHasher);

            Assert.Equal(User.Roles.CUSTOMER, user.Role);
        }

        #endregion

        [Fact]
        public void Enable_Should_Active_User_And_Set_Date_To_Null()
        {
            var user = User.CreateAsAdministrator(
                "Admin",
                "admin@email.com",
                "admin",
                _passwordHasher);

            user.Enable();

            Assert.True(user.IsActive);
            Assert.Null(user.DisabledOn);
        }

        [Fact]
        public void Disable_Should_Set_Date_To_Now()
        {
            var user = User.CreateAsAdministrator(
                "Admin",
                "admin@email.com",
                "admin",
                _passwordHasher);

            user.Disable();

            Assert.False(user.IsActive);
            Assert.Equal(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), ((DateTime)user.DisabledOn).ToString("yyyy-MM-dd HH:mm"));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ChangeName_Should_Throw_ArgumentNullException_If_Name_IsEmpty(string value)
        {
            var user = User.CreateAsAdministrator(
                "Admin",
                "admin@email.com",
                "admin",
                _passwordHasher);

            var ex = Assert.Throws<ArgumentNullException>(() => user.ChangeName(value));
            Assert.Equal("name", ex.ParamName);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ChangeEmail_Should_Throw_ArgumentNullException_If_Email_IsEmpty(string value)
        {
            var user = User.CreateAsAdministrator(
                "Admin",
                "admin@email.com",
                "admin",
                _passwordHasher);

            var ex = Assert.Throws<ArgumentNullException>(() => user.ChangeEmail(value));
            Assert.Equal("email", ex.ParamName);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ChangePassword_Should_Throw_ArgumentNullException_If_Password_IsEmpty(string value)
        {
            var user = User.CreateAsAdministrator(
                "Admin",
                "admin@email.com",
                "admin",
                _passwordHasher);

            var ex = Assert.Throws<ArgumentNullException>(() => user.ChangePassword(value));
            Assert.Equal("password", ex.ParamName);
        }

        [Fact]
        public void SetProfileImage_Should_Throw_ArgumentNullException_If_Image_IsNull()
        {
            var user = User.CreateAsAdministrator(
                "Admin",
                "admin@email.com",
                "admin",
                _passwordHasher);

            var ex = Assert.Throws<ArgumentNullException>(() => user.SetProfileImage(null));
            Assert.Equal("profile image", ex.ParamName);
        }
    }
}
