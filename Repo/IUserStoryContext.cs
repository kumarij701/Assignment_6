using Assignment_6_WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_6_WebApi.Repo
{
    public interface IUserStoryContext : IDisposable
    {
        DbSet<UserStory> UserStories { get; }
        int SaveChanges();
        //void MarkAsModified(Product item);
    }
}
