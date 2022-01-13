using System;
using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
  public class DataContext : IdentityDbContext<AppUser>
  {
    public DbSet<Channel> Channels { get; set; }
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

      base.OnModelCreating(builder);

      builder.Entity<Channel>().HasData(
        new Channel { Id = Guid.NewGuid(), Name = "Channel 1", Description = "Description 1" },
        new Channel { Id = Guid.NewGuid(), Name = "Channel 2", Description = "Description 2" },
        new Channel { Id = Guid.NewGuid(), Name = "Channel 3", Description = "Description 3" },
        new Channel { Id = Guid.NewGuid(), Name = "Channel 4", Description = "Description 4" },
        new Channel { Id = Guid.NewGuid(), Name = "Channel 5", Description = "Description 5" }
      );

      base.OnModelCreating(builder);
    }

  }
}
