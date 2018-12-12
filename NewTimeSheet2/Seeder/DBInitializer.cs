using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using NewTimeSheet2.Data;
using NewTimeSheet2.Models;

namespace NewTimeSheet2.Seeder
{
    public class DBInitializer
    {
    
        /*
    public static void InitializeData(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetService<ApplicationDbContext>();
        InitializeData(context);
    }

    public static void InitializeData(ApplicationDbContext context)
    {
        context.Database.Migrate();
        ClearData(context);
        SeedData(context);
    }

    public static void ClearData(ApplicationDbContext context)
    {
        context.Database.ExecuteSqlCommand("DELETE FROM [NewTimeSheet2].[Employee]");
        context.Database.ExecuteSqlCommand("DELETE FROM [NewTimeSheet2].[AspNetRoles]");
    }

    private static void SeedData(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();

        if (!context.Users.Any())
        {
            context.AddRange(SampleData.GetUsers());
            context.SaveChanges();
        }
        if (!context.Roles.Any())
        {
            context.AddRange(SampleData.GetRoles());
            context.SaveChanges();
        }
      //  if (!context.UserRoles.Any())
        //{
          //  context.AddRange(SampleData.GetUserRole(context.Roles.ToList(), context.Employee.ToList()));
            //context.SaveChanges();
       // }
       */
    }
}

