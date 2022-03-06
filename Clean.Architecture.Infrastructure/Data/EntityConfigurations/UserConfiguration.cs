using Clean.Architecture.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Architecture.Core.Data.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.userId);
            // reference 1 - 1
            builder.HasOne(x => x.userDetail)
            .WithOne(x => x.user)
            .HasForeignKey<UserDetail>(x => x.userDetailId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
