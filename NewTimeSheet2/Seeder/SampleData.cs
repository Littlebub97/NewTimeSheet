using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NewTimeSheet2.Data;
using NewTimeSheet2.Models;

namespace NewTimeSheet2.Seeder
{
    public class SampleData
    {
        
        public static IEnumerable<IdentityRole> GetRoles()
            => new List<IdentityRole>()
        {
                new IdentityRole()
                {
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new IdentityRole()
                {
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new IdentityRole()
                {
                    Name = "Hr",
                    NormalizedName = "HR",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
        };


        public static IEnumerable<Employee> GetUsers()
            => SetPasswords(new List<Employee>()
            {
                new Employee()
                {
                    UserName = "mario@smashbros.nintendo",
                    Email = "mario@smashbros.nintendo",
                    NormalizedEmail = "MARIO@SMASHBROS.NINTENDO",
                    NormalizedUserName = "MARIO@SMASHBROS.NINTENDO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    LockoutEnabled = true,
                },
                new Employee()
                {
                    UserName = "Samus@smashbros.nintendo",
                    Email = "Samus@smashbros.nintendo",
                    NormalizedEmail = "SAMUS@SMASHBROS.NINTENDO",
                    NormalizedUserName = "SAMUS@SMASHBROS.NINTENDO",
                    SecurityStamp = Guid.NewGuid().ToString()
                },
                new Employee()
                {
                    UserName = "Link@smashbros.nintendo",
                    Email = "Link@smashbros.nintendo",
                    NormalizedEmail = "LINK@SMASHBROS.NINTENDO",
                    NormalizedUserName = "LINK@SMASHBROS.NINTENDO",
                    SecurityStamp = Guid.NewGuid().ToString(),
                },
            });

        public static IEnumerable<IdentityUserRole<string>> GetUserRole(List<IdentityRole> roles, List<Employee> employees)
            => new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>()
                {
                    RoleId = roles.Find(x => x.Name == "Charlie").Id,
                    UserId = employees.Find(x => x.UserName == "ocelot@Develop.com").Id
                },
                new IdentityUserRole<string>()
                {
                    RoleId = roles.Find(x => x.Name == "Beta").Id,
                    UserId = employees.Find(x => x.UserName == "liquid@Develop.com").Id
                },
                new IdentityUserRole<string>()
                {
                    RoleId = roles.Find(x => x.Name == "Alpha").Id,
                    UserId = employees.Find(x => x.UserName == "snake@Develop.com").Id
                },
            };

        private static IEnumerable<Employee> SetPasswords(List<Employee> employees)
        {
            PasswordHasher<Employee> passwordHasher = new PasswordHasher<Employee>();

            foreach (var employee in employees)
            {
                employee.PasswordHash = passwordHasher.HashPassword(employee, "Nintendo1!");
            }

            return employees;
        }
    }
    
    }

