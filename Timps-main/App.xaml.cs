using TekTrackingCore.Views;

namespace TekTrackingCore;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		MainPage = new MainPage();
	}
}
