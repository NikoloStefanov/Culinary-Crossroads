using Culinary_Crossroads.Agent;
using Culinary_Crossroads.Core.Contacts;
using Culinary_Crossroads.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Culinary_Crossroads.Controllers
{
    public class AgentController : Controller
    {
        private readonly IAgentService agentService;
        public AgentController(IAgentService _agentService)
        {
            agentService = _agentService;
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await agentService.ExistByIdAsync(User.Id()))
            {
                return BadRequest();
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Become(BecomeAgentFormModel model)
        {
            if (await agentService.ExistByIdAsync(User.Id()))
            {
                return BadRequest();
            }
            if (await agentService.UserWithPhoneNumberExistAsync(model.PhoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), "Phone number always exists! Enter another one.");
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await agentService.CreateAsync(User.Id(), model.PhoneNumber);


            return RedirectToAction(nameof(FoodController.All), "Food");
        }
    }
}

