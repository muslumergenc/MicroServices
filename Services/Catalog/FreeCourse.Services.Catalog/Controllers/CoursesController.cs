using FreeCoures.Shared.ControllerBases;
using FreeCourse.Services.Catalog.Dtos.CourseDto;
using FreeCourse.Services.Catalog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : CustomBaseController
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var response = await _courseService.GetAllAsync();
            return CreateActionResultInstance(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id) 
        {
            var response = await _courseService.GetByIdAsync(id);
            return CreateActionResultInstance(response);
        }

        [Route("/api/{controller}/GetAllByUserId/{userId}")]
        [HttpGet]
        public async Task<IActionResult> GetAllByUserId(string userId)
        {
            var response = await _courseService.GetAllByUserIdAsync(userId);
            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseCreateDto course)
        {
            var response = await _courseService.CreateAsync(course);
            return CreateActionResultInstance(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CourseUpdateDto course)
        {
            var response = await _courseService.UpdateAsync(course);
            return CreateActionResultInstance(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _courseService.DeleteAsync(id);
            return CreateActionResultInstance(response);
        }

    }
}