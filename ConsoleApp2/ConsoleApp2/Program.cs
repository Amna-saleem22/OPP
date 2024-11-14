using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class UserProfile
    {
        private string username;  // Private attribute
        private string password;  // Private attribute
        private string email;     // Private attribute

        // Constructor
        public UserProfile(string username, string password, string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;
        }

        // Method to get the username
        public string GetUsername()
        {
            return username;
        }

        // Method to set a new password with validation
        public void SetPassword(string oldPassword, string newPassword)
        {
            if (oldPassword == password)
            {
                if (ValidatePassword(newPassword))
                {
                    password = newPassword;
                    Console.WriteLine("Password updated successfully.");
                }
                else
                {
                    Console.WriteLine("New password does not meet requirements.");
                }
            }
            else
            {
                Console.WriteLine("Old password is incorrect.");
            }
        }

        // Method to get the email
        public string GetEmail()
        {
            return email;
        }

        // Method to update the email
        public void UpdateEmail(string newEmail)
        {
            if (ValidateEmail(newEmail))
            {
                email = newEmail;
                Console.WriteLine("Email updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid email format.");
            }
        }

        // Simple password validation method
        private bool ValidatePassword(string password)
        {
            return password.Length >= 8; // Example: password must be at least 8 characters
        }

        // Simple email validation method
        private bool ValidateEmail(string email)
        {
            // Basic email validation using regex
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            UserProfile user = new UserProfile("amna", "123", "amna@example.com");

            // Accessing the username
            Console.WriteLine("Username: " + user.GetUsername());

            // Updating the password
            user.SetPassword("123", "newPassword456");

            // Accessing the email
            Console.WriteLine("Email: " + user.GetEmail());

            // Updating the email
            user.UpdateEmail("amna@example.com");

            // Trying to update with an invalid email
            user.UpdateEmail("invalid-email-format");

            Console.ReadKey();
        }
    }
}
