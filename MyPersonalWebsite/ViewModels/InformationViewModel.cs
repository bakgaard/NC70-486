using MyPersonalWebsite.Models;
using System.Collections.Generic;

namespace MyPersonalWebsite.ViewModels
{
	public class InfomationViewModel
	{
		public string Title { set; get; }
		public IEnumerable<InfomationModel> Infomation { get; set; }

		public InfomationViewModel()
		{
			Title = "ViewModel title";
			Infomation = new List<InfomationModel>()
			{
				new InfomationModel("First", "A"),
				new InfomationModel("Second", "B")
			};
		}
	}
}
