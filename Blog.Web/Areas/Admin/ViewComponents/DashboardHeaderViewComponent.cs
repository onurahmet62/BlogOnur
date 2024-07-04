using AutoMapper;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using static Blog.Web.ResultMessages.Messages;

namespace Blog.Web.Areas.Admin.ViewComponents
{
    public class DashboardHeaderViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;

        public DashboardHeaderViewComponent(UserManager<AppUser> userManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loggedInUser = await userManager.GetUserAsync(HttpContext.User);

            if (loggedInUser == null)
            {
                // Handle the case where the user is not logged in
                return View("Default", new UserProfileDto());
            }

            var userProfileDto = mapper.Map<UserProfileDto>(loggedInUser);

            // Assign the mapped image to the user profile DTO
            // Assuming Image property is correctly mapped and available in UserProfileDto
            // You may need to adjust this part based on your actual Image handling
            userProfileDto.Image = loggedInUser.Image; // Assuming loggedInUser has Image property

            var role = string.Join("", await userManager.GetRolesAsync(loggedInUser));
            userProfileDto.Role = role;

            return View(userProfileDto);
        }
    }
}