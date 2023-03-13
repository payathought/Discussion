using AutoMapper;
using Discussion.Api.Models.RequestModel;
using Discussion.Api.Models.ViewModels.Discussion;
using Discussion.Data.Entities;
using Discussion.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussion.Api.Controllers
{
    [Route("api/discussions")]
    [ApiController]
    public class DiscussionController : ControllerBase
    {
        public IUserService UserService { get; }
        public IDiscussionService DiscussionService { get; }
        public IMapper Mapper { get; }
        public DiscussionController(
            IUserService userService,
            IDiscussionService discussionService,
             IMapper mapper)
        {
            UserService = userService;
            DiscussionService = discussionService;
            Mapper = mapper;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync(DiscussionRequestModel request)
        {
            //var userId = User.FindFirstValue(ClaimTypes.Sid);
            //uncomment when ready to use
            var userId = "C7BF03EB-2696-4C5E-A2B0-228854FC81C8";

            var users = await UserService.GetAllAsync(request.ColleaugesId.ToArray());

            var today = DateTime.UtcNow;

            var discussion = new Data.Entities.Discussion
            {
                Id = Guid.NewGuid(),
                Subject = request.Subject,
                Location = request.Location,
                Outcomes = request.Outcomes,
                Date = request.Date,
                DiscussionUsers = new List<DiscussionUser>(),
                ObserverId = request.ObserverId,
                CreatedById = Guid.Parse(userId),
                CreatedDate = DateTime.UtcNow
            };


            foreach (var u in users)
            {
                discussion.DiscussionUsers.Add(new DiscussionUser
                {
                    User = u,
                    Discussion = discussion,
                    CreatedById = Guid.Parse(userId),
                    CreatedDate = DateTime.UtcNow
                });
            }
            try
            {
                await DiscussionService.CreateAsync(discussion);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }


            return Ok(discussion);

        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync(int? skip, int? take)
        {
            var discussion = await DiscussionService.FilterAsync(skip, take);

            var discussionDto = Mapper.Map<List<DiscussionDto>>(discussion.Item1);

            var dto = new
            {
                Discussion = discussionDto,
                Total = discussion.Item2
            };

            return Ok(dto);
        }



        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, DiscussionRequestModel request)
        {
            //var userId = User.FindFirstValue(ClaimTypes.Sid);
            //uncomment when ready to use
            var userId = "C7BF03EB-2696-4C5E-A2B0-228854FC81C8";

            var discussion = await DiscussionService.GetByIdAsync(id);

            if (discussion == null)
                return NotFound("Record Not Found");

            discussion.Subject = request.Subject;
            discussion.Location = request.Location;
            discussion.Outcomes = request.Outcomes;
            discussion.ObserverId = request.ObserverId;
            discussion.Date = request.Date;

            discussion.ModifiedById = Guid.Parse(userId);
            discussion.ModifiedDate = DateTime.UtcNow;

            await DiscussionService.UpdateAsync(discussion, request.ColleaugesId);

            return Ok(discussion.Id);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            //var userId = User.FindFirstValue(ClaimTypes.Sid);
            //uncomment when ready to use
            var userId = "C7BF03EB-2696-4C5E-A2B0-228854FC81C8";

            var discussion = await DiscussionService.GetByIdAsync(id);
            if (discussion == null)
                return NotFound("Record Not Found");

            discussion.ModifiedById = Guid.Parse(userId);
            discussion.ModifiedDate = DateTime.UtcNow;

            await DiscussionService.DeleteAsync(discussion);

            return Ok();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscussion(Guid id)
        {

            var discussion = await DiscussionService.GetByIdAsync(id);

            if (discussion == null)
                return NotFound();

            var userDto = Mapper.Map<GetDiscussionDto>(discussion);

            return Ok(userDto);
        }

    }
}
