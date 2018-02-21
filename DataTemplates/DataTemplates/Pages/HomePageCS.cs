using Xamarin.Forms;

namespace DataTemplates.Pages
{
	public class HomePageCS : TabbedPage
	{
		public HomePageCS ()
		{
            Title = "List Frames";

            Children.Add(new FramesPage());
            Children.Add(new OtherPageCS());
		}
	}
}
