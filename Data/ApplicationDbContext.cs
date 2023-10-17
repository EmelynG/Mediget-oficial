﻿using Mediget_App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediget_App.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("dbo");
            builder.Entity<IdentityUser>(
                entity =>
                {
                    entity.ToTable(name: "User");
                }
            );
            builder.Entity<IdentityRole>(
               entity =>
               {
                   entity.ToTable(name: "Role");
               }
           );
            builder.Entity<IdentityUserRole<string>>(
              entity =>
              {
                  entity.ToTable(name: "UserRoles");
              }
          );

            builder.Entity<IdentityUserClaim<string>>(
             entity =>
             {
                 entity.ToTable(name: "UserClaims");
             }
         );

            builder.Entity<IdentityUserLogin<string>>(
            entity =>
            {
                entity.ToTable(name: "UserLogins");
            }
        );

             builder.Entity<IdentityRoleClaim<string>>(
                   entity =>
                     {
                entity.ToTable(name: "RoleClaims");
                     }
               );

            builder.Entity<IdentityUserToken<string>>(
                  entity =>
                  {
                      entity.ToTable(name: "UserTokens");
                  }
              );
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
