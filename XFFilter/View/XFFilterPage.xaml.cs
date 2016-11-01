using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XFFilter.View
{
	public partial class XFFilterPage : ContentPage
	{

		public ObservableCollection<Model.Category> Categories { get; set; }

		public XFFilterPage ()
		{
			Categories = new ObservableCollection<Model.Category> ();
			Categories.Add (new Model.Category { Name = "First", Value = "First", Selected = false });
			Categories.Add (new Model.Category { Name = "Second", Value = "Second", Selected = false });
			Categories.Add (new Model.Category { Name = "Third", Value = "Third", Selected = false });
			Categories.Add (new Model.Category { Name = "Fourth", Value = "Fourth", Selected = true });
			Categories.Add (new Model.Category { Name = "Fifth", Value = "Fifth", Selected = false });
			Categories.Add (new Model.Category { Name = "Sixth", Value = "Sixth", Selected = false });

			InitializeComponent ();

			filter.Clicked += (sender, e) => {
				Navigation.PushAsync (new CategoryPage (Categories));
			};
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			foreach (var item in Categories) {
				System.Diagnostics.Debug.WriteLine ("XFFilterPage OnAppearing:");
				System.Diagnostics.Debug.WriteLine ($"Category: {item.Name}, {item.Value}, {item.Selected}");
			}
		}

		protected override void OnDisappearing ()
		{
			foreach (var item in Categories) {
				System.Diagnostics.Debug.WriteLine ("XFFilterPage OnDisappearing:");
				System.Diagnostics.Debug.WriteLine ($"Category: {item.Name}, {item.Value}, {item.Selected}");
			}
			base.OnAppearing ();
		}
	}
}
