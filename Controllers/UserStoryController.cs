using Assignment_6_WebApi.Models;
using Assignment_6_WebApi.Repo;
using Assignment_6_WebApi.UserStoryBAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Assignment_6_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserStoryController : ControllerBase
    {
        // private readonly dbContext db;

        private IUserStoryContext db = new dbContext();

        public UserStoryController() { }
        public UserStoryController(IUserStoryContext _db)
        {
            //bl = _bl;
            db = _db;
        }

        //public ActionResult<List<UserStory>> GetUserStory()

        [HttpGet]
        [Route("GetUserStory")]
        public IActionResult GetUserStory()
        {
            //return Ok(bl.GetUStory());
            return Ok(db.UserStories.ToList());

        }

        //public IActionResult<UserStory> GetById(int id)

        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            UserStory p = db.UserStories.Find(id);
            return Ok(p);
        }

        [HttpPost]
        [Route("AddUserStory")]
        public IActionResult AddNewUserStory([FromBody] UserStory p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.UserStories.Add(p);
            db.SaveChanges();
            return Ok(p);
        }


        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult DeleteUserStory(int id)
        {
            UserStory p = db.UserStories.Find(id);
            db.UserStories.Remove(p);
            db.SaveChanges();
            return Ok(p);
        }

        [HttpPut]
        [Route("update/{id}")]
        public IActionResult UpdateUserStory(int id, [FromBody] UserStory p)
        {
            var item = db.UserStories.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            UserStory u = db.UserStories.Find(id);
            u.UserStoryName = p.UserStoryName;
            u.StoryOwner = p.StoryOwner;
            u.StoryPoints = p.StoryPoints;
            u.StoryDescription = p.StoryDescription;

            //db.UserStories.Update(p);
            db.SaveChanges();
            return Ok();
        }
      
    }
}
