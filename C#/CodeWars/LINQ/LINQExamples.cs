using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LINQ
{
    internal class LinqExamples
    {
        public class User
        {
            public string Name { get; set; }
            public string Role { get; set; }
            public int Age { get; set; }
        }

        public static void FilterAndSortUsers()
        {
            var users = new List<User>
        {
            new User { Name = "Alice", Role = "Admin", Age = 30 },
            new User { Name = "Bob", Role = "Customer", Age = 25 },
            new User { Name = "Charlie", Role = "Customer", Age = 35 },
            new User { Name = "Dana", Role = "Admin", Age = 28 }
        };

            // Filter: Get only Admins
            var admins = users.Where(u => u.Role == "Admin");

            // Sort: Order by Age
            var sortedAdmins = admins.OrderBy(u => u.Age);

            Console.WriteLine("Admins (Sorted by Age):");
            foreach (var admin in sortedAdmins)
            {
                Console.WriteLine($"{admin.Name}, Age: {admin.Age}");
            }
        }

        public static void GroupUsersByRole()
        {
            var users = new List<User>
        {
            new User { Name = "Alice", Role = "Admin", Age = 30 },
            new User { Name = "Bob", Role = "Customer", Age = 25 },
            new User { Name = "Charlie", Role = "Customer", Age = 35 },
            new User { Name = "Dana", Role = "Admin", Age = 28 }
        };

            // Group by Role
            var groupedUsers = users.GroupBy(u => u.Role);

            Console.WriteLine("Users Grouped by Role:");
            foreach (var group in groupedUsers)
            {
                Console.WriteLine($"Role: {group.Key}");
                foreach (var user in group)
                {
                    Console.WriteLine($"  {user.Name}, Age: {user.Age}");
                }
            }
        }

        public static void SelectUserNames()
        {
            var users = new List<User>
        {
            new User { Name = "Alice", Role = "Admin", Age = 30 },
            new User { Name = "Bob", Role = "Customer", Age = 25 },
            new User { Name = "Charlie", Role = "Customer", Age = 35 },
            new User { Name = "Dana", Role = "Admin", Age = 28 }
        };

            // Select: Project only the names of the users
            var userNames = users.Select(u => u.Name);

            Console.WriteLine("User Names:");
            foreach (var name in userNames)
            {
                Console.WriteLine(name);
            }
        }

        public static void CountCustomers()
        {
            var users = new List<User>
        {
            new User { Name = "Alice", Role = "Admin", Age = 30 },
            new User { Name = "Bob", Role = "Customer", Age = 25 },
            new User { Name = "Charlie", Role = "Customer", Age = 35 },
            new User { Name = "Dana", Role = "Admin", Age = 28 }
        };

            // Count: Count users with the role "Customer"
            int customerCount = users.Count(u => u.Role == "Customer");

            Console.WriteLine($"Number of Customers: {customerCount}");
        }
    }
}
