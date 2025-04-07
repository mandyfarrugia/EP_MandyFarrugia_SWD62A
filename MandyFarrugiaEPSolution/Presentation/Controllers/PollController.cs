using DataAccess.Repositories;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class PollController : Controller
    {
        public IActionResult Index([FromServices] IPollRepository pollRepository)
        {
            List<Poll> polls = pollRepository.GetPolls().OrderByDescending(poll => poll.CreatedAt).ToList();
            return View(polls);
        }

        public IActionResult Details([FromServices] IPollRepository pollRepository, int id)
        {
            var poll = pollRepository.GetPolls().FirstOrDefault(poll => poll.Id == id);

            if (poll == null)
            {
                return NotFound();
            }

            return View(poll);
        }
    }
}
