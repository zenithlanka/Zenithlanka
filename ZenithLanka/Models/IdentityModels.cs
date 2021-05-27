﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace ZenithLanka.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string PhoneNumber { get; set; }
        public override string Email { get; set; }
        public string HomeTown { get; set; }
        public System.DateTime? BirthDate { get; set; }

       

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            ////one to many
            //modelBuilder.Entity<Project>()
            //    .HasOptional(i => i.Company)
            //    .WithMany(pc => pc.Project)
            //    .HasForeignKey(i => i.CompanyId);

            ////one to many
            //modelBuilder.Entity<Project>()
            //   .HasOptional(i => i.ProjectType)
            //   .WithMany(pc => pc.Project)
            //   .HasForeignKey(i => i.ProjectTypeId);

          


        }


    }
}