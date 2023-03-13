using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Discussion.Api.Models.RequestModel;
using Discussion.Api.Models.ViewModels;
using Discussion.Data.Entities;
using Discussion.Service.Interfaces;

namespace Discussion.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService UserService { get; }
        private IMapper Mapper { get; }

        public UserController
        (
                IUserService userService,
                IMapper mapper
        )
        {
            UserService = userService;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {

            var users = await UserService.GetAllAsync();
            var usersDto = Mapper.Map<List<UserDto>>(users);

            return Ok(usersDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {

            var user = await UserService.GetByIdAsync(id);

            if (user == null)
                return NotFound();

            var userDto = Mapper.Map<UserDto>(user);

            return Ok(userDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(UserRequestModel request)
        {
            //var userId = User.FindFirstValue(ClaimTypes.Sid);
            //uncomment when ready to use
            var userId = "C7BF03EB-2696-4C5E-A2B0-228854FC81C8";

            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                CreatedById = Guid.Parse(userId),
                CreatedDate = DateTime.UtcNow

            };

            await UserService.CreateAsync(user);

            return Ok(user.Id);

        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(UserRequestModel request)
        {
            //var userId = User.FindFirstValue(ClaimTypes.Sid);
            //uncomment when ready to use
            var userId = "C7BF03EB-2696-4C5E-A2B0-228854FC81C8";

            var user = await UserService.GetByIdAsync(request.Id.Value);

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.ModifiedById = Guid.Parse(userId);
            user.ModifiedDate = DateTime.UtcNow;

            await UserService.UpdateAsync(user);

            return Ok(user.Id);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            //var userId = User.FindFirstValue(ClaimTypes.Sid);
            //uncomment when ready to use
            var userId = "C7BF03EB-2696-4C5E-A2B0-228854FC81C8";

            var user = await UserService.GetByIdAsync(id);
            user.ModifiedById = Guid.Parse(userId);
            user.ModifiedDate = DateTime.UtcNow;

            await UserService.DeleteAsync(user);

            return Ok();

        }
    }
}
