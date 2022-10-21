using TekTrackingCore.Views;

namespace TekTrackingCore;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Briefing), typeof(Briefing));

        Routing.RegisterRoute(nameof(Hos), typeof(Hos));


    }
}
