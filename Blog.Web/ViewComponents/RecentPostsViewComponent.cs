using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class RecentPostsViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public RecentPostsViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var recentPosts = await articleService.GetLastPosts(null);
            return View(recentPosts);
        }
    }
}
