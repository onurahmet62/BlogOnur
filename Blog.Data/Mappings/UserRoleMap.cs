using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            { 
                UserId = Guid.Parse("060FE724-B2C7-485F-8B02-45D5D1D7614E"),
                RoleId = Guid.Parse("3B9DE5B7-9C7B-47BE-83F7-A3BC6C9261FB")

            }, new AppUserRole
            {
                UserId = Guid.Parse("77DB4B55-26AF-4B76-AFFE-FED6C4B22164"),
                RoleId = Guid.Parse("C24CFEB2-4715-4185-883D-01A4995C139B")
            }
            
            
            );
        }
    }
}
