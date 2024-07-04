using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;


namespace Blog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("9AFE33E7-79C2-4575-9BB1-5E3C66009ECF");
        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
