﻿using Xunit;
using Wilcommerce.Core.Common.Domain.Models;
using System;

namespace Wilcommerce.Core.Common.Test.Domain.Models
{
    public class UserTest
    {
        #region Administrator Tests

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AdministratorFactory_Should_Throw_ArgumentNull_Exception_If_Name_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsAdministrator(
                value,
                "admin",
                "admin"
                ));

            Assert.Equal("name", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AdministratorFactory_Should_Throw_ArgumentNull_Exception_If_Username_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsAdministrator(
                "Administrator",
                value,
                "admin"
                ));

            Assert.Equal("username", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AdministratorFactory_Should_Throw_ArgumentNull_Exception_If_Password_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsAdministrator(
                "Administrator",
                "admin",
                value
                ));

            Assert.Equal("password", ex.ParamName);
        }

        [Fact]
        public void AdministratorFactory_Should_Create_Administrator()
        {
            var user = User.CreateAsAdministrator(
                "Administrator",
                "admin",
                "admin"
                );

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
                "customer",
                "customer"
                ));

            Assert.Equal("name", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void CustomerFactory_Should_Throw_ArgumentNull_Exception_If_Username_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsCustomer(
                "Customer",
                value,
                "customer"
                ));

            Assert.Equal("username", ex.ParamName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void CustomerFactory_Should_Throw_ArgumentNull_Exception_If_Password_IsEmpty(string value)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => User.CreateAsCustomer(
                "Customer",
                "customer",
                value
                ));

            Assert.Equal("password", ex.ParamName);
        }

        [Fact]
        public void CustomerFactory_Should_Create_Customer()
        {
            var user = User.CreateAsCustomer(
                "Customer",
                "customer",
                "customer"
                );

            Assert.Equal(User.Roles.CUSTOMER, user.Role);
        }

        #endregion

        [Fact]
        public void Enable_Should_Active_User_And_Set_Date_To_Null()
        {
            var user = User.CreateAsAdministrator(
                "Admin",
                "admin",
                "admin"
                );

            user.Enable();

            Assert.Equal(true, user.IsActive);
            Assert.Equal(null, user.DisabledOn);
        }

        [Fact]
        public void Disable_Should_Set_Date_To_Now()
        {
            var user = User.CreateAsAdministrator(
                "Admin",
                "admin",
                "admin"
                );

            user.Disable();

            Assert.Equal(false, user.IsActive);
            Assert.Equal(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), ((DateTime)user.DisabledOn).ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
