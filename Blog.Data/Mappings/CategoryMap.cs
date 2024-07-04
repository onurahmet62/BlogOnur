using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
            {
                Id = Guid.Parse("B925C471-3601-46D5-84F5-350A27DC52E3"),
                Name = "ASP.NET Core",
                CreatedBy = "Admin Test",
                CreatedDate= DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("E5F29EDD-E8E1-4E47-A66D-EC9304D1A78B"),
                Name = "Visual Studio 2022",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }
            );
        }
    }
}
