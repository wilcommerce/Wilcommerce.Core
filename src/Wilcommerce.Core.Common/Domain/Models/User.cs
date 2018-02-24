using Microsoft.AspNetCore.Identity;
using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Domain.Models
{
    /// <summary>
    /// Represents a user
    /// </summary>
    public class User : IAggregateRoot
    {
        /// <summary>
        /// Get or set the user id
        /// </summary>
        public Guid Id { get; protected set; }

        #region Constructor
        /// <summary>
        /// Construct the user
        /// </summary>
        protected User() { }
        #endregion

        #region Properties
        /// <summary>
        /// Get or set the user full name
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Get or set the user email
        /// </summary>
        public string Email { get; protected set; }

        /// <summary>
        /// Get or set the username
        /// </summary>
        public string Username { get; protected set; }

        /// <summary>
        /// Get or set the user password
        /// </summary>
        public string Password { get; protected set; }

        /// <summary>
        /// Get or set the user role
        /// </summary>
        public Roles Role { get; protected set; }

        /// <summary>
        /// Get or set the user profile image
        /// </summary>
        public Image ProfileImage { get; protected set; }

        /// <summary>
        /// Get or set whether the user is active
        /// </summary>
        public bool IsActive { get; protected set; }

        /// <summary>
        /// Get or set the date and time of when the user was disabled
        /// </summary>
        public DateTime? DisabledOn { get; set; }

        #endregion

        #region Behaviors
        /// <summary>
        /// Enable the user
        /// </summary>
        public virtual void Enable()
        {
            IsActive = true;
            if (DisabledOn != null)
            {
                DisabledOn = null;
            }
        }

        /// <summary>
        /// Disable the user
        /// </summary>
        public virtual void Disable()
        {
            IsActive = false;
            DisabledOn = DateTime.Now;
        }

        /// <summary>
        /// Change the user's name
        /// </summary>
        /// <param name="name">The new user's name</param>
        public virtual void ChangeName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            Name = name;
        }

        /// <summary>
        /// Change the user's email
        /// </summary>
        /// <param name="email">The new user's email</param>
        public virtual void ChangeEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("email");
            }

            Email = email;
        }

        /// <summary>
        /// Change the user's password
        /// </summary>
        /// <param name="password">The new user's password</param>
        public virtual void ChangePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            Password = password;
        }

        /// <summary>
        /// Change the user's role
        /// </summary>
        /// <param name="role">The new user's role</param>
        public virtual void ChangeRole(Roles role)
        {
            Role = role;
        }

        /// <summary>
        /// Set the user's profile image
        /// </summary>
        /// <param name="profileImage">The profile image to set</param>
        public virtual void SetProfileImage(Image profileImage)
        {
            ProfileImage = profileImage ?? throw new ArgumentNullException("profile image");
        }

        #endregion

        #region Factory Methods
        /// <summary>
        /// Creates a new administrator user
        /// </summary>
        /// <param name="name">The user full name</param>
        /// <param name="email">The user username</param>
        /// <param name="password">The user password</param>
        /// <param name="passwordHasher">The password hasher instance</param>
        /// <returns>The created administrator user</returns>
        public static User CreateAsAdministrator(string name, string email, string password, IPasswordHasher<User> passwordHasher)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("email");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = name,
                Username = email,
                Email = email,
                Role = Roles.ADMINISTRATOR
            };

            user.Password = passwordHasher.HashPassword(user, password);

            return user;
        }

        /// <summary>
        /// Creates a new customer user
        /// </summary>
        /// <param name="name">The user full name</param>
        /// <param name="email">The user username</param>
        /// <param name="password">The user password</param>
        /// <param name="passwordHasher">The password hasher instance</param>
        /// <returns>The created customer user</returns>
        public static User CreateAsCustomer(string name, string email, string password, IPasswordHasher<User> passwordHasher)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("email");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = name,
                Username = email,
                Email = email,
                Role = Roles.CUSTOMER
            };

            user.Password = passwordHasher.HashPassword(user, password);

            return user;
        }

        #endregion

        #region Roles
        /// <summary>
        /// Represents the available roles. Administrator and Customer
        /// </summary>
        public enum Roles
        {
            /// <summary>
            /// The customer role
            /// </summary>
            CUSTOMER,

            /// <summary>
            /// The administrator role
            /// </summary>
            ADMINISTRATOR
        }
        #endregion
    }
}
