using TekTrackingCore.ViewModels;

namespace TekTrackingCore.Views;

public partial class MainPage : ContentPage
{


	public MainPage(MianPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}

	
}

