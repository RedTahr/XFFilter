using Xamarin.Forms;

namespace XFFilter
{
	public partial class XFFilterPage : ContentPage
	{

		Button filter;

		public XFFilterPage ()
		{
			InitializeComponent ();
			filter.Text = "Filter";
			filter.Clicked += (sender, e) => {
				Navigation.PushAsync (new CategoryPage (Categories));
			};
		}
	}
}
