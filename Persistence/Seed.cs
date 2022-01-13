using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
  public class Seed
  {
    public static async Task SeedData(UserManager<AppUser> userManager)
    {
      if (!userManager.Users.Any())
      {
        var users = new List<AppUser> {
            new AppUser{
                Id = "1",
                UserName = "bob",
                Email = "soyprueba@mail.com",
            },
            new AppUser{
                Id = "2",
                UserName = "bob2",
                Email = "soyprueba2@mail.com"
            },
            new AppUser{
                Id = "3",
                UserName = "bob3",
                Email = "soyprueba3@mail.com"
            }
        };
        foreach (var user in users)
        {
          await userManager.CreateAsync(user, "Pa$$w0rd");
        }
      }
    }
  }
}