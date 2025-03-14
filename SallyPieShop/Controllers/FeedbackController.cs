using Microsoft.AspNetCore.Mvc;
using SallyPieShop.Data;
using SallyPieShop.Models;

namespace SallyPieShop.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;
        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult SaveFeedback(Feedback feedback)
        {
            if(ModelState.IsValid)
            {
                _feedbackRepository.AddFeedback(feedback);
                _feedbackRepository.SaveChanges();
                return RedirectToAction("FeedbackCompleted");


            }
            return View(feedback);
        }
        public IActionResult FeedbackCompleted()
        {
            return View();
        }
    }
}
