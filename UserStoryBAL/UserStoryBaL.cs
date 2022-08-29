using Assignment_6_WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_6_WebApi.UserStoryBAL
{
    public class UserStoryBaL
    {
        private readonly dbContext db;
        public UserStoryBaL(dbContext _db)
        {
            db = _db;
        }

        public List<UserStory> GetUStory()
        {
            return db.UserStories.ToList();
        }
    }
    }

