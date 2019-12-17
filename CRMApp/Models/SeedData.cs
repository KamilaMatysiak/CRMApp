using System;
using Microsoft.EntityFrameworkCore;
using CRMApp.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CRMApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CRMAppContext(serviceProvider.GetRequiredService<DbContextOptions<CRMAppContext>>()))
            {
                if (context.User.Any())
                {
                    return;
                }


                context.User.AddRange(
                    new User
                    {
                        Name = "Jan",
                        Surname = "Kowalski",
                        DateOfBirth = DateTime.Parse("1982-2-12"),
                        Login = "jank123",
                        IdDeleted = false
                    },

                     new User
                     {
                         Name = "Adam",
                         Surname = "Nowak",
                         DateOfBirth = DateTime.Parse("1992-4-5"),
                         Login = "nowaq1",
                         IdDeleted = false
                     },

                      new User
                      {
                          Name = "Hubert",
                          Surname = "Stozek",
                          DateOfBirth = DateTime.Parse("1982-10-22"),
                          Login = "TakiDuzy",
                          IdDeleted = false
                      },

                       new User
                       {
                           Name = "Kacper",
                           Surname = "Kaczmarek",
                           DateOfBirth = DateTime.Parse("2000-12-1"),
                           Login = "kackacz",
                           IdDeleted = false
                       });

                context.SaveChanges();
            }
        }
    }
}
