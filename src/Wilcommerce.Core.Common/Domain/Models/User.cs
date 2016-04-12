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
        public Guid Id { get; set; }

        #region Constructor
        protected User() { }
        #endregion

        #region Properties
        /// <summary>
        /// Get or set the user full name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or set the user email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Get or set the user username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Get or set the user password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Get or set the user role
        /// </summary>
        public Roles Role { get; set; }

        /// <summary>
        /// Get or set the user profile image
        /// </summary>
        public Image ProfileImage { get; set; }

        /// <summary>
        /// Get or set whether the user is active
        /// </summary>
        public bool IsActive { get; set; }

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
            this.IsActive = true;
            if(this.DisabledOn != null)
            {
                this.DisabledOn = null;
            }
        }

        /// <summary>
        /// Disable the user
        /// </summary>
        public virtual void Disable()
        {
            this.IsActive = false;
            this.DisabledOn = DateTime.Now;
        }

        #endregion

        #region Factory Methods
        /// <summary>
        /// Creates a new administrator user
        /// </summary>
        /// <param name="name">The user full name</param>
        /// <param name="username">The user username</param>
        /// <param name="password">The user password</param>
        /// <returns>The created administrator user</returns>
        public static User CreateAsAdministrator(string name, string username, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = name,
                Username = username,
                Password = password,
                Role = Roles.ADMINISTRATOR
            };

            return user;
        }

        /// <summary>
        /// Creates a new customer user
        /// </summary>
        /// <param name="name">The user full name</param>
        /// <param name="username">The user username</param>
        /// <param name="password">The user password</param>
        /// <returns>The created customer user</returns>
        public static User CreateAsCustomer(string name, string username, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = name,
                Username = username,
                Password = password,
                Role = Roles.CUSTOMER
            };

            return user;
        }

        #endregion

        #region Roles
        /// <summary>
        /// Represents the available roles. Administrator and Customer
        /// </summary>
        public enum Roles
        {
            CUSTOMER,
            ADMINISTRATOR
        }
        #endregion
    }
}
