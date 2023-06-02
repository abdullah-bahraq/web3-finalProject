using finalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace finalProject.Controllers
{
	public class PedometerController : Controller
	{
		private StepsInfoContext _stpContext;
		public PedometerController (StepsInfoContext stpContext) 
		{
			_stpContext = stpContext;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Steps()
		{
			return View();
		}

		[HttpPost]
		public IActionResult StepsToCalories(StepInfo step)
		{
			step.time = DateTime.Now;
			double TotalCaloriesBurned = step.number * 0.04;
			
			ViewBag.number = "Not Valid";

			if(step.number > 0)	
			{
                ViewBag.number = step.number.ToString();

                _stpContext.StepInformation.Add(step);
				_stpContext.SaveChanges();
			}

            return View(TotalCaloriesBurned);
		}
	}
}
