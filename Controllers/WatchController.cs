using ReflectionExercise.Attributes;
using ReflectionExercise.Models;

namespace ReflectionExercise.Controllers;

[Route("api/[controller]/[action]")]

public class WatchController
{
        [HttpGet]
        public void PlayVideo()
        {
                
        }

        [HttpDelete]
        public void DeleteVideo([FromQuery] int id,  [FromQuery] string name)
        {
                
        }

        [HttpPost]
        public void PostVideo([FromBody] VideoDto video)
        {
                
        }
}