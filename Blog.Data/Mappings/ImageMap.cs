using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
            {
                    Id =Guid.Parse("5A4757C3-632A-4DFB-B850-BE41163A5C0C"),
                    FileName = "images/testimage",
                    FileType = "jpg",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
            },
            new Image{
               Id = Guid.Parse("9AFE33E7-79C2-4575-9BB1-5E3C66009ECF"),
               FileName = "image/vstest",
               FileType = "png",
               CreatedBy = "Admin Test",
               CreatedDate = DateTime.Now,
               IsDeleted = false
            }
            );


        }

     
    }
}
