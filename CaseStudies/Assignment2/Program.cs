
using System;
using System.Text.RegularExpressions;namespace Project02
{
    class Program
    {
        static Boolean validatePassword(string password)
        {
            Regex re = new Regex("^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[@#%$^&+=])(?=\\S+$).{8,}$");
            //"^[A-Za-z0-9]$"
            bool values = re.IsMatch(password);
            return values;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the password to be validated:");
            string password = Console.ReadLine();
            if (validatePassword(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }
        }
    }
}

