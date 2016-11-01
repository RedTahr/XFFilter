using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XFFilter.View
{
	public partial class CategoryPage : ContentPage
	{

		public ObservableCollection<Model.Category> Categories { get; set; }

		public CategoryPage (ObservableCollection<Model.Category> cats)
		{
			Categories = cats;

			BindingContext = this;

			InitializeComponent ();
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			foreach (var item in Categories) {
				System.Diagnostics.Debug.WriteLine ("CategoryPage OnAppearing:");
				System.Diagnostics.Debug.WriteLine ($"Category: {item.Name}, {item.Value}, {item.Selected}");
			}
		}


		protected override void OnDisappearing ()
		{
			foreach (var item in Categories) {
				System.Diagnostics.Debug.WriteLine ("CategoryPage OnDisappearing:");
				System.Diagnostics.Debug.WriteLine ($"Category: {item.Name}, {item.Value}, {item.Selected}");
			}
			base.OnAppearing ();
		}
	}
}
