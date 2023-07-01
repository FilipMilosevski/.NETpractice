using LoginProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginProject
{
    public static class LoginOrCreate
    {
        private static string _username;
        private static string _password;
        private static string _confirmPassword;
        public static bool _isCorrect;
        public static int _role;


        /// <summary>
        /// Login the user method
        /// </summary>
        public static void Login()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("------- LOGIN USER --------");
            Console.WriteLine("------------------------");
            _isCorrect = false; 
            do
            {

                //login
                Console.WriteLine("Enter Username");
                string _username = Console.ReadLine();


                Console.WriteLine("Enter Password");
                string _password = Console.ReadLine();

                if (isUsernameAllowed(_username) && isPasswordAllowed(_password))
                {
                    User loggedInUser;
                    using (LoginContext context = new LoginContext())
                    {
                        loggedInUser = context.users.Where(u => u.Username == _username && u.Password == _password).Include(u => u.Role).FirstOrDefault();
                    }
                    if(loggedInUser != null)
                    {
                        Console.WriteLine($"Welcome {loggedInUser.Username}   you are {loggedInUser.Role.RoleName}!");
                    }
                    else
                    {
                        Create();
                    }
                    _isCorrect = true;
                }
                else
                {
                    if (!isUsernameAllowed(_username))
                    {
                        Console.WriteLine("Username is incorrect");
                    }
                    if (!isPasswordAllowed(_password))
                    {
                        Console.WriteLine("Password is incorrect");
                    }
                }

            } while (!_isCorrect);


        }
        
        /// <summary>
        /// Creates user method
        /// </summary>
        public static void Create()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("------- CREATE USER --------");
            Console.WriteLine("------------------------");

            _isCorrect = false;

            do
            {

                //login
                Console.WriteLine("Enter Username");
                string _username = Console.ReadLine();


                Console.WriteLine("Enter Password");
                string _password = Console.ReadLine();

                Console.WriteLine("Confirm Password");
                string _confirmPassword = Console.ReadLine();

                Console.WriteLine("Select Role (Guest = 2 , VIP = 3 , Regular = 4)");
                 _role = Convert.ToInt32(Console.ReadLine());

                if (isUsernameAllowed(_username) && isPasswordAllowed(_password)&& _password == _confirmPassword)
                {
                    User createUser;
                    using (LoginContext context = new LoginContext())
                    {
                        createUser = context.users.FirstOrDefault(cu => cu.Username == _username);

                        if (createUser == null)
                        {
                          Role role =   context.roles.FirstOrDefault(r => r.RoleName == (RoleName)_role);
                           if(role  == null)
                            {
                                role = context.roles.FirstOrDefault(r => r.RoleName == (RoleName)2);
                            }
                            context.users.Add(new User() { Username = _username, Password = _password, Role = role });
                            int changes = context.SaveChanges();
                            if(changes > 0)
                            {
                                Login();
                            }
                            Console.WriteLine("Welcome you are new member");
                        }

                    }
                    _isCorrect = true;
                }
                else
                {
                    if (!isUsernameAllowed(_username))
                    {
                        Console.WriteLine("Username is incorrect");
                    }
                    if (!isPasswordAllowed(_password))
                    {
                        Console.WriteLine("Password is incorrect");
                    }
                    if (_password != _confirmPassword)
                    {
                        Console.WriteLine("Passwords are not the same");
                    }
                }

            } while (!_isCorrect);
        }
        #region Helers
        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private static bool isPasswordAllowed(string? password)
        {
            Regex regx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");

            if (regx.IsMatch(password) && !String.IsNullOrEmpty(password))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private static bool isUsernameAllowed(string? username)
        {
            Regex regx = new Regex(@"^(?=[A-Za-z0-9])(?!.*[._()\[\]-]{2})[A-Za-z0-9._()\[\]-]{3,15}$");

            if (regx.IsMatch(username) && !String.IsNullOrEmpty(username))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
