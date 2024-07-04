using Blog.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {

        public CategoryValidator() 
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100)
                .MinimumLength(2)
                .WithName("Kategori Adı");
        }
    }
}
