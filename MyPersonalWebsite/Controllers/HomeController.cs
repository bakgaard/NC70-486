using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsite.Models;
using System.Collections.Generic;

namespace MyPersonalWebsite.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult TheViewBag()
		{
			//Passing dynamic messages
			ViewBag.Message = "This is a ViewBag message";
			return View();
		}

		public IActionResult TheViewData()
		{
			//Passing several array-based messages
			ViewData["Message"] = "A ViewData message";
			ViewData["Something"] = "A ViewData something...";

			return View();
		}

		public IActionResult TheViewDataDirectory()
		{
			//Passing an object as the model
			var infoList = new List<InfomationModel>()
			{
				new InfomationModel("First", "A"),
				new InfomationModel("Second", "B"),
			};

			//Passed here
			return View(infoList);
		}

		public IActionResult TheViewModel()
		{
			//Passing an object as the model
			var data = new ViewModels.InfomationViewModel();

			//Passed here
			return View(data);
		}

		public IActionResult TheCustomData()
		{
			ViewBag.Number = 1;
			return View();
		}
	}
}
