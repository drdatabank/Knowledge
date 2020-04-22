using Knowledge.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knowledge.Data.Entities.English;

namespace Knowledge.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<EnglishDictionary> EnglishDictionary { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EnglishDictionary>()
        //        .HasOne(b => b.EnglishDictionaryDetails)
        //        .WithOne(i => i.EnglishDictionary)
        //        .HasForeignKey<EnglishDictionaryDetails>(b => b.EnglishDictionaryId);

        //    //modelBuilder.Entity<EnglishDictionaryDetails>()
        //    //    .HasNoKey()
        //    //    .Ignore(p => p.Id);
        //}
    }
}
